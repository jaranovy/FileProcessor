using System;
using System.Collections.Generic;
using System.Text;

namespace FileProcessor.Model.TaskActions
{
    public abstract class TaskAction
    {
        public abstract void Execute(string filePath);
    }
}
