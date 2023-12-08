using ConsoleApp1;
using StoreDAL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Controllers
{
    public static class ProductController
    {
        private static StoreDbContext context=UserMenuController.Context;
        public static void AddProduct()
        {
            var service = new ProductService(context);
            var menu = new ContextMenu(new AdminContextMenuHandler(service, InputHelper.ReadProductModel), service.Add);
            menu.Run();
        }
        public static void UpdateProduct()
        {
            var service = new ProductService(context);
            var menu = new ContextMenu(new AdminContextMenuHandler(service, InputHelper.ReadProductModel), service.Update);
            menu.Run();
        }

        public static void DeleteProduct()
        {
            var service = new ProductService(context);
            var menu = new ContextMenu(new AdminContextMenuHandler(service, InputHelper.ReadProductModel), service.Remove);
            menu.Run();
        }

        public static void ShowProduct()//???
        {
            var service = new ProductService(context);
            var menu = new ContextMenu(new AdminContextMenuHandler(service, InputHelper.ReadProductModel), service.Find);
            menu.Run();
        }
        public static void ShowAllProducts()
        {
            var service = new ProductService(context);
            var menu = new ContextMenu(new AdminContextMenuHandler(service, InputHelper.ReadProductModel), service.ToList);
            menu.Run();
        }

        public static void AddCategory()
        {   
            var service = new CategoryService(context);
            var menu = new ContextMenu(new AdminContextMenuHandler(service, InputHelper.ReadCategoryModel), service.Add);
            menu.Run();
        }
        public static void UpdateCategory()
        {
            var service = new CategoryService(context);
            var menu = new ContextMenu(new AdminContextMenuHandler(service, InputHelper.ReadCategoryModel), service.Update);
            menu.Run();
        }

        public static void DeleteCategory()
        {
            var service = new CategoryService(context);
            var menu = new ContextMenu(new AdminContextMenuHandler(service, InputHelper.ReadCategoryModel), service.Remove);
            menu.Run();
        }


        public static void ShowAllCategories()
        {
            var service = new CategoryService(context);
            var menu = new ContextMenu(new AdminContextMenuHandler(service, InputHelper.ReadCategoryModel), service.ToList);
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
