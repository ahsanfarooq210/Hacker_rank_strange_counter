using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hacker_rank_strange_counter
{
    class Program
    {
        static void Main(string[] args)
        {
            long t = long.Parse(Console.ReadLine());
            long n = 3;
            while (t > n)
            {
                t -= n;
                n *= 2;
            }
            Console.WriteLine(n - t + 1);
        }

    }
}
