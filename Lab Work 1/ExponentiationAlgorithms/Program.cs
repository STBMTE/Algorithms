using System;
using System.Diagnostics;

namespace ExponentiationAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());
            ExponentiationAlgorithm EA = new ExponentiationAlgorithm(x, n);
        }
    }

    class ExponentiationAlgorithm
    {
        public ExponentiationAlgorithm(int x, int n)
        {
            var sw = new Stopwatch();

            sw.Start();

            int a = Pow(x, n);

            sw.Stop();

            Console.WriteLine($"PowAlg - {sw.ElapsedTicks}");
            
            sw.Restart();

            int b = RecPow(x, n);
            
            sw.Stop();

            Console.WriteLine($"RecPowAlg - {sw.ElapsedTicks}");


            sw.Restart(); 
            
            int c = QuickPow(x, n);
            sw.Stop();
            
            Console.WriteLine($"QuickPowAlg - {sw.ElapsedTicks}");
            
            sw.Restart();

            int d = ClassicQuickPow(x, n);
            sw.Stop();

            Console.WriteLine($"ClassicQuickPowAlg - {sw.Elapsed.Ticks}");
        }

        private int Pow(int x, int n)
        {
            int result = 1;
            for(int i  = 0; i < n; i++)
            {
                result *= x;
            }
            return result;
        }
        
        private int RecPow(int x, int n)
        {
            int f;
            if(n == 0)
            {
                f = 1;
            }
            else
            {
                f = RecPow(x, n / 2);
                if(n % 2 == 1)
                {
                    f = f * f * x;
                }
                else
                {
                    f = f * f;
                }
            }
            return f;
        }

        private int QuickPow(int x, int n)
        {
            int c = x;
            int k = n;
            int f;
            if(k % 2 == 1)
            {
                f = c;
            }
            else
            {
                f = 1;
            }
            while(k != 0)
            {
                k = k / 2;
                c = c * c;
                if(k % 2 == 1)
                {
                    f = f * c;
                }
            }
            return f;
        }

        private int ClassicQuickPow(int x, int n)
        {
            int c = x;
            int f = 1;
            int k = n;
            while( k != 0)
            {
                if (k % 2 == 0)
                {
                    c = c * c;
                    k = k / 2;
                }
                else
                {
                    f = f * c;
                    k = k - 1;
                }
            }
            return f;
        }
    }
}
