using System;

namespace Planina
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int s = 2;

            int g = 1;

            for (int i = 0; i < n; i++)
            {
                s += g;
                g += g;
            }

            Console.WriteLine(s*s);
        }
    }
}
