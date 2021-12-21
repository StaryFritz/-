using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace lab13
{
    class LMBDiskInfo
    {
        public static void showFreeSpace()
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            foreach (var disk in allDrives)
            {
                Console.WriteLine(disk.Name);
                Console.WriteLine(disk.TotalFreeSpace);
                LMBLog.Add("LMBDiskInfo", disk.Name, "определено свободное место на диске");
            }
        }
        public static void driveFileSystem()
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            foreach (var disk in allDrives)
            {
                Console.WriteLine(disk.Name);
                Console.WriteLine(disk.DriveFormat);
                LMBLog.Add("LMBDiskInfo", disk.Name, "определена файловая система");
            }
        }
        public static void driveInfo()
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            foreach (var disk in allDrives)
            {
                Console.WriteLine("Имя диска " + disk.Name);
                Console.WriteLine("Объем " + disk.TotalFreeSpace);
                Console.WriteLine("Доступный объем " + disk.AvailableFreeSpace);
                Console.WriteLine("Метка тома " + disk.VolumeLabel);
                LMBLog.Add("LMBDiskInfo", disk.Name, "Инфа про диск");
            }
        }
    }
}
