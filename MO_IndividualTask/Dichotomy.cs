using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MO_IndividualTask
{
    internal class Dichotomy : Search
	{
        public override void Min(double a, double b, double eps, double L_astr)
        {
            double x1, x2;

			while (Math.Abs(a - b) > L_astr)
			{

				x1 = a + (b - a) / 2 - eps / 2;
				x2 = a + (b - a) / 2 + eps / 2;

				if (Func(x1) < Func(x2))
				{
					b = x2;
				}

				if (Func(x1) > Func(x2))
				{
					a = x1;
				}

				Console.WriteLine("Fmin = F(" + (x1 + x2) / 2 + ") = " + Func((x1 + x2) / 2));
			}
		}

		public override void Max(double a, double b, double eps, double L_astr)
        {
			double x1, x2;

			while (Math.Abs(a - b) > L_astr)
			{

				x1 = a + (b - a) / 2 - eps / 2;
				x2 = a + (b - a) / 2 + eps / 2;

				if (Func(x1) < Func(x2))
				{
					a = x1;
				}

				if (Func(x1) > Func(x2))
				{
					b = x2;
				}

				Console.WriteLine("Fmax = F(" + (x1 + x2) / 2 + ") = " + Func((x1 + x2) / 2));
			}
		}
	}
}
