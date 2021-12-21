using System;

namespace lab13
{
    class Program
    {
        static void Main(string[] args)
        {
            LMBDiskInfo.showFreeSpace();
            LMBDiskInfo.driveFileSystem();
            LMBDiskInfo.driveInfo();

            LMBFileInfo.showFullPath("lmblogfile.txt");
            LMBFileInfo.showSizeAndEtc("lmblogfile.txt");
            LMBFileInfo.creationAndChanges("lmblogfile.txt");

            LMBDirInfo.fileCapacity(@"C:\Users\Михаил Лагуновский\Desktop\ООТП\lab13\lab13\bin\Debug\netcoreapp3.1");
            LMBDirInfo.creationInfo(@"C:\Users\Михаил Лагуновский\Desktop\ООТП\lab13\lab13\bin\Debug\netcoreapp3.1");
            LMBDirInfo.subDirCapacity(@"C:\Users\Михаил Лагуновский\Desktop\ООТП\lab13\lab13");
            LMBDirInfo.parentDir(@"C:\Users\Михаил Лагуновский\Desktop\ООТП\lab13\lab13");

            LMBFileManager.InspectDirectory(@"C:\Users\Михаил Лагуновский\Desktop\ООТП\lab13\lab13");
            LMBFileManager.CopyFiles(@"C:\Users\Михаил Лагуновский\Desktop\ООТП\lab13\lab13", ".txt");
        }
    }
}
