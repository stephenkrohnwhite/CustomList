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
            List<int> ListA = new List<int>() { 1, 2 };
            List<int> ListB = new List<int>() { 4, 6 };
            List<int> ListC = ListA + ListB;
            Console.WriteLine(ListC.ToString());
            Console.ReadLine();
        }
    }
}
