using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList 
{
    public class CustomList<T> : IEnumerable
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

        // Method for overloading + operator
        // Method for overLoading - operator
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
            StringBuilder Builder = new StringBuilder();
            for(int i=0; i<Count-1; i++)
            {
                Builder.Append(Array[i]).Append(", ");
            }
            for(int i=Count-1; i<Count;i++)
            {
                Builder.Append(Array[i]);
            }
            return Builder.ToString();

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
        public IEnumerator GetEnumerator()
        {
            for(int i=0; i<Count; i++)
            {
                yield return Array[i];
            }
        }
    }
}
