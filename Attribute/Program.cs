using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attribute
{
    
    class Program
    {
       
        static void Main(string[] args)
        {
            Type tp = typeof(MyClass);
            Type tb = typeof(VersionAttribute);
            VersionAttribute version = (VersionAttribute)System.Attribute.GetCustomAttribute(tp, typeof(VersionAttribute));
            Console.WriteLine("Name=" + version.Name);
            Console.WriteLine("Date=" + version.Date);
            Console.WriteLine("Description=" + version.Description);
            version.Show();
            Console.ReadKey();
        }
    }
}
