using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemoAppConCoreCS
{
    internal class MyGenCollection<MyType> where MyType : IClassDesign
    {
        private List<MyType> list;
        public MyGenCollection()
        {
            list = new List<MyType>();
        }

        public void Add(MyType item)
        {
            list.Add(item);
        }

        public void Remove(MyType myType)
        {
            list.Remove(myType);
        }

        public void ShowList()
        {
            foreach (var item in list)
            {
                item.ShowData();
            }
        }
    }
}
