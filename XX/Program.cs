using System;

namespace XX
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int [4] { 1, 2, 3, 4,};
            for (int i = 0; i < numbers.Length; i++) 
            {
                numbers[i] *= 2;
            }
            Console.WriteLine(string.Join("", numbers));
            //int b = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    numbers[i] -= b;
            //}
            //Console.WriteLine(string.Join("", numbers));

        }
    }
}
