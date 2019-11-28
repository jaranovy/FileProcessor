using FileProcessor.Model;
using System;
using System.Linq;

namespace FileProcessor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            
            using (var context = new FileProcessorDbContext())
            {
                Console.WriteLine("Goods with more than 10 availible items:");

                var goods = context.Zbozi.Where(item => item.pocet_kusu_skladem > 10);

                foreach(Zbozi item in goods)
                {
                    Console.WriteLine($"   {item.ID} : {item.nazev} : {item.pocet_kusu_skladem}");
                }
            }
        }
    }
}
