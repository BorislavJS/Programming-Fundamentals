using System;

namespace _02._AddTwoNumbers
{
class AddTwoNumbers
{
    static void Main()
    {
        var firstNumber = int.Parse(Console.ReadLine());
        var secondNumber = int.Parse(Console.ReadLine());

        var sum = firstNumber + secondNumber;

        Console.WriteLine($"{firstNumber} + {secondNumber} = {sum}");
    }
}
}
