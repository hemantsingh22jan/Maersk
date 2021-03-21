using ModelLayer;
using ServiceLayer;
using System;
using System.Collections.Generic;

namespace PromotionEngine
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("****Promotion Engine****");
            List<ProductModel> products = new List<ProductModel>();
            ProductSVC objProductService = new ProductSVC();
        hitMe:
            Console.WriteLine("Enter number(s) of order");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Enter the Type of Product:A,B,C or D");
                string type = Console.ReadLine();
                ProductModel objProduct = new ProductModel() { Id = type };

                objProductService.GetPriceByType(objProduct);


                products.Add(objProduct);
            }

            int totalPrice = objProductService.GetTotalPrice(products);
            Console.WriteLine(totalPrice);
            Console.WriteLine("----------------");
            Console.WriteLine("Do you want to continue (Y/N)? ");
            if (Console.ReadLine().Contains("Y", StringComparison.CurrentCultureIgnoreCase))
            {
                goto hitMe;
            }
        }
    }
}
