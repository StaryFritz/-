using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace lab13
{
    class LMBFileInfo
    {
        public static void showFullPath(string path)
        {
            FileInfo file = new FileInfo(path);
            if (file.Exists)
                Console.WriteLine("Полный путь " + file.FullName);
            LMBLog.Add("LMBDiskInfo", file.Name, "Полный путь файла");
        }
        public static void showSizeAndEtc(string path)
        {
            FileInfo file = new FileInfo(path);
            if (file.Exists)
            {
                Console.WriteLine("Размер файла " + file.Length);
                Console.WriteLine("Расширение файла " + file.Extension);
                Console.WriteLine("Имя файла " + file.Name);
            }
            LMBLog.Add("LMBDiskInfo", file.Name, "Размер, расширение и имя файла");
        }
        public static void creationAndChanges(string path)
        {
            FileInfo file = new FileInfo(path);
            if (file.Exists)
            {
                Console.WriteLine("Дата создания " + file.CreationTime);
                Console.WriteLine("Дата изменения " + file.LastWriteTime);
            }
            LMBLog.Add("LMBDiskInfo", file.Name, "Даты создания и изменения");
        }
    }
}
