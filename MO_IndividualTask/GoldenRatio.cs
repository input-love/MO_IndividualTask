using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MO_IndividualTask
{
    internal class GoldenRatio : Search
    {
        public override void Min(double a, double b, double eps, double L_astr)
        {
            const double FI = 1.618;
            double x1 = b - (b - a) / FI;
            double x2 = a + (b - a) / FI;

            while (Math.Abs(b - a) > eps)
            {
                if (Func(x1) >= Func(x2))
                {
                    a = x1;
                    x1 = x2;
                    x2 = b - (x1 - a);
                }
                else
                {
                    b = x2;
                    x2 = x1;
                    x1 = a + (b - x2);
                }

                Console.WriteLine("Fmin = F(" + (x1 + x2) / 2 + ") = " + Func((x1 + x2) / 2));
            }
        }

        public override void Max(double a, double b, double eps, double L_astr)
        {
            const double FI = 1.618;
            double x1 = b - (b - a) / FI;
            double x2 = a + (b - a) / FI;

            while (Math.Abs(b - a) > eps)
            {
                if (Func(x1) <= Func(x2))
                {
                    a = x1;
                    x1 = x2;
                    x2 = b - (x1 - a);
                }
                else
                {
                    b = x2;
                    x2 = x1;
                    x1 = a + (b - x2);
                }

                Console.WriteLine("Fmax = F(" + (x1 + x2) / 2 + ") = " + Func((x1 + x2) / 2));
            }
        }
    }
}
