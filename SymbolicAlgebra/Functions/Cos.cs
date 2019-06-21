using System;
using System.Collections.Generic;
using System.Text;

namespace SymbolicAlgebra.Functions
{
    public class Cos:SimpleFunction
    {
        public Cos(Function arg) : base(arg) =>F = new Func(Math.Cos);

        public override Function Derivative() => (-1) * new Sin(Arg);

    }
}
