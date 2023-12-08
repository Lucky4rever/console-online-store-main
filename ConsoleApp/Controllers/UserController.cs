using ConsoleApp1;
using StoreDAL.Data;
using StoreBLL.Models;
using StoreBLL.Services;
using ConsoleApp.Controllers;
using ConsoleApp.Handlers.ContextMenu;
using ConsoleApp.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleMenu;

namespace ConsoleApp.Services
{
    public static class UserController
    {
        private static StoreDbContext context = UserMenuController.Context;
        public static void AddUser()
        {
            var service = new UserService(context);
            var menu = new ContextMenu(new AdminContextMenuHandler(service, InputHelper.ReadUserModel), service.Add);
            menu.Run();
        }
        public static void UpdateUser()
        {
            var service = new UserService(context);
            var menu = new ContextMenu(new AdminContextMenuHandler(service, InputHelper.ReadUserModel), service.Update);
            menu.Run();
        }

        public static void DeleteUser()
        {
            var service = new UserService(context);
            var menu = new ContextMenu(new AdminContextMenuHandler(service, InputHelper.ReadUserModel), service.Remove);
            menu.Run();
        }

        public static void ShowUser()//???
        {
            var service = new UserService(context);
            var menu = new ContextMenu(new AdminContextMenuHandler(service, InputHelper.ReadUserModel), service.Find);
            menu.Run();
        }
        public static void ShowAllUsers()
        {
            var service = new UserService(context);
            var menu = new ContextMenu(new AdminContextMenuHandler(service, InputHelper.ReadUserModel), service.ToList);
            menu.Run();
        }

        public static void AddUserRole()
        {
            var service = new UserService(context);
            var menu = new ContextMenu(new AdminContextMenuHandler(service, InputHelper.ReadUserRoleModel), service.Add);
            menu.Run();
        }
        public static void UpdateUserRole()
        {
            var service = new UserService(context);
            var menu = new ContextMenu(new AdminContextMenuHandler(service, InputHelper.ReadUserRoleModel), service.Update);
            menu.Run();
        }

        public static void DeleteUserRole()
        {
            var service = new UserService(context);
            var menu = new ContextMenu(new AdminContextMenuHandler(service, InputHelper.ReadUserRoleModel), service.Remove);
            menu.Run();
        }


        public static void ShowAllUserRoles()
        {
            var service = new UserRoleService(context);
            var menu = new ContextMenu(new AdminContextMenuHandler(service, InputHelper.ReadUserRoleModel), service.GetAll);
            menu.Run();
        }

        public static void AddProductTitle()
        {
            var service = new ProductTitleService(context);
            var menu = new ContextMenu(new AdminContextMenuHandler(service, InputHelper.ReadProductTitleModel), service.Add);
            menu.Run();
        }
        public static void UpdateProductTitle()
        {
            var service = new ProductTitleService(context);
            var menu = new ContextMenu(new AdminContextMenuHandler(service, InputHelper.ReadProductTitleModel), service.Update);
            menu.Run();
        }

        public static void DeleteProductTitle()
        {
            var service = new ProductTitleService(context);
            var menu = new ContextMenu(new AdminContextMenuHandler(service, InputHelper.ReadProductTitleModel), service.Remove);
            menu.Run();
        }

        public static void ShowAllProductTitles()
        {
            var service = new ProductTitleService(context);
            var menu = new ContextMenu(new AdminContextMenuHandler(service, InputHelper.ReadProductTitleModel), service.GetAll);
            menu.Run();
        }

        public static void AddManufacturer()
        {
            var service = new ManufacturerService(context);
            var menu = new ContextMenu(new AdminContextMenuHandler(service, InputHelper.ReadManufacturerModel), service.Add);
            menu.Run();
        }
        public static void UpdateManufacturer()
        {
            var service = new ManufacturerService(context);
            var menu = new ContextMenu(new AdminContextMenuHandler(service, InputHelper.ReadManufacturerModel), service.Update);
            menu.Run();
        }

        public static void DeleteManufacturer()
        {
            var service = new ManufacturerService(context);
            var menu = new ContextMenu(new AdminContextMenuHandler(service, InputHelper.ReadManufacturerModel), service.Remove);
            menu.Run();
        }

        public static void ShowAllManufacturers()
        {
            var service = new ManufacturerService(context);
            var menu = new ContextMenu(new AdminContextMenuHandler(service, InputHelper.ReadManufacturerModel), service.GetAll);
            menu.Run();
        }
    }
}
