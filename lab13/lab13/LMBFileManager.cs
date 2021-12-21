using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.IO.Compression;

namespace lab13
{
    class LMBFileManager
    {
        public static void InspectDirectory(string path)
        {
            DirectoryInfo directory = new DirectoryInfo(path);
            File.Create(@"C:\Users\Михаил Лагуновский\Desktop\ООТП\lab13\lab13\LMBInspect\LMBDirInfo.txt").Close();

            using (StreamWriter sw = new StreamWriter(@"C:\Users\Михаил Лагуновский\Desktop\ООТП\lab13\lab13\LMBInspect\LMBDirInfo.txt"))
            {
                sw.WriteLine("|Директории|");
                foreach (DirectoryInfo dir in directory.GetDirectories())
                    sw.WriteLine(dir.Name);

                sw.WriteLine();

                sw.WriteLine("|Файлы|");
                foreach (FileInfo file in directory.GetFiles())
                    sw.WriteLine(file.Name);
            }

            File.Copy(@"C:\Users\Михаил Лагуновский\Desktop\ООТП\lab13\lab13\LMBInspect\LMBDirInfo.txt", @"C:\Users\Михаил Лагуновский\Desktop\ООТП\lab13\lab13\LMBInspect\LMBDirInfoRenamed.txt", true);
            File.Delete(@"C:\Users\Михаил Лагуновский\Desktop\ООТП\lab13\lab13\LMBInspect\LMBDirInfo.txt");
        }

        public static void CopyFiles(string path, string extension)
        {
            DirectoryInfo directory = new DirectoryInfo(path);
            Directory.CreateDirectory(@"C:\Users\Михаил Лагуновский\Desktop\ООТП\lab13\lab13\LMBFiles");

            foreach (FileInfo file in directory.GetFiles())
            {
                if (file.Extension == extension)
                    file.CopyTo($@"C:\Users\Михаил Лагуновский\Desktop\ООТП\lab13\lab13\LMBFiles\{file.Name}", true);
            }
            Directory.Move(@"C:\Users\Михаил Лагуновский\Desktop\ООТП\lab13\lab13\LMBFiles\", @"C:\Users\Михаил Лагуновский\Desktop\ООТП\lab13\lab13\LMBInspect\LMBFiles\");
            Directory.Delete(@"C:\Users\Михаил Лагуновский\Desktop\ООТП\lab13\lab13\LMBInspect\LMBFiles\", true);
        }
    }
}
