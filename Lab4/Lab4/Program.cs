using System;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            int i;
            Set A = new Set(n);
            for (i = 0; i < n; i++)
            {
                A[i] = i; // 0, 1, 2, 3, 4
            }
            Set B = new Set(n);
            for (i = 0; i < n; i++)
            {
                B[i] = i + 3; // 3, 4, 5, 6, 7
            }
            Set C = A * B; // 3, 4
            C.ShowInfo();
            Console.WriteLine(4 > A);
            Console.WriteLine(C < B);
            int[] array = new int[3] { 1, 2, 3 };
            Set D = array;
            D.ShowInfo();
            int[] myArray = (int[])A;
            foreach (var myArrayElement in myArray)
                Console.WriteLine(myArrayElement);
            Set.Owner misha = new Set.Owner(1, "Mikhail", "KT");
            Set.Date date = new Set.Date();
            Console.WriteLine(date.CreationDate);
            Console.WriteLine(StatisticOperation.Sum(A));
            Console.WriteLine(StatisticOperation.MinMaxDiff(B));
            Console.WriteLine(StatisticOperation.SetLength(C));
            string someString = "csgo69420";
            Console.WriteLine(someString.FirstDigit());
            Set E = new Set(n);
            for (i = 0; i < n; i++)
            {
                E[i] = i - 2; // -2, -1, 0, 1, 2
            }
            E = E.RemovePositives();
            E.ShowInfo();
        }
    }
}
