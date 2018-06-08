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
            CustomList<int> List = new CustomList<int>();
            List.Add(1);
            List.Add(1);
            List.Add(1);
            List.Add(1);
            List.Add(1);
            List.Add(1);
            //List.Add(1);
            //List.Add(3);
            //Console.WriteLine(List.ToString());
        }
    }
}
