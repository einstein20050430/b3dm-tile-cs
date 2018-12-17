﻿using B3dm.Tile;
using System;
using System.IO;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "testfixtures/1311.b3dm";
            var memoryStream = new MemoryStream(File.ReadAllBytes(path));

            Console.WriteLine("B3dm tile sample application");
            Console.WriteLine($"Start parsing {path}...");
            var b3dm = B3dmParser.ParseB3dm(memoryStream);
            Console.WriteLine($"End parsing {path}.");

            File.WriteAllBytes("test.gltf", b3dm.GlbData);

            Console.WriteLine($"Press any key to continue...");
            Console.ReadKey();
        }
    }
}
