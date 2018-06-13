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

        // Make Array Resize method
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
                Holder = ArrayResize(Holder, holder.Length, Capacity);
            }
        }

        private static T[] ArrayResize(T[] startingArray, int elementLength, int size)
        {
            T[] resizedArray = new T[size];
            for(int i = 0; i < elementLength; i++)
            {
                    resizedArray[i] = startingArray[i];
            }
            return resizedArray;
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
        public static CustomList<T> operator+ (CustomList<T> listA, CustomList<T> listB)
        {
            CustomList<T> listBuilder = new CustomList<T>();
            for (int i = 0; i < listA.Count; i++)
            {
                listBuilder.Add(listA.Holder[i]);
            }
            for (int j = 0; j < listB.Count; j++)
            {
                listBuilder.Add(listB.Holder[j]);
            }
            return listBuilder;

        }
        public static CustomList<T> operator- (CustomList<T> listFrom, CustomList<T> minusList)
        {
            CustomList<T> returnList = new CustomList<T>();
            CustomListCopier(listFrom, returnList);
            CustomList<T> reducedCapacityList = new CustomList<T>();
            reducedCapacityList = CustomListCapacityShrink(minusList);
            for (int i = 0; i <listFrom.Count; i++)
            {
                if (reducedCapacityList.Holder.Contains(listFrom[i]))
                {
                    returnList.Remove(listFrom[i]);
                    reducedCapacityList.Remove(listFrom[i]);
                    reducedCapacityList = CustomListCapacityShrink(reducedCapacityList);
                }
            }
            return returnList;
        }
        public static CustomList<T> CustomListCapacityShrink(CustomList<T> listToShrink)
        {
            CustomList<T> resizedList = new CustomList<T>();
            CustomListCopier(listToShrink, resizedList);
            resizedList.Capacity = resizedList.Count;
            resizedList.Holder = ArrayResize(resizedList.Holder, resizedList.Count, resizedList.Count);
            return resizedList;
        }
        private static void CustomListCopier(CustomList<T> listFrom, CustomList<T> returnList)
        {
            for(int i=0; i <listFrom.Count; i++)
            {
                returnList.Add(listFrom[i]);
            }
        }

        public CustomList<T> Zip(CustomList<T> listA, CustomList<T> listB)
        {
            CustomList<T> zippedList = new CustomList<T>();
            int zipLength = GetSmallerCount(listA, listB);
            for(int i =0; i<zipLength; i++)
            {
                zippedList.Add(listA[i]);
                zippedList.Add(listB[i]);

            }
            return zippedList;

        }

        private int GetSmallerCount(CustomList<T> listA, CustomList<T> listB)
        {
            if(listA.Count <= listB.Count)
            {
                return listA.Count;
            }
            else
            {
                return listB.Count;
            }
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
