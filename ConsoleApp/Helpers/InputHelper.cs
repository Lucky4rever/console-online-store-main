using StoreBLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Helpers
{
    internal static class InputHelper
    {
        public static CategoryModel ReadCategoryModel()
        {
            Console.WriteLine("Input Category Id");
            var id=int.Parse(Console.ReadLine());
            Console.WriteLine("Input Category Name");
            var name = Console.ReadLine();
            return new CategoryModel(id,name);
        }   

        public static ManufacturerModel ReadManufacturerModel()
        {
            Console.WriteLine("Input Manufacturer Id");
            var id=int.Parse(Console.ReadLine());
            Console.WriteLine("Input Manufacturer Name");
            var name = Console.ReadLine();
            return new ManufacturerModel(id,name);
        }

        public static OrderStateModel ReadOrderStateModel()
        {
            Console.WriteLine("Input State Id");
            var id=int.Parse(Console.ReadLine());
            Console.WriteLine("Input State Name");
            var name = Console.ReadLine();
            return new OrderStateModel(id,name);
        }

        public static UserRoleModel ReadUserRoleModel()
        {
            Console.WriteLine("Input User Role Id");
            var id = int.Parse(Console.ReadLine());
            Console.WriteLine("Input User Role Name");
            var name = Console.ReadLine();
            return new UserRoleModel(id, name);
        }

        public static ProductTitleModel ReadProductTitleModel()
        {
            Console.WriteLine("Input Product Title Id");
            var id = int.Parse(Console.ReadLine());
            Console.WriteLine("Input Product Title Name");
            var name = Console.ReadLine();
            return new ProductTitleModel(id, name);
        }

        public static ProductModel ReadProductModel()
        {
            Console.WriteLine("Input Product Id");
            var id = int.Parse(Console.ReadLine());
            Console.WriteLine("Input Product Title Id");
            var titleId = int.Parse(Console.ReadLine());
            Console.WriteLine("Input Product Manufacturer Id");
            var manufacturerId = int.Parse(Console.ReadLine());
            Console.WriteLine("Input Product Category Id");
            var categoryId = int.Parse(Console.ReadLine());
            Console.WriteLine("Input Product Price");
            var price = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Input Product Quantity");
            var quantity = int.Parse(Console.ReadLine());
            return new ProductModel(id, titleId, manufacturerId, categoryId, price, quantity);
        }
        
        public static OrderDetailModel ReadOrderDetailModel()
        {
            Console.WriteLine("Input Order Detail Id");
            var id = int.Parse(Console.ReadLine());
            Console.WriteLine("Input Order Detail Order Id");
            var orderId = int.Parse(Console.ReadLine());
            Console.WriteLine("Input Order Detail Product Id");
            var productId = int.Parse(Console.ReadLine());
            Console.WriteLine("Input Order Detail Quantity");
            var quantity = int.Parse(Console.ReadLine());
            return new OrderDetailModel(id, orderId, productId, quantity);
        }

        public static CustomerOrderModel ReadCustomerOrderModel()
        {
            Console.WriteLine("Input Customer Order Id");
            var id = int.Parse(Console.ReadLine());
            Console.WriteLine("Input Customer Order User Id");
            var userId = int.Parse(Console.ReadLine());
            Console.WriteLine("Input Customer Order Order State Id");
            var orderStateId = int.Parse(Console.ReadLine());
            Console.WriteLine("Input Customer Order Order Date");
            var orderDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Input Customer Order Delivery Date");
            var deliveryDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Input Customer Order Delivery Address");
            var deliveryAddress = Console.ReadLine();
            return new CustomerOrderModel(id, userId, orderStateId, orderDate, deliveryDate, deliveryAddress);
        }

        public static UserModel ReadUserModel()
        {
            Console.WriteLine("Input User Id");
            var id = int.Parse(Console.ReadLine());
            Console.WriteLine("Input User User Role Id");
            var userRoleId = int.Parse(Console.ReadLine());
            Console.WriteLine("Input User Login");
            var login = Console.ReadLine();
            Console.WriteLine("Input User Password");
            var password = Console.ReadLine();
            Console.WriteLine("Input User First Name");
            var firstName = Console.ReadLine();
            Console.WriteLine("Input User Last Name");
            var lastName = Console.ReadLine();
            Console.WriteLine("Input User Email");
            var email = Console.ReadLine();
            Console.WriteLine("Input User Phone");
            var phone = Console.ReadLine();
            return new UserModel(id, userRoleId, login, password, firstName, lastName, email, phone);
        }
    }
}
