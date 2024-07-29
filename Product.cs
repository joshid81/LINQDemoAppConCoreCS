using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemoAppConCoreCS
{
    internal class Product : IClassDesign
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }

        public void ShowData()
        {
            Console.WriteLine("Product Id : " + ProductID + " ProductName : " + ProductName);
        }

        public override string ToString()
        {
            return "Product Id : " + ProductID + " ProductName : " + ProductName;
        }
    }
}
