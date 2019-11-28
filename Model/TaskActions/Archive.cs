using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileProcessor.Model.TaskActions
{
    class Archive : TaskAction
    {
        private string destinationDirectory;

        public Archive(string destination)
        {
            this.destinationDirectory = destination;
        }

        public override void Execute(string filePath)
        {
            if ( !Directory.Exists(destinationDirectory))
            {
                throw new Exception($"Directory [{destinationDirectory}] does not exists");
            }

            copyFile(filePath, Path.Combine(destinationDirectory, Path.GetFileName(filePath)));
        }

        private void copyFile(string sourceFile, string destionation)
        {
            try
            {
                File.Copy(sourceFile, destinationDirectory);
            }
            catch (Exception ex)
            {
                throw new Exception($"Cannot copy file [{sourceFile}] to direcotry [{destinationDirectory}] because of {ex.Message}");
            }
        }
    }
}
