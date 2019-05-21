using System;
using System.Collections.Generic;
using System.Text;
using SymbolicAlgebra.Functions;

namespace SymbolicAlgebra.Operators
{
    public class Multiplication : Operator
    {
        public Multiplication(Function a, Function b) : base(a, b)
        {
        }

        public override double Calc(double x)
        {
            var a = left.Calc(x);
            if (Math.Abs(a) <= 10e-6)
                return a;
            var b = right.Calc(x);
            if (Math.Abs(b) <= 10e-6)
                return b;
            return a * b;
        }
        public override Function Derivative() => left.Derivative() * right + left * right.Derivative();

        public override string ToString()
        {
            string leftStr = "", rightStr = "";

            leftStr = !(left is Constant) ? "(" + left.ToString() + ")" : left.ToString();

            rightStr = !(right is Constant) ? "(" + right.ToString() + ")" : right.ToString();

            return leftStr + "*" + rightStr;
        }
    }
}
