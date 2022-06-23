using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WiredBrainCofee
{
    public static class Addition
    {
        public static void AddValues(this List<string> list)
        {
            foreach (var item in list)
               
            Console.WriteLine(item );
        }
    }
}
