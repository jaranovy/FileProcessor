using System;
using System.Collections.Generic;
using System.Text;

namespace FileProcessor.Model.TaskActions
{
    public class Export : TaskAction
    {
        private string Query;
        private string Destination;
        private FileProcessorDbContext DbContext;

        public Export(string query, string destination, FileProcessorDbContext dbContext)
        {
            Query = query;
            Destination = destination;
            DbContext = dbContext;
        }

        public override void Execute(string filePath)
        {
            ExportData();
        }

        private void ExportData()
        {
            throw new Exception("Not implemented");
            /* TODO */
        }
    }
}
