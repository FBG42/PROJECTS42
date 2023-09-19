using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio.entities
{
    internal class departament
    {
        public string name { get; set; }

        public departament()
        {

        }

        public departament(string _name)
        {
            this.name = _name;
        }
    }
}
