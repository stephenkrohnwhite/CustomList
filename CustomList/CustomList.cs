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
        private int count;
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
        public int Count
        {
            get
            {
                return count;
            }
            set
            {
                count = value;
                
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

        public CustomList()
        {
            Capacity = 5;
            Count = 0;
            Array = new T[Capacity];

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
       public void CapacityCheck()
        {
            if (Count > (Capacity - 2))
            {
                Capacity = Capacity += 5;
            }
        }
        public void Add(T objectToAdd)
        {
            Array[count] = objectToAdd;
            Count++;
            CapacityCheck();
        }
        public bool Remove(T objectToRemove)
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
      
        public void Zip()
        {

        }
    }
}
