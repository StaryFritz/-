using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Lab4
{
    static class StatisticOperation
    {
        public static int Sum(Set set)
        {
            int sum = 0;
            int[] arr = (int[])set;
            for (int i = 0; i < arr.Length; i++)
                sum += arr[i];
            return sum;
        }
        public static int MinMaxDiff(Set set)
        {
            int[] arr = (int[])set;
            int max = arr.Max();
            int min = arr.Min();
            return max - min;
        }
        public static int SetLength(Set set)
        {
            int[] arr = (int[])set;
            return arr.Length;
        }
        public static char FirstDigit(this string myString)
        {
            char[] strArr = new char[10] {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9'};
            for (int i = 0; i < myString.Length; i++)
                for (int j = 0; j < strArr.Length; j++)
                    if (myString[i] == strArr[j])
                        return strArr[j];
            return '0';
        }
        public static int[] RemovePositives(this Set set)
        {
            int[] arr = new int[10];
            int count = 0;
            for (int i = 0; i < 10; i++)
            {
                if (set[i] < 0)
                {
                    arr[i] = set[i];
                    count++;
                }
                else
                    continue;
            }
            Array.Resize(ref arr, count);
            return arr;
        }
    }
}
