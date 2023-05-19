using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stonks
{
    internal class Zapis
    {
        public string name { get; set; }
        public string type { get; set; }
        public int cost { get; set; }
        public Zapis(string name, string type, int cost)
        {
            this.name = name;
            this.type = type;
            this.cost = cost;
           
        }

    }
}
