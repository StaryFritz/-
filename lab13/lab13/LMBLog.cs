using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace lab13
{
    class LMBLog
    {
        public static void Add(string className, string path, string message)
        {
            using (StreamWriter sw = new StreamWriter("lmblogfile.txt", true))
            {
                sw.WriteLine($"{ className}: {path}");
                sw.WriteLine(message);
                sw.WriteLine(DateTime.Now);
            }
        }
    }
}
