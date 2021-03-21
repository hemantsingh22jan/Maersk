using System;
using System.Collections.Generic;
using System.Text;

namespace ModelLayer
{
    public interface IProductModel
    {
        void GetPriceByType(ProductModel product);
        int GetTotalPrice(List<ProductModel> products);
    }
}
