using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace DZ21
{
    class Program
    {
        const int n = 6;
        static int[,] pach = new int[n, n] { { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 } };
        static void Main(string[] args)
        {
            ThreadStart threadStart = new ThreadStart(Garden1);
            Thread thread = new Thread(threadStart);
            thread.Start();

            Garden2();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0,2}", pach[i, j]);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
        static void Garden1()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (pach[i, j] < 1)
                    {
                        pach[i, j] = 1;
                        Thread.Sleep(5);
                    }
                }
            }
        }
        static void Garden2()
        {
            for (int j = n-1; j >= 0; j--)
            {
                for (int i = n - 1; i >= 0; i--)
                {
                    if (pach[i, j] < 1)
                    {
                        pach[i, j] = 2;
                        Thread.Sleep(5);
                    }
                }
            }
        }
    }
}
