using FileProcessor.Model.TaskActions;
using System;
using System.Collections.Generic;

namespace FileProcessor.Model
{
    public class Task
    {
        public IEnumerable<String> FilePaths { get; set; }

        public IEnumerable<TaskAction> Actions { get; set; }
    }
}
