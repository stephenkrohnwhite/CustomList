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
        private T[] holder;
        private int capacity;
        private int count;
        public T[] Holder
        {
            get
            {
                return holder;
            }
            set
            {
                holder = value;
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

        // Method for overLoading - operator
        // Method for Zip

        public CustomList()
        {
            Capacity = 5;
            Count = 0;
            Holder = new T[Capacity];

        }
        public T this[int i]
        {
            get
            {
                return Holder[i];
            }
            set
            {
                Holder[i] = value;
            }
        }
       public void CapacityCheck()
        {
            if (Count > (Capacity - 2))
            {
                Capacity = Capacity += 5;
                Array.Resize(ref holder, Capacity);
            }
        }
        public void Add(T objectToAdd)
        {
            Holder[count] = objectToAdd;
            Count++;
            CapacityCheck();
        }
        public bool Remove(T objectToRemove)
        {
            CustomList<T> tempList = new CustomList<T>();
            for(int i=0; i<Count; i++)
            {
                if(!Holder[i].Equals(objectToRemove))
                {
                    tempList.Add(Holder[i]);
                }
                else if(Holder[i].Equals(objectToRemove))
                {
                    for(int j = i+1; j<Count; j++)
                    {
                        tempList.Add(Holder[j]);
                    }
                    if(LengthValidator(tempList) == true)
                    {
                        Holder = tempList.Holder;
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
                Builder.Append(Holder[i]).Append(", ");
            }
            for(int i=Count-1; i<Count;i++)
            {
                Builder.Append(Holder[i]);
            }
            return Builder.ToString();

        }
        public static CustomList<T> operator+ (CustomList<T> ListA, CustomList<T> ListB)
        {
            CustomList<T> ListBuilder = new CustomList<T>();
            for (int i = 0; i < ListA.Count; i++)
            {
                ListBuilder.Add(ListA.Holder[i]);
            }
            for (int j = 0; j < ListB.Count; j++)
            {
                ListBuilder.Add(ListB.Holder[j]);
            }
            return ListBuilder;

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
                yield return Holder[i];
            }
        }
    }
}
