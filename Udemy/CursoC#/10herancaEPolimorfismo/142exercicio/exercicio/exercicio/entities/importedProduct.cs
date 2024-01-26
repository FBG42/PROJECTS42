using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio.entities
{
    internal class importedProduct: product
    {
        public double customFee { get; set; }

        public importedProduct()
        {

        }

        public importedProduct(string name, double price, double customFee) : base (name, price)
        {
            this.customFee = customFee;
        }

        public double totalPrice()
        {
            return price + customFee;
        }

        public override string priceTag()
        {
            return $"{name} $ {totalPrice():F2} (Customs fee: $ 20.00)";
        }
    }
}
