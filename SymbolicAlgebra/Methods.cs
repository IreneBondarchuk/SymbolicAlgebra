using SymbolicAlgebra.Functions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SymbolicAlgebra
{
    public static class Methods
    {
        public static double Integrate(this Function f, double a, double b, double delta)
        {
            if (Math.Sign(delta) != Math.Sign(b - a))
                delta *= -1;
            double sum = 0;
            int i = 0;
            for (double x = a; x < b; x += delta)
            {
                if (x + delta > b)
                {
                    sum += (b - x) * f.Calc(x);
                    break;
                }
                sum += delta * f.Calc(x);
                ++i;
            }
            return Math.Round(sum, 2);
        }
    }
}
