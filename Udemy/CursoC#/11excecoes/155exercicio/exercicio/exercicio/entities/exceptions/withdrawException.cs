using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio.entities.exceptions
{
    internal class withdrawException : ApplicationException
    {
        public withdrawException(string message) : base(message)
        {
        }
    }
}
