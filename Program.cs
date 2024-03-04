using System;
class Question1
{
    public static void Main()
    {
          Console.WriteLine("Enter three numbers:");

        Console.Write("Enter the first number: ");
        int number1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int number2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the third number: ");
        int number3 = Convert.ToInt32(Console.ReadLine());

        int[] numbers = { number1, number2, number3 };
        Array.Sort(numbers);

        Console.WriteLine("Numbers in ascending order: {1}, {2}, {3}",numbers[0], numbers[1], numbers[2]);
        
    }
}