using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace Advanced_Concepts_3
{
    internal class Program
    {
        static void Main()
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();

            foreach (DriveInfo driveInfo in allDrives)
            {
                Console.WriteLine("Name: " + driveInfo.Name);
                Console.WriteLine("Drive Type: " + driveInfo.DriveType);

                //These will throw exceptions if the CDRom is empty
                if (driveInfo.DriveType != DriveType.CDRom)
                {
                    Console.WriteLine("Volume Label: " + driveInfo.VolumeLabel);
                    Console.WriteLine("Total Size: " + (driveInfo.TotalSize / 1024 / 1024 / 1024) + "GB");
                    Console.WriteLine("Available Free Space: " + (driveInfo.AvailableFreeSpace / 1024 / 1024 / 1024) + "GB");
                }

                Console.WriteLine("Root Directory: " + driveInfo.RootDirectory);
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
