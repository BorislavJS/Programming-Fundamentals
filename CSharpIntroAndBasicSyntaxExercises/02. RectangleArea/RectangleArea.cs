﻿using System;


namespace _02.RectangleArea
{
class RectangleArea
{
    static void Main()
    {
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());

            var area = width * height;

            Console.WriteLine($"{area:F2}");
    }
}
}
