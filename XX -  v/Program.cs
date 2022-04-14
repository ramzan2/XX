using System;

namespace XX____v
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[4] { 1, 2, 3, 4, };
            int a = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] /= a;
            }
            Console.WriteLine(string.Join("", numbers));
        }
    }
}
