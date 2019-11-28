using System;

namespace FileProcessor.Model.TaskActions
{
    public class ProcessRecord : TaskAction
    {
        private string Query;
        private FileProcessorDbContext DbContext;

        public ProcessRecord(string query, FileProcessorDbContext dbContext)
        {
            Query = query;
            DbContext = dbContext;
        }
        public override void Execute(string filePath)
        {
            ExecuteQueryForEveryRecord(filePath);
        }

        private void ExecuteQueryForEveryRecord(string filePath)
        {
            throw new Exception("Not implemented");
            /* TODO */
        }
    }
}
