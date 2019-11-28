using System;
using System.Collections.Generic;
using System.Text;

namespace FileProcessor.Model
{
    public class Zbozi
    {
        public int ID { get; set; }
        public string nazev { get; set; }
        public int pocet_kusu_skladem { get; set; }
        public int pocet_objednanych_kusu { get; set; }
    }
}
