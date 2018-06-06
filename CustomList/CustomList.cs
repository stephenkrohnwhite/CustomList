using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T>
    {
        private T[] array;
        private int capacity;
        public T[] Array
        {
            get
            {
                return array;
            }
            set
            {
                array = value;
            }
        }
        public int Capacity
        {
            get
            {
                return capacity;
            }
            set
            {
                capacity = value;
            }
        }
        T value;
        // Method that adds objects to instance of class
        // Method that remove objects to instance of class
        // Method that allows iteration
        // Method for overriding ToString - converts to string
        // Method for overloading + operator
        // Method for overLoading - operator
        // Property for count
        // Method for Zip

        public CustomList(int capacityValue)
        {
           Capacity = capacityValue;

        }
        
        public T this[int i]
        {
            get
            {
                return Array[i];
            }
            set
            {
                Array[i] = value;
            }
        }
        
       
        public void Add()
        {

        }
        public void Remove()
        {

        }
        public void Iterate()
        {

        }
        public void ConvertToString()
        {

        }
        public void OverloadPlus()
        {

        }
        public void OverloadMinus()
        {

        }
        public void Count()
        {

        }
        public void Zip()
        {

        }
    }
}
