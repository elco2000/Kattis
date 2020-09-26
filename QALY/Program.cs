using System;

namespace QALY
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double total = 0;

            for(int i = 0; i < n; i++)
            {
                string[] NLines = Console.ReadLine().Split(" ");
                total += double.Parse(NLines[0]) * double.Parse(NLines[1]);
            }

            Console.WriteLine(total);
        }
    }
}
