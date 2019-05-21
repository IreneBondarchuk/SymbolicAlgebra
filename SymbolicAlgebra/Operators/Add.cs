using System;
using System.Collections.Generic;
using System.Text;
using SymbolicAlgebra.Functions;

namespace SymbolicAlgebra.Operators
{
    public class Add : Operator
    {
        public Add(Function a, Function b) : base(a, b){}
        public override double Calc(double val) => left.Calc(val) + right.Calc(val);

        public override Function Derivative() => left.Derivative() + right.Derivative();
        public override string ToString() => left.ToString() + "+" + right.ToString();
    }
}
