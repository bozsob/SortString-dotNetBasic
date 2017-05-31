using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortString
{
    class Program
    {

        static void Main(string[] args)
        {
            string str = "The dearest ones of time, the strongest friends of the soul--BOOKS. By Emily Dickinson";
            
            string[] sa = str.Split(' ');
            foreach(string s in sa)
            {
                Console.WriteLine(s);
            }
            

            Array.Sort(sa);
            Console.WriteLine("after sorting:");
            foreach (string s in sa)
            {
                Console.WriteLine(s);
            }


            str = string.Join(" ", sa);
            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
