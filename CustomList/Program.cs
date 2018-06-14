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
            CustomList<int> listA = new CustomList<int>() { 7, 4, 0, 7, 9 };
            listA.Add(listA[11]);

            Console.ReadLine();
        }
    }
}
