using System;
using System.Collections.Generic;
using System.Text;

namespace SymbolicAlgebra.Functions
{
    public class Sin: SimpleFunction
    {
        public Sin(Function arg) : base(arg) => F = Math.Sin;

        public override Function Derivative() => new Cos(Arg);
    }
}
