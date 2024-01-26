using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio.entities
{
    internal class usedProduct: product
    {
        public DateTime manufactureDate { get; set; }

        public usedProduct()
        {

        }

        public usedProduct(string name, double price, DateTime manufactureDate) : base(name, price)
        {
            this.manufactureDate = manufactureDate;
        }

        public override string priceTag()
        {
            return $"{name} (used) $ {price} (Manufacture date: {manufactureDate.ToString("dd/MM/yyyy")})$";
        }
    }
}
