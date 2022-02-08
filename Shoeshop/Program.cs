using System;
using Shoeshop.Models;
using Shoeshop.Admin;
using Microsoft.EntityFrameworkCore;

namespace Shoeshop
{
    class Program
    {
        public static bool WebshopMenu()
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Admin");
            Console.WriteLine("2) Customer");
            Console.WriteLine("3) Exit");



            switch (Console.ReadLine())
            {
                case "1":
                    AdminMenu();
                    return true;
                case "2":
                    //Customer();
                    return true;
                case "3":
                    //Exit();
                    return true;
                default:
                    return true;

            }

        }
        public static bool AdminMenu()
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Manage Categories");
            Console.WriteLine("2) Manage Products");

            switch (Console.ReadLine())
            {
                case "1":
                    ManageCategories();
                    return true;
                case "2":
                    ManageProducts();
                    return true;
                case "3":
                    Exit();
                    return true;
                default:
                    return true;
            }
        }

        public static bool ManageCategories()
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Add a category");
            Console.WriteLine("2) Remove a category");
            switch (Console.ReadLine())
            {
                case "1":
                    AddCategory();
                    return true;
                case "2":
                    RemoveCategory();
                    return true;
                //case "3":
                //    Exit();
                //    return true;
                default:
                    return true;
            }
        }
        public static void AddCategory()
        {
            PrintDatabase();
            Console.Write("Vilken kategori vill du lägga till?: ");
            var categoryName = Console.ReadLine();

            using (var database = new ShoeshopContext())
            {
                var newCategory = new Models.Category
                {
                    CategoryName = categoryName

                };

                database.Add(newCategory);
                database.SaveChanges();
                // System.Environment.Exit(1);
            }

        }
        public static void PrintDatabase()
        {
            using (var database = new ShoeshopContext())
            {
                var categoryList = database.Categories;
                foreach (var category in categoryList)
                {
                    Console.WriteLine(category.Id + "\t" + category.CategoryName);

                }
            }
        }

        public static void RemoveCategory()
        {
            using (var database = new ShoeshopContext())
            {
                PrintDatabase();

                Console.Write("Vilket kategorinummer vill du ta bort?: ");


                var categoryNumber = int.Parse(Console.ReadLine());
                var removeCategory = new Models.Category
                {
                    Id = categoryNumber

                };
                database.Attach(removeCategory);
                database.Remove(removeCategory);
                database.SaveChanges();
                // System.Environment.Exit(1);
                PrintDatabase();
            }

        }
        public static bool ManageProducts()
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Add a Product");
            Console.WriteLine("2) Remove a Product");
            Console.WriteLine("3) Update a Product");
            switch (Console.ReadLine())
            {
                case "1":
                    AddProduct();
                    return true;
                case "2":
                    RemoveProduct();
                    return true;
                case "3":
                    UpdateProduct();
                    return true;
                case "4":
                    Exit();
                    return true;
                default:
                    return true;
            }

        }
        
        static void Main(string[] args)
        {
            //bool showMenu = true;
            //while (showMenu)
            //{
            //    showMenu = WebshopMenu();
            //}

            WebshopMenu();



            //    using (var db = new ShoeshopContext())
            //{
            //    var productcategories = db.Categories;

            //    foreach (var category in productcategories)
            //   {
            //       Console.WriteLine(category.Id + "\t" + category.CategoryName);
            //    }
            //}

            //using (var db = new ShoeshopContext())
            //{
            //    var cities = db.Products;

            //    foreach (var city in cities)
            //    {
            //        Console.WriteLine(city.CityName);
            //        using (var dbb = new ShoeshopContext())
            //        {
            //            var parkingHouses = dbb.ParkingHouses;
            //            foreach (var house in parkingHouses)
            //            {
            //                if (city.Id == house.CityId)
            //                    Console.WriteLine(house.HouseName);
            //            }

            //        }
            //    }
            //}

            // while (true)
            //{
            //    using (var database = new ShoeshopContext())
            //    {
            //        var productList = database.Products;
            //        foreach (var product in productList)
            //        {
            //            Console.WriteLine(product.Id + "\t" + String.Format("{0:.00}", product.ProductPrice) + "\t" + product.ProductName);
            //        }
            //    }


            //Console.Write("Ange kategori:");
            //    var productCategoryId = Console.ReadLine();

            //    Console.Write("Ange namn:");
            //    var productName = Console.ReadLine();
            //Console.Write("Ange pris:");
            //var productPrice = Console.ReadLine();
            //Console.Write("Ange info:");
            //var productInfo = Console.ReadLine();

            //Console.Clear();


            //         using (var database = new ShoeshopContext())
            //           {
            //                var newProduct = new Models.Product
            //                {
            //                    ProductCategoryId = int.Parse(productCategoryId),
            //                    ProductName=productName,
            //                    ProductPrice=decimal.Parse(productPrice),
            //                    ProductInfo=productInfo

            //                };

            //                database.Add(newProduct);
            //               database.SaveChanges();
            //            }
        }
    }
}
