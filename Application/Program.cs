


using Core.Entities;
using Core.Enums;
using Core.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    internal class Program
    {
        public static void Main()
        {
            Product product = new Product();
            product.Description = "Test";
            product.Name = "Test";
            product.Category = Categories.BabyProducts;
            Console.WriteLine($"{product} Created");
            throw new ResourceNotFoundException("XYZ Product Not Found");

        }
    }
}
