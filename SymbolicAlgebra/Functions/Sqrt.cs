using SymbolicAlgebra.Functions;
using SymbolicAlgebra.Operators;
using System;
using System.Collections.Generic;
using System.Text;

namespace SymbolicAlgebra
{
    public class Sqrt : SimpleFunction
    {
        public Sqrt(Function arg) : base(arg) => F = new Func(Math.Sqrt);
        public override Function Derivative() => 1/(2*this);

    }
}
