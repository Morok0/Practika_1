using System;
namespace практика_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.Write("введите целое число: ");
            a = int.Parse(Console.ReadLine());
            if (a % 2 == 1)
            {
                Console.WriteLine("число нечетное");
            }
            else
            {
                Console.WriteLine("Число четное");
            }
            Console.ReadKey();
        }
    }
}
