using System;

namespace XX__b
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[4] { 1, 2, 3, 4, };
            int b = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] -= b;
            }
            Console.WriteLine(string.Join("", numbers));
        }
    }
}
