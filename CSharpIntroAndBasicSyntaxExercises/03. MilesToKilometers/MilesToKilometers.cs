using System;


namespace _03.MilesToKilometers
{
class MilesToKilometers
{
        static void Main()
        {
            var miles = double.Parse(Console.ReadLine());

            var kilometers = miles * 1.60934;

            Console.WriteLine($"{kilometers:F2}");
        }
}
}
