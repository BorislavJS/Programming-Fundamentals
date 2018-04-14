using System;


namespace _04.BeverageLabels
{
    class BeverageLabels
    {
        static void Main()
        {
            var name = Console.ReadLine();
            var volume = int.Parse(Console.ReadLine());
            var energyContentPer100 = int.Parse(Console.ReadLine());
            var sugarContentPer100 = int.Parse(Console.ReadLine());

            double energyTotal = (double)(energyContentPer100) * volume / 100;
            double sugarTotal = (double)(sugarContentPer100) * volume / 100;
			
            Console.WriteLine($"{volume}ml {name}:\r\n{energyTotal}kcal, {sugarTotal}g sugars");

        }
    }
}
