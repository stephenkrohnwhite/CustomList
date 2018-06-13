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
            CustomList<int> listA = new CustomList<int>() { 6, 4, 0, 7, 9 };
            CustomList<int> listB = new CustomList<int>() { 7, 9, 11 };
            CustomList<int> listC = listA.Sort(listA);
            Console.WriteLine(listC.ToString());
            Console.ReadLine();
        }
    }
}
