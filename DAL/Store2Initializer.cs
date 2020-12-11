using Store2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Store2.DAL
{
    public class Store2Initializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<Store2Context>
    {
        protected override void Seed(Store2Context context)
        {
            var products = new List<Product>
            {
            new Product{ProductID=1,DeliveryID=1,Name="Паста" ,Description="Yfdfd",Price=1,ShelfLife="11.11.11",CountInStore=1}
            };

            products.ForEach(s => context.Products.Add(s));
            context.SaveChanges();
            var clients = new List<Client>
            {
            new Client{ClientID=10,NameOfClient = "Вася",AddressOfClient = "Pdfds",PhoneOfClient="0909rew",EmailOfClient="ddfsdfsd"}
            };
            clients.ForEach(s => context.Clients.Add(s));
            context.SaveChanges();
            var deliveries = new List<Delivery>
            {
            new Delivery{DeliveryID=1,DataOfDelivery="fsfs",SumOfDelivery=423432,CountOfDellivery=1}
            };
            deliveries.ForEach(s => context.Deliveries.Add(s));
            context.SaveChanges();
            var employees = new List<Employee>
            { 
            new Employee { EmployeeID=1,NameOfEmployee="FDFS",NameOfPosition="FFDSF",Address="dsfdsf",PhoneOfEmployee="+3434343",Birthday="11.11.11"}
            };
            employees.ForEach(s => context.Employees.Add(s));
            context.SaveChanges();
            var orders = new List<Order>
            {
            new Order { OrderID=1,ClientID=10,EmployeeID=1,DataOfOrder="11.11.11",CountOfProduct=11}
            };
            orders.ForEach(s => context.Orders.Add(s));
            context.SaveChanges();
            var product_orders = new List<Product_Order>
            {
            new Product_Order {Product_OrderID=1, ProductID=1,OrderID=1}
            };
            product_orders.ForEach(s => context.Product_Orders.Add(s));
            context.SaveChanges();
            var provider_deliveries = new List<Provider_Delivery>
            {
            new Provider_Delivery {Provider_DeliveryID=1, ProviderID=1,DeliveryID=1}
            };
            product_orders.ForEach(s => context.Product_Orders.Add(s));
            context.SaveChanges();
            var providers = new List<Provider>
            {
            new Provider { ProviderID=1,NameOfOrgfnization="fsfds",NameOfProducts="fdsfdfs",Phone="+rerwwr",Email="fdsfds"}
            };
            providers.ForEach(s => context.Providers.Add(s));
            context.SaveChanges();
        }
    }
}