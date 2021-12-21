using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace lab13
{
    class LMBDirInfo
    {
        public static void fileCapacity(string name)
        {
            DirectoryInfo dir = new DirectoryInfo(name);
            if (dir.Exists)
            {
                Console.WriteLine("Количество файлов " + dir.GetFiles().Length);
            }
            LMBLog.Add("LMBDiskInfo", dir.Name, "Количество файлов в директории");
        }
        public static void creationInfo(string name)
        {
            DirectoryInfo dir = new DirectoryInfo(name);
            if (dir.Exists)
            {
                Console.WriteLine("Дата создания " + dir.CreationTime);
            }
            LMBLog.Add("LMBDiskInfo", dir.Name, "Дата создания директории");
        }
        public static void subDirCapacity(string name)
        {
            DirectoryInfo dir = new DirectoryInfo(name);
            if (dir.Exists)
            {
                Console.WriteLine("Количество подкаталогов " + dir.GetDirectories().Length);
            }
            LMBLog.Add("LMBDiskInfo", dir.Name, "Количество подкаталогов");
        }
        public static void parentDir(string name)
        {
            DirectoryInfo dir = new DirectoryInfo(name);
            if (dir.Exists)
            {
                Console.WriteLine("Родительская директория " + dir.Parent);
            }
            LMBLog.Add("LMBDiskInfo", dir.Name, "Родительская директория");
        }
    }
}
