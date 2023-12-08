using StoreBLL.Interfaces;
using StoreBLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Handlers.ContextMenu
{
    public class ShoppingContextMenuHandler : ContextMenuHandler
    {
        public ShoppingContextMenuHandler(ICrud service, Func<AbstractModel> readModel):base(service,readModel)
        {
        }

        public void CreateOrder()
        {
            var order = this.ReadModel();
            var orderDetails = new List<OrderDetailModel>();
            while (true)
            {
                Console.WriteLine("Input Order Detail Id");
                var id = int.Parse(Console.ReadLine());
                Console.WriteLine("Input Order Detail OrderId");
                var orderId = int.Parse(Console.ReadLine());
                Console.WriteLine("Input Order Detail ProductId");
                var productId = int.Parse(Console.ReadLine());
                Console.WriteLine("Input Order Detail Quantity");
                var quantity = int.Parse(Console.ReadLine());
                orderDetails.Add(new OrderDetailModel(id, orderId, productId, quantity));
                Console.WriteLine("Do you want to add another Order Detail? (y/n)");
                var answer = Console.ReadLine();
                if (answer == "n")
                {
                    break;
                }
            }
            this.service.Create(order);
            foreach (var orderDetail in orderDetails)
            {
                this.service.Create(orderDetail);
            }
        }

        public override (ConsoleKey id, string caption, Action action)[] GenerateMenuItems()
        {
            (ConsoleKey id, string caption, Action action)[] array = {
             (ConsoleKey.V,"View Details", this.GetItemDetails)
            ,(ConsoleKey.A,"Add item to chart and create order", this.CreateOrder)
            };
            return array;
        }
    }
}
