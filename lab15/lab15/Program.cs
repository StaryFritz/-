using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;

namespace lab15
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1
            var allProcesses = Process.GetProcesses();
            using (var sw = new StreamWriter("process.txt"))
                foreach (var process in allProcesses)
                    sw.WriteLine($"{process.Id} {process.ProcessName} {process.BasePriority}");

            // 2
            var current = AppDomain.CurrentDomain;
            Console.WriteLine($"{current.FriendlyName} {current.SetupInformation}");
            current.GetAssemblies().ToList().ForEach(x => Console.WriteLine($"{x.FullName}"));

            //AppDomain domain = AppDomain.CreateDomain("MyDomain");
            //domain.Load(Assembly.GetExecutingAssembly().FullName);
            //AppDomain.Unload(domain);

            // 3

            void count(object ob)
            {
                int num = (int)ob;
                for (int i = 1; i < num; i++)
                {
                    Console.WriteLine(i);
                    Thread.Sleep(1000);
                }
            }

            Thread secondThread = new Thread(new ParameterizedThreadStart(count));
            secondThread.Name = "countThread";
            secondThread.Start(7);
            //secondThread.Suspend();

            Console.WriteLine($"{secondThread.ThreadState}");
            Console.WriteLine($"{secondThread.Name}");
            Console.WriteLine($"{secondThread.Priority}");
            Console.WriteLine($"{secondThread.ManagedThreadId}");

            //secondThread.Resume();
            Console.WriteLine();

            OddAndEven.ByOne();
            Thread.Sleep(1000);
            Console.WriteLine();
            OddAndEven.Together();
            Thread.Sleep(1000);
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.Green;

            TimerCallback timerCallback = new TimerCallback(CurrentTime);
            Timer timer = new Timer(timerCallback, null, 0, 1000);
            Thread.Sleep(5000);
            void CurrentTime(object obj)
            {
                Console.WriteLine(DateTime.Now);
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
