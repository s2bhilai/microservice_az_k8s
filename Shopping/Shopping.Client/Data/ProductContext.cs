using Shopping.Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.Client.Data
{
    public static class ProductContext
    {
        public static readonly List<Product> products = new List<Product>
        {
            new Product()
            {
                Name="IPhone X",
                Description = "asdfasdf",
                ImageFile="p-1.png",
                Price=345.00M,
                Category="Smart Phone"
            }
        };
    }
}
