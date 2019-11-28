using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileProcessor.Model.TaskActions
{
    class CheckFile : TaskAction
    {
        public override void Execute(string filePath)
        {
            checkFile(filePath);
        }

        private void checkFile(string filePath)
        {
            if ( !File.Exists(filePath) )
            {
                throw new Exception($"File {filePath} does not exists");
            }
        }
    }
}
