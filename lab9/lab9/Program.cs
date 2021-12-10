using System;

namespace lab9
{
    class Program
    {

        static void Main(string[] args)
        {
            Boss myLaptop = new Boss();
            myLaptop.OnUpgrade += Boss.DisplayMessage;
            myLaptop.doUpgrade("Windows 11");
            myLaptop.doTurnOn();

            Func<string, string> A;
            var str = "abc   ,. de f,,,, GH";
            Console.WriteLine($"\n\n\nString: {str}");

            A = StringEditor.RemovePunctuation;
            str = A(str);
            Console.WriteLine($"{A.Method.Name}: {A(str)}");


            A = StringEditor.ToUpper;
            str = A(str);
            Console.WriteLine($"{A.Method.Name}: {str}");

            A = StringEditor.ToLower;
            str = A(str);
            Console.WriteLine($"{A.Method.Name}: {str}");

            A = StringEditor.RemoveSpace;
            str = A(str);
            Console.WriteLine($"{A.Method.Name}: {str}");

            A = StringEditor.AddExclamationMark;
            str = A(str);
            Console.WriteLine($"{A.Method.Name}: {str}");

            Console.WriteLine(str);
        }
    }
}
