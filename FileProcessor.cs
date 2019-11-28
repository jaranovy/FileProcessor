using FileProcessor.Model;
using FileProcessor.Model.TaskActions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace FileProcessor
{
    class FileProcessor
    {
        private static string DefaultSchema = @"http://novych.cz/schemas/Schemas/FileProcessorConfig";
        private static string DefaultSchemePath = @"..\..\..\TestingData\FileProcessorConfig.xsd";

        private FileProcessorConfig configuration;

        private IEnumerable<Task> tasks;

        private FileProcessorDbContext DbContext;

        public FileProcessor(string configFilePath)
        {
            DbContext = new FileProcessorDbContext();

            /* Load configuration */
            loadConfigFile(configFilePath);

            prepareTasks();
        }

        /* Prepare task from configuration */
        private void prepareTasks()
        {
            tasks = new List<Task>();

            foreach (FileProcessorConfigTask cfgTask in configuration.Task)
            {
                Task task = new Task();

                var files = new List<string>();
                var actions = new List<TaskAction>();

                /* Load files */
                if (cfgTask.Files.File != null)
                {
                    foreach (string cfgFilePath in cfgTask.Files.File)
                    {
                        files.Add(cfgFilePath);
                    }
                }

                /* Load files as mask */
                if (cfgTask.Files.FileMask != null)
                {
                    foreach (string cfgFileMask in cfgTask.Files.FileMask)
                    {
                        files.AddRange(Directory.GetFiles(cfgFileMask));
                    }
                }

                task.FilePaths = files;

                /* Register CheckFile action */
                actions.Add(new CheckFile());

                /* Register other defined actions */
                foreach (FileProcessorConfigTaskAction taskAction in cfgTask.Actions)
                {
                    string type = taskAction.Type;

                    if (type.CompareTo("Archive") == 0)
                    {
                        Archive archive = new Archive(taskAction.Destination);
                        actions.Add(archive);
                    }
                    else if (type.CompareTo("LoadFile") == 0)
                    {
                        LoadFile loadFile = new LoadFile(taskAction.TableName, taskAction.Query, DbContext);
                        actions.Add(loadFile);
                    }
                    else if (type.CompareTo("ProcessRecord") == 0)
                    {
                        ProcessRecord processRecord = new ProcessRecord(taskAction.Query, DbContext);
                        actions.Add(processRecord);
                    }
                    else if (type.CompareTo("Export") == 0)
                    {
                        Export export = new Export(taskAction.Query, taskAction.Destination, DbContext);
                        actions.Add(export);
                    }
                    else
                    {
                        throw new Exception($"Action [{type}] not recognized");
                    }
                }

                
                task.Actions = actions;
            }
        }

        /* Load configuration XML file */
        private void loadConfigFile(string configFilePath)
        {
            try
            {
                Console.WriteLine($"Loading configuration from [{configFilePath}]");

                XmlSerializer configSerializer = new XmlSerializer(typeof(FileProcessorConfig));

                /* Define XML Reader Settings */
                XmlReaderSettings xmlReaderSettings = new XmlReaderSettings();
                xmlReaderSettings.ConformanceLevel = ConformanceLevel.Document;

                if (File.Exists(DefaultSchemePath))
                {
                    xmlReaderSettings.ValidationType = ValidationType.Schema;
                    xmlReaderSettings.Schemas.Add(DefaultSchema, DefaultSchemePath);
                }

                using (XmlReader xmlReader = XmlReader.Create(configFilePath, xmlReaderSettings))
                {
                    configuration = (FileProcessorConfig)configSerializer.Deserialize(xmlReader);
                }

                Console.WriteLine($"Configuration [{configFilePath}] loaded");

            }
            catch (Exception ex)
            {
                throw new Exception($"Cannot read configuration from [{configFilePath}] because of [{ex.Message}]");
            }
        }
    }
}
