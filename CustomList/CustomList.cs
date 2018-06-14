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

        // 1. I might try to add a a test case or two where you would expect an exception to be 
        // thrown.An example of this would be create a new list<int> and then add 2 items to it.Then try to grab index 5.
        // It should throw an exception at this point because your array holds 5 items, but the last index of it would be list[4]. 
        // We would expect to see an exception thrown at that point - an out of range exception.


        //5. Add a minus -overload where nothing gets removed, and the indices are same.

        public CustomList()
        {
            capacity = 5;
            count = 0;
            holder = new T[Capacity];

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

            {
                Holder[count] = objectToAdd;
                Count++;
                CapacityCheck();
            }
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
        // BONUS - SORT METHOD
        // I used an insertion sort, mainly because I could uunderstand the algorithm. It uses a nested for loop where the outer
        // loop iterates over the entire array except the last index value. The inner loop starts at index 1 and compares that
        // index to the previous index. If the higher index value is greater, it stores the previous index value to a temporary
        // integer, reassisgns the previous index value to that of the current one, then reassigns the current index to teh
        // temp value. the inner looping index value (j) reduces by 1 and if it is not greater than 0, it goes back to the outer
        // loop. It does this so that the index values are continually reassigned as you progress through the outer loop. 
        public CustomList<int> Sort(CustomList<int> inputList)
        {
            for (int i = 0; i < inputList.Count - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (inputList.Holder[j - 1] > inputList.Holder[j])
                    {
                        int temp = inputList.Holder[j - 1];
                        inputList.Holder[j - 1] = inputList.Holder[j];
                        inputList.Holder[j] = temp;
                    }
                }
            }
            return inputList;
        }
    }
}
