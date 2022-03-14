using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MO_IndividualTask
{
    abstract class Search
    {
        public abstract void Min(double a, double b, double eps, double L_astr);
        public abstract void Max(double a, double b, double eps, double L_astr);
        public virtual double Func(double x)
        {
            return 12 * x - 2 * x * x;
        }
    }
}
