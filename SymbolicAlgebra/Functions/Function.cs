using SymbolicAlgebra.Operators;
using System;
using System.Collections.Generic;
using System.Text;

namespace SymbolicAlgebra.Functions
{
    public abstract partial class Function
    {
        public abstract double Calc(double x);
        public abstract Function Derivative();

        protected string name;

       
    }
}
