using System;

namespace Home.Work.__3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  4 eded verilib (a,b,c,d). 
             * 1) bu ededlerin ilk ikisini cemleyib, 
             * 2) son ikisinin hasilini tapmaq.  
             * 3) sonda ise cemi hasile bolmek.
             */

            int a = 33;
            int b = 223;
            int c = 42;
            int d = 4;

            int e = a + b;

            { Console.WriteLine(e); }

            int q1 = e % 2;

            if (q1 == 0)

            { Console.WriteLine("Cutdur"); }

            else

            { Console.WriteLine("Tekdir"); }

            int f = c * d;

            { Console.WriteLine(f); }

            int q2 = e % 2;

            if (q2 == 0)

            { Console.WriteLine("Cutdur"); }

            else

            { Console.WriteLine("Tekdir"); }

            int g = e / f;

            { Console.WriteLine(g); }

            int q3 = e % 2;

            if (q3 == 0)

            { Console.WriteLine("Cutdur"); }

            else

            { Console.WriteLine("Tekdir"); }

            int h = e % f;

            { Console.WriteLine(h); }

            int q4 = e % 2;

            if (q4 == 0)

            { Console.WriteLine("Cutdur"); }

            else

            { Console.WriteLine("Tekdir"); }
        }
    }
}
