using ModelLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer
{
    public class ProductSVC : IProductModel
    {
        public void GetPriceByType(ProductModel product)
        {
            switch (product.Id)
            {
                case "A":
                    product.Price = 50m;

                    break;
                case "B":
                    product.Price = 30m;

                    break;
                case "C":
                    product.Price = 20m;

                    break;
                case "D":
                    product.Price = 15m;
                    break;
            }
        }
        public int GetTotalPrice(List<ProductModel> products)
        {
            int counterOfA = 0;
            int priceOfA = 50;
            int counterOfB = 0;
            int priceOfB = 30;
            int counterOfC = 0;
            int priceOfC = 20;
            int counterOfD = 0;
            int priceOfD = 15;

            foreach (ProductModel pr in products)
            {
                switch (pr.Id)
                {
                    case "A":
                    case "a":
                        counterOfA += 1;
                        break;
                    case "B":
                    case "b":
                        counterOfB += 1;
                        break;
                    case "C":
                    case "c":
                        counterOfC += 1;
                        break;
                    case "D":
                    case "d":
                        counterOfD += 1;
                        break;
                }
            }
            int totalPriceOfA = (counterOfA / 3) * 130 + (counterOfA % 3 * priceOfA);
            int totalPriceOfB = (counterOfB / 2) * 45 + (counterOfB % 2 * priceOfB);
            int totalPriceOfC = (counterOfC * priceOfC);
            int totalPriceOfD = (counterOfD * priceOfD);
            return totalPriceOfA + totalPriceOfB + totalPriceOfC + totalPriceOfD;
        }
    }
}
