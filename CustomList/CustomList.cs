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

        // Use IEnumerator to make object iterable
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
            CustomList<T> tempList = new CustomList<T>();
            for(int i=0; i<Count; i++)
            {
                if(!Array[i].Equals(objectToRemove))
                {
                    tempList.Add(Array[i]);
                }
                else if(Array[i].Equals(objectToRemove))
                {
                    for(int j = i+1; j<Count; j++)
                    {
                        tempList.Add(Array[j]);
                    }
                    if(LengthValidator(tempList) == true)
                    {
                        Array = tempList.Array;
                        Count--;
                        return true;
                    }
                }

            }
            return false;
        }

        private bool LengthValidator(CustomList<T> arrayBuild)
        {
            if(arrayBuild.Count == (Count-1))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override string ToString()
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
