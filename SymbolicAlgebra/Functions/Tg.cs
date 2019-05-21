using SymbolicAlgebra.Operators;
using System;
using System.Collections.Generic;
using System.Text;

namespace SymbolicAlgebra.Functions
{
    public class Tg: SimpleFunction
    {
        public Tg(Function arg) : base(arg) => F = new Func(Math.Tan);
        public override Function Derivative() => 1/ (new Cos(Arg))^2;
    }
}
