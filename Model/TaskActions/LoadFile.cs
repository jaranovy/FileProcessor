using System;
using System.Collections.Generic;
using System.Text;

namespace FileProcessor.Model.TaskActions
{
    public class LoadFile : TaskAction
    {
        private string TableName;
        private string Query;
        private FileProcessorDbContext DbContext;

        public LoadFile(string tableName, string query, FileProcessorDbContext dbContext)
        {
            TableName = tableName;
            Query = query;
            DbContext = dbContext;
        }
        public override void Execute(string filePath)
        {
            LoadFileIntoTable(filePath);
            ExecuteQuery();
        }

        private void LoadFileIntoTable(string filePath)
        {
            throw new Exception("Not implemented");
            /* TODO */
        }

        private void ExecuteQuery()
        {
            throw new Exception("Not implemented");
            /* TODO */
        }
    }
}
