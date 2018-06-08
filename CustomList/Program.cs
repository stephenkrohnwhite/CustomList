using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<string> List = new CustomList<string>();
            List.Add("1");
            List.Add("3");
            List.Add("7");
            List.Add("9");
            List.Add("1");
            List.Remove("1");
            Console.WriteLine(List[3]);
        }
    }
}
