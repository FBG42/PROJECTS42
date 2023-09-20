using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio.entities
{
    internal class product
    {
        public string name { get; set; }
        public double price { get; set; }

        public product()
        {

        }

        public product(string name, double price)
        {
            this.name = name;
            this.price = price;
        }
    }
}
