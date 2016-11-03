using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsDoLinq.Extensions
{
    public static class PrintExtension
    {
      
    public static void Print<T>(this IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }




        public static void Print(this Person person)
        {
            Console.WriteLine(person);
        }

       

    }
}
