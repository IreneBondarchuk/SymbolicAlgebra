using System;
using System.Collections.Generic;
using System.Text;
using SymbolicAlgebra.Functions;

namespace SymbolicAlgebra.Operators
{
    public class Power : Operator
    {
        public Power(Function a, Function b) : base(a, b) {}
        public override double Calc(double x) => Math.Pow(left.Calc(x), right.Calc(x));
        public override Function Derivative() => throw new NotImplementedException();
        public override string ToString() => "(" + left.ToString() + ")^("+right.ToString()+")";

    }
}
