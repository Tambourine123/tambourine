 using System;
class Question3
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string userInput = Console.ReadLine();

        char[] charArray = userInput.ToCharArray();
        for (int i = 0; i < charArray.Length; i++)
        {
            charArray[i] = char.ToUpper(charArray[i]);
        }

        string result = new string(charArray);
        Console.WriteLine("Uppercase string: " + result);
    }
}
