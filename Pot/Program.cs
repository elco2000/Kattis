using System;

namespace Pot
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int Total = 0;

            for(int i = 0; i < n; i++)
            {
                int p = int.Parse(Console.ReadLine());
                Total += (int) Math.Pow(p / 10, p % 10);
            }

            Console.WriteLine(Total);
        }
    }
}
