using System;
class Question5
{
    static void Main()
    {
        float[] alpha = new float[50];
        for (int i = 0; i < 25; i++)
        {
            alpha[i] = i * i;
        }
        for (int i = 25; i < 50; i++)
        {
            alpha[i] = 3 * i;
        }
        Console.WriteLine("Array alpha:");
        for (int i = 0; i < alpha.Length; i++)
        {
            Console.Write($"{alpha[i],-10}"); 
            if ((i + 1) % 10 == 0)
            {
                Console.WriteLine();
            }
        }
    }
}
