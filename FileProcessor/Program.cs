using FileProcessor.Model;
using System;
using System.Linq;

namespace FileProcessor
{
    class Program
    {
        /* Main function */
        static void Main(string[] args)
        {
            string configFilePath;

            parseArguments(args, out configFilePath);

            var fp = new FileProcessor(configFilePath);

        }

        /* Parse program arguments */
        static void parseArguments(string[] args, out string configFilePath)
        {
            configFilePath = "";

            for (int i = 0; i < args.Length; i++)
            {
                switch (args[i])
                {
                    case "-c":
                        if (args.Length > i)
                        {
                            configFilePath = args[i + 1];
                            // Console.WriteLine($"Used data file [{dataFilepath}]");
                            i += 1;
                        }
                        else
                        {
                            ShowHelp($"Parameter [-c] without value");
                        }
                        break;
                    default:
                        ShowHelp($"Undefined parameter [{args[i]}]");
                        break;
                }
            }

            if (configFilePath.Length == 0)
            {
                ShowHelp($"Task configuration file not defined");
            }
        }

        /* Show application help */
        static void ShowHelp(string msg)
        {
            Console.WriteLine("Usage: FileProcessor.exe -c <xml task config file path>");
            Console.WriteLine($"Error: {msg}");
            Environment.Exit(1);
        }
    }
}
