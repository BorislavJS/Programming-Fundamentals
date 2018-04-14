using System;


namespace _05.CharacterStats
{
    class CharacterStats
    {
        static void Main()
        {
            string name = Console.ReadLine();
            int healt = int.Parse(Console.ReadLine());
            int healtMax = int.Parse(Console.ReadLine());
            int energy = int.Parse(Console.ReadLine());
            int energyMax = int.Parse(Console.ReadLine());


            Console.WriteLine($"Name: {name}\nHealth: |{repeadString("|", healt)}" +
                $"{repeadString(".", healtMax - healt)}|");

            Console.WriteLine($"Energy: |{ repeadString("|", energy)}" +
                $"{ repeadString(".", energyMax - energy)}|");

        }

        public static String repeadString(string simbol, int b)
        {
            string text = "";

            for (int i = 0; i < b; i++)
            {
                text += simbol;
            }
            return text;
        }
    }
}
