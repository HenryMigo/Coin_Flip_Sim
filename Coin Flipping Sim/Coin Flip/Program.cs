using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coin_Flip
{
    class Program
    {
        static void Main(string[] args)
        {
            Flip();
            Console.ReadLine();
        }

        static void Flip()
        {
            int timesFlipped;
            Console.WriteLine("How many times do you want to flip the coin?");
            timesFlipped = Int32.Parse(Console.ReadLine());
            int n;
            int heads = 0;
            int tails = 0;
           
            for (int v = 0; v <= timesFlipped; v++)
            {
                Random r = new Random();
                n = r.Next(0, 2);
                if (n == 1)
                {
                    heads++;
                }
                else
                {
                    tails++;
                }
            }
            Console.Clear();
            Console.WriteLine("There were {0} heads and {1} tails. ", heads, tails);
        }
    }
}
