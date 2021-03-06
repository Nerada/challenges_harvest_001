﻿// -----------------------------------------------
//     Author: Ramon Bollen
//      File: Countries.Program.cs
// Created on: 20201207
// -----------------------------------------------

using System;
using System.Text;
using Countries.Support;

namespace Countries
{
    internal static class Program
    {
        private static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.SetWindowSize(55, 50);

            var run = new Runnable();

            int[][] specificData = TestData.GetSpecificLayout();

            Console.WriteLine($"┌───────────────────┐");
            Console.WriteLine($"│ Predefined layout │");
            Console.WriteLine($"├{new string('─', 19)}┴─{new string('─', (specificData[0].Length * 2) - 19)}┐");
            Console.WriteLine($"{Environment.NewLine}Total amount of regions: {run.Solution(specificData)}");
            Console.WriteLine();

            int[][] randomData = TestData.GetRandomLayout();

            Console.WriteLine($"┌───────────────┐");
            Console.WriteLine($"│ Random layout │");
            Console.WriteLine($"├{new string('─', 15)}┴─{new string('─', (randomData[0].Length * 2) - 15)}┐");
            Console.WriteLine($"{Environment.NewLine}Total amount of regions: {run.Solution(randomData)}");
            Console.WriteLine();

            Console.ReadKey();

            Environment.Exit(0);
        }
    }
}