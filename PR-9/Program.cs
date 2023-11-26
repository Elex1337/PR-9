using System;
using PR_9;
class Program
{
    static void Main()
    {
        Storage[] devices = new Storage[]
        {
            new Flash("Flash Drive", "Kingston", 150, 64),
            new DVD("DVD Drive", "Sony", 16, false),
            new HDD("External HDD", "Seagate", 120, 2, 500)
        };

        double totalMemory = 0;
        foreach (var device in devices)
        {
            totalMemory += device.GetMemory();
        }
        Console.WriteLine($"Total Memory: {totalMemory} GB");

        double dataSize = 565; 
        foreach (var device in devices)
        {
            device.CopyData(dataSize);
        }

        double copyTime = 0;
        foreach (var device in devices)
        {
            copyTime += dataSize / device.GetMemory() * 60; // Предположим, что копирование занимает 1 минуту на 1 GB
        }
        Console.WriteLine($"Time needed for copying: {copyTime} minutes");

        double filesSize = 780; // Размер файлов в MB
        int flashCount = (int)Math.Ceiling(dataSize / devices[0].GetMemory());
        int dvdCount = (int)Math.Ceiling(dataSize / devices[1].GetMemory());
        int hddCount = (int)Math.Ceiling(dataSize / devices[2].GetMemory());

        Console.WriteLine($"Number of Flash Drives needed: {flashCount}");
        Console.WriteLine($"Number of DVDs needed: {dvdCount}");
        Console.WriteLine($"Number of External HDDs needed: {hddCount}");
    }
}