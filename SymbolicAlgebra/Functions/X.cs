using System;
using System.Collections.Generic;
using System.Text;

namespace SymbolicAlgebra.Functions
{
    public class X : Function
    {
        public override double Calc(double val) => val;
        public override Function Derivative() => new Constant(1);
    }
}
