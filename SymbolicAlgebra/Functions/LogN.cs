using SymbolicAlgebra.Operators;
using System;
using System.Collections.Generic;
using System.Text;

namespace SymbolicAlgebra.Functions
{
    public class LogN : SimpleFunction
    {
        public LogN(Function arg) : base(arg) => F = new Func(Math.Log);
        public override Function Derivative() => (1 / Arg);


    }
}
