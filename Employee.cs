using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemoAppConCoreCS
{
    internal class Employee : IClassDesign
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }

        public void ShowData()
        {
            Console.WriteLine("Emp Id : " + EmpID + " Emp Name : " + EmpName);
        }

        public override string ToString()
        {
            return "Emp Id : " + EmpID + " Emp Name : " + EmpName;
        }
    }
}
