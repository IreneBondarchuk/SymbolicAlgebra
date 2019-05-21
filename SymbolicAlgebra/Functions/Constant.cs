using System;
using System.Collections.Generic;
using System.Text;

namespace SymbolicAlgebra.Functions
{
    public class Constant : Function
    {
        public double Value { get; private set; }
        public Constant(double val) => Value = val;
        public override double Calc(double val = 0) => Value;
        public override Function Derivative() => new Constant(0);
        public override string ToString() => Value.ToString();

    }
}
