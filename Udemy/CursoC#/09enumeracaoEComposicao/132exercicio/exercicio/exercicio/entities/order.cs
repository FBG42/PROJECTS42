using exercicio.entities.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio.entities
{
    internal class order
    {
        public DateTime date { get; set; }
        public orderStatus orderStatus { get; set; }
        public client client { get; set; }
        List<orderItem> items { get; set; } = new List<orderItem>();

        public order()
        {

        }

        public order(DateTime date, orderStatus orderStatus, client client)
        {
            this.date = date;
            this.orderStatus = orderStatus;
            this.client = client;
        }

        public void addItem(orderItem item)
        {
            items.Add(item);
        }

        public void removeItem(orderItem item)
        {
            items.Remove(item);
        }

        public double total()
        {
            double sum = 0; ;

            foreach (orderItem item in items)
            {
                sum += item.subTotal();
            }

            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("ORDER SUMARRY:");
            sb.AppendLine($"Order moment: {date.ToString("dd/MM/yyyy HH:mm:ss")}");
            sb.AppendLine($"Order status: {orderStatus}");
            sb.AppendLine($"Client: {client.name} ({client.birthDate.ToString("dd/MM/yyyy")}) - {client.email}");
            sb.AppendLine($"Order items:");
            foreach (orderItem item in items)
            {
                sb.AppendLine($"{item.product.name}, ${item.product.price}, Quantity: {item.quantity}, Subtotal: ${item.subTotal().ToString("F2")}");
            }
            sb.AppendLine($"Total price: ${total().ToString("F2")}");
            return sb.ToString();
        }
    }
}
