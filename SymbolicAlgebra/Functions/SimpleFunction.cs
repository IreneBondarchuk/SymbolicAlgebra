using System;
using System.Collections.Generic;
using System.Text;

namespace SymbolicAlgebra.Functions
{
    public abstract class SimpleFunction : Function
    {
        protected Function Arg;
        protected delegate double Func(double x);
        protected Func F;
        public SimpleFunction(Function arg) => Arg = arg;
        public override double Calc(double x) => F(x);

        public override string ToString()
        {
            return this.GetType().Name.ToString() + "(" + Arg.ToString() + ")";
        }


    }
}
