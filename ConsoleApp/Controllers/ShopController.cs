using ConsoleApp.Controllers;
using ConsoleApp.Handlers.ContextMenu;
using ConsoleApp.Helpers;
using ConsoleApp1;
using ConsoleMenu;
using StoreBLL.Services;
using StoreDAL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Services
{
    public static class ShopController
    {
        private static StoreDbContext context = UserMenuController.Context;
        public static void AddOrder()
        {   
            var service = new OrderService(context);
            var menu = new ContextMenu(new AdminContextMenuHandler(service, InputHelper.ReadOrderModel), service.Add);
            menu.Run();
        }
        public static void UpdateOrder()
        {
            var service = new OrderService(context);
            var menu = new ContextMenu(new AdminContextMenuHandler(service, InputHelper.ReadOrderModel), service.Update);
            menu.Run();
        }

        public static void DeleteOrder()
        {
            var service = new OrderService(context);
            var menu = new ContextMenu(new AdminContextMenuHandler(service, InputHelper.ReadOrderModel), service.Remove);
            menu.Run();
        }

        public static void ShowOrder()//???
        {
            var service = new OrderService(context);
            var menu = new ContextMenu(new AdminContextMenuHandler(service, InputHelper.ReadOrderModel), service.Find);
            menu.Run();
        }
        public static void ShowAllOrders()
        {
            var service = new OrderService(context);
            var menu = new ContextMenu(new AdminContextMenuHandler(service, InputHelper.ReadOrderModel), service.ToList);
            menu.Run();
        }

        public static void AddOrderDetails()
        {   
            var service = new OrderDetailsService(context);
            var menu = new ContextMenu(new AdminContextMenuHandler(service, InputHelper.ReadOrderDetailsModel), service.Add);
            menu.Run();
        }
        public static void UpdateOrderDetails()
        {
            var service = new OrderDetailsService(context);
            var menu = new ContextMenu(new AdminContextMenuHandler(service, InputHelper.ReadOrderDetailsModel), service.Update);
            menu.Run();
        }

        public static void DeleteOrderDetails()
        {
            var service = new OrderDetailsService(context);
            var menu = new ContextMenu(new AdminContextMenuHandler(service, InputHelper.ReadOrderDetailsModel), service.Remove);
            menu.Run();
        }

        public static void ShowAllOrderDetails()
        {
            var service = new OrderDetailsService(context);
            var menu = new ContextMenu(new AdminContextMenuHandler(service, InputHelper.ReadOrderDetailsModel), service.ToList);
            menu.Run();
        }

        public static void ProcessOrder()
        {
            var service = new OrderService(context);
            var menu = new ContextMenu(new AdminContextMenuHandler(service, InputHelper.ReadOrderModel), service.ProcessOrder);
            menu.Run();
        }
        
       public static void ShowAllOrderStates()
        {
            var service = new OrderStateService(context);
            var menu = new ContextMenu(new AdminContextMenuHandler(service, InputHelper.ReadOrderStateModel), service.GetAll);
            menu.Run();
        }

/*        public void DeleteProductTitle()
        {
            throw new NotImplementedException();
        }

        public void ShowAllProductTitles()
        {
            throw new NotImplementedException();
        }

        public void AddManufacturer()
        {
            throw new NotImplementedException();
        }
        public void UpdateManufacturer()
        {
            throw new NotImplementedException();
        }

        public void DeleteManufacturer()
        {
            throw new NotImplementedException();
        }

        public void ShowAllManufacturers()
        {
            throw new NotImplementedException();
        }

 */
    }
}
