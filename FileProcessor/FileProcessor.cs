using FileProcessor.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace FileProcessor
{
    class FileProcessor
    {
        private static string DEFAULT_SCHEMA = @"http://novych.cz/schemas/Schemas/FileProcessorConfig";
        private static string DEFAULT_SCHEMA_PATH = @"..\..\..\TestingData\FileProcessorConfig.xsd";

        public FileProcessor(string configFilePath)
        {
            Console.WriteLine($"Used config file [{configFilePath}]");

            /* Load configuration */
            loadConfigFile(configFilePath);

        }


        /* Load configuration */
        private void loadConfigFile(string configFilePath)
        {
            Console.WriteLine($"Loading configuration from [{configFilePath}]");

            XmlSerializer configSerializer = new XmlSerializer(typeof(FileProcessorConfig));

            /* Define XML Reader Settings */
            XmlReaderSettings xmlReaderSettings = new XmlReaderSettings();
            xmlReaderSettings.ConformanceLevel = ConformanceLevel.Document;
            xmlReaderSettings.ValidationType = ValidationType.Schema;
            xmlReaderSettings.Schemas.Add(DEFAULT_SCHEMA, DEFAULT_SCHEMA_PATH);

            using (XmlReader xmlReader = XmlReader.Create(configFilePath, xmlReaderSettings))
            {
                FileProcessorConfig config = (FileProcessorConfig)configSerializer.Deserialize(xmlReader);
            }

            Console.WriteLine($"Configuration [{configFilePath}] loaded");
        }
    }
}
