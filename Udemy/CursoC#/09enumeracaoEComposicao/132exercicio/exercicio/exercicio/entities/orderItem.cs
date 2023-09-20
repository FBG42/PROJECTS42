using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio.entities
{
    internal class orderItem
    {
        public int quantity { get; set; }
        public double price { get; set; }
        public product product { get; set; }

        public orderItem()
        {

        }

        public orderItem(int quantity, double price, product product)
        {
            this.quantity = quantity;
            this.price = price;
            this.product = product;
        }

        public double subTotal()
        {
            return quantity * price;
        }
    }
}
