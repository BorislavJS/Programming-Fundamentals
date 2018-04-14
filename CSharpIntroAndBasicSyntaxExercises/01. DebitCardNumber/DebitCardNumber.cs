using System;


namespace _01.DebitCardNumber
{
class DebitCardNumber
{
    static void Main()
    {
            var numberOne = int.Parse(Console.ReadLine());
            var numberTwo = int.Parse(Console.ReadLine());
            var numberThree = int.Parse(Console.ReadLine());
            var numberFour = int.Parse(Console.ReadLine());

            Console.WriteLine($"{numberOne:D4} {numberTwo:D4} {numberThree:D4} {numberFour:D4}");
    }
}
}
