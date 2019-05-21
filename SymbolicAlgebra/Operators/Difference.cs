using System;
using System.Collections.Generic;
using System.Text;
using SymbolicAlgebra.Functions;

namespace SymbolicAlgebra.Operators
{
    public class Difference : Operator
    {
        public Difference(Function a, Function b) : base(a, b)
        {
        }

        public override double Calc(double x) => left.Calc(x) - right.Calc(x);

        public override Function Derivative() => left.Derivative() + right.Derivative();

        public override string ToString() => left.ToString() + "-" + right.ToString();
    }
}
