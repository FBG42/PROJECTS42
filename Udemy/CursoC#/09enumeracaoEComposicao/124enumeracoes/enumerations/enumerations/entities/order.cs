using enumerations.entities.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumerations.entities
{
    class order
    {
        public int id { get; set; }
        public DateTime moment { get; set; }
        public orderStatus status { get; set; }

        public override string ToString()
        {
            return $"{id}, {moment}, {status}";
        }
    }
}
