using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attribute
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class VersionAttribute : System.Attribute
    {
        public string Name { get; set; }
        public string Date { get; set; }
        public string Description { get; set; }

        public string DD { get; set; }


        public void Show()
        {
            Console.WriteLine("名称：{0} 日期： {1} 描述：{2}", Name, Date, Description);
        }
    }

    [Version(Name ="版本检测", Date ="2016-9-18", Description="刚会用来一发")]
    public class MyClass
    {
    }
}
