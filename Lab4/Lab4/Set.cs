using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{
    class Set
    {
        int[] arr;
        int length;
        public bool error = false;
        public class Owner
        {
            int Id;
            public string name;
            string organisationName;
            public Owner(int Id, string name, string organisationName)
            {
                this.Id = Id;
                this.name = name;
                this.organisationName = organisationName;
            }
        }
        public class Date
        {
            public string CreationDate { get; private set; }
            public Date()
            {
                CreationDate = DateTime.Now.ToString();
            }
        }
        public Set(int size)
        {
            arr = new int[size];
            length = size;
        }
        public int this[int index]
        {
            get
            {
                if (index >= 0 && index < length)
                    return arr[index];
                else
                {
                    error = true;
                    return 0;
                }
            }
            set
            {
                if (index >= 0 && index < length)
                {
                    for (int i = 0; i < index; i++)
                        if (arr[i] == value)
                        {
                            error = true;
                            break;
                        }
                    if (!error)
                        arr[index] = value;
                }
                else
                    error = true;
            }
        }
        public void ShowInfo()
        {
            for (int i = 0; i < length; i++)
                Console.WriteLine(arr[i]);
            Console.WriteLine("\n");
        }
        public static bool operator >(int num, Set set)
        {
            for (int i = 0; i < set.length; i++)
                if (set[i] == num)
                    return true;
            return false;
        }
        public static bool operator <(int num, Set set)
        {
            for (int i = 0; i < set.length; i++)
                if (set[i] == num)
                    return false;
            return true;
        }
        public static Set operator *(Set set1, Set set2)
        {
            int count = 0;
            int[] arr = new int[10];
            for (int i = 0; i < set1.length; i++)
                if (set1[i] > set2)
                {
                    arr[count] = set1[i];
                    count++;
                }
            Array.Resize(ref arr, count);
            Set newSet = new Set(count);
            for (int i = 0; i < arr.Length; i++)
                newSet[i] = arr[i];
            return newSet;
        }
        public static bool operator <(Set set, Set bigSet)
        {
            bool flag = true;
            for (int i = 0; i < set.length; i++)
                if (!(set[i] > bigSet))
                    flag = false;
            return flag;
        }
        public static bool operator >(Set set, Set bigSet)
        {
            bool flag = true;
            for (int i = 0; i < set.length; i++)
                if (!(set[i] > bigSet))
                    flag = false;
            return !flag;
        }
        public static implicit operator Set(int[] arr)
        {
            Set set = new Set(arr.Length);
            for (int i = 0; i < arr.Length; i++)
                set[i] = arr[i];
            return set;
        }
        public static explicit operator int[](Set set)
        {
            int[] myArray = new int[set.length];
            for (int i = 0; i < set.length; i++)
                myArray[i] = set[i];
            return myArray;
        }
    }
}
