using System;
using System.Collections.Generic;
using System.Text;

namespace SymbolicAlgebra.Functions
{
    public class Exp: SimpleFunction
    {
        public Exp(Function arg) : base(arg) =>F = new Func(Math.Exp);
        public override Function Derivative() => this;
    }
}
