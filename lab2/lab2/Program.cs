using System;
using System.Text;
using System.Linq;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            //sbyte byte1;
            //short sh;
            //int a;
            //long b;
            //byte byte2;
            //ushort ush;
            //uint ua;
            //ulong ub;
            //char ch;
            //float fl;
            //double dbl;
            //decimal dec;
            //bool bl;
            //byte1 = Convert.ToSByte(Console.ReadLine());
            //sh = Convert.ToInt16(Console.ReadLine());
            //a = Convert.ToInt32(Console.ReadLine());
            //b = Convert.ToInt64(Console.ReadLine());
            //byte2 = Convert.ToByte(Console.ReadLine());
            //ush = Convert.ToUInt16(Console.ReadLine());
            //ua = Convert.ToUInt32(Console.ReadLine());
            //ub = Convert.ToUInt64(Console.ReadLine());
            //ch = Convert.ToChar(Console.ReadLine());
            //fl = Convert.ToSingle(Console.ReadLine());
            //dbl = Convert.ToDouble(Console.ReadLine());
            //dec = Convert.ToDecimal(Console.ReadLine());
            //bl = Convert.ToBoolean(Console.ReadLine());
            //Console.WriteLine($"sbyte = {byte1}\n short = {sh}\n int = {a}\n long = {b}\n byte = {byte2}\n ushort = {ush}\n" +
            //    $"uint = {ua}\n ulong = {ub}\n char = {ch}\n float = {fl}\n double = {dbl}\n decimal = {dec}\n bool = {bl}");

            // Неявное преобразование

            //int a = 4;
            //float b = a;

            //byte c = 6;
            //ushort d = c;

            //sbyte e = 2;
            //short f = e;

            //int g = 7;
            //float h = a + g;

            //float k = 2.5f;
            //double p = k;

            //// Явное преобразование

            //float a1 = 4.2f;
            //int b1 = (int)a1;

            //ushort c1 = 6;
            //byte d1 = (byte)c1;

            //short e1 = 2;
            //sbyte f1 = (sbyte)e1;

            //float g1 = 7;
            //int h1 = (int)(a1 + g1);

            //double i1 = 2.5;
            //float j1 = (float)i1;

            //// Упаковка и распаковка

            //int box = 1;
            //object obj = box;
            //int unbox = (int)obj;

            //// Var

            //var t = "Hello World!";
            ////t = 1;

            //// Nullable

            //Nullable<int> x1 = 324;
            //Console.WriteLine(x1.HasValue + "\n" + x1.Value);

            //// Строки

            //string s1 = "String";
            //string s2 = "difference";
            //int result = String.Compare(s1, s2);
            //if (result < 0)
            //{
            //    Console.WriteLine("Строка s1 перед строкой s2");
            //}
            //else if (result > 0)
            //{
            //    Console.WriteLine("Строка s1 стоит после строки s2");
            //}
            //else
            //{
            //    Console.WriteLine("Строки s1 и s2 идентичны");
            //}
            //string s3 = s1 + " " + s2;
            //Console.WriteLine(s3);
            //string s4 = String.Concat(s3, "!!!");
            //Console.WriteLine(s4);
            //string[] strs = new String[] { s1, s2 };
            //String s5 = String.Join(" ", strs);
            //Console.WriteLine(s5);
            //string s6 = String.Copy(s5);
            //string s7 = (string)s5.Clone();
            //Console.WriteLine(s5 + " " + s7);
            //string[] subs = s5.Split(' ');
            //foreach (var sub in subs)
            //{
            //    Console.WriteLine($"Substring: {sub}");
            //}
            //string text = "Хороший день";
            //string subString = "замечательный ";

            //text = text.Insert(8, subString);
            //Console.WriteLine(text);
            //string text1 = "Хороший день";
            //// индекс последнего символа
            //int ind = text1.Length - 1;
            //// вырезаем последний символ
            //text1 = text1.Remove(ind);
            //Console.WriteLine(text1);
            //// вырезаем первые два символа
            //text1 = text1.Remove(0, 2);
            //Console.WriteLine(text1);
            //int x = 8;
            //int y = 7;
            //string res = $"{x} + {y} = {x + y}";
            //Console.WriteLine(res); // 8 + 7 = 15

            //string s8 = "";
            //string s9 = null;
            //Console.WriteLine(String.IsNullOrEmpty(s8));
            //Console.WriteLine(String.IsNullOrEmpty(s9));

            //StringBuilder sb = new StringBuilder("Привет мир");
            //sb.Append("!");
            //sb.Insert(7, "компьютерный ");
            //Console.WriteLine(sb);
            //sb.Remove(7, 13);
            //Console.WriteLine(sb);

            ////  Массивы

            //int[,] mas = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 10, 11, 12 } };

            //int rows = mas.GetUpperBound(0) + 1;
            //int columns = mas.Length / rows;
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < columns; j++)
            //    {
            //        Console.Write($"{mas[i, j]} \t");
            //    }
            //    Console.WriteLine();
            //}

            //string[] strarr = { "красный", "желтый", "зеленый", "синий" };

            //Console.WriteLine("Введите позицию, которую хотите изменить");
            //int position = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Введите новое слово");
            //strarr[position] = Console.ReadLine();
            //Console.WriteLine();
            //for (int i = 0; i < 4; i++)
            //{
            //    Console.WriteLine(strarr[i]);
            //}
            //Console.WriteLine(strarr.Length);

            //int[][] arr = new int[3][];
            //arr[0] = new int[2];
            //arr[1] = new int[3];
            //arr[2] = new int[4];

            //for (var i = 0; i < arr.Length; i++)
            //{
            //    for (var j = 0; j < arr[i].Length; j++) arr[i][j] = int.Parse(Console.ReadLine());
            //    Console.WriteLine();
            //}

            //for (var i = 0; i < arr.Length; i++)
            //{
            //    for (var j = 0; j < arr[i].Length; j++) Console.Write($"{arr[i][j]} ");
            //    Console.WriteLine();
            //}

            //var arrayVar = new[] { 1, 2, 3, 4 };
            //var stringVar = "absc";

            //   Кортежи

            (int, string, char, string, ulong) MyTuple = (7, "Hello", 'a', "World", 3);
            (int, string, char, string, ulong) MySecondTuple = (3, "Hello", 'a', "World", 3);
            Console.WriteLine(MyTuple);
            Console.WriteLine(MyTuple.Item1);
            Console.WriteLine(MyTuple.Item3);
            Console.WriteLine(MyTuple.Item4);
            int intVar = MyTuple.Item1;
            string firstStringVar = MyTuple.Item2;
            char charVar = MyTuple.Item3;
            string secondStringVar = MyTuple.Item4;
            ulong ulongVar = MyTuple.Item5;
            Console.WriteLine(MyTuple == MySecondTuple);
            int[] arr = new int[] { 2, 3, 1 };
            string str = "some string";
            Console.WriteLine(LocalFunction(arr, str));
            UnheckedFunction();
        }
        private static (int, int, int, char) LocalFunction (int[] arr, string str)
        {
            int maxValue = arr.Max();
            int minValue = arr.Min();
            int sum = arr.Sum();
            char firstChar = str[0];
            return (maxValue, minValue, sum, firstChar);
        }
        private static void CheckedFunction()
        {
            checked
            {
                int num = Int32.MaxValue;
                num++;
                Console.WriteLine(num);
            }
        }
        private static void UnheckedFunction()
        {
            unchecked
            {
                int num = Int32.MaxValue;
                num++;
                Console.WriteLine(num);
            }
        }
    }
}
