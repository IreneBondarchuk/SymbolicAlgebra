using System;
using System.Collections.Generic;
using System.Text;
using SymbolicAlgebra.Functions;

namespace SymbolicAlgebra.Operators
{
    public class Division : Operator
    {
        public Division(Function a, Function b) : base(a, b)
        {
        }

        public override string ToString()
        {
            string leftStr = "", rightStr = "";

            leftStr = !(left is Constant) ? "(" + left.ToString() + ")" : left.ToString();

            rightStr = !(right is Constant) ? "(" + right.ToString() + ")" : right.ToString();

            return leftStr + "/" + rightStr;
        }
         
        public override double Calc(double x)
        {
            var a = left;
            var b = right;
            if (b is Constant && Math.Abs((b.Calc(0)) - 1) <= 10e-6)
                return a.Calc(x);
            if (a is Constant && Math.Abs((a.Calc(0))) <= 10e-6)
                return 0;
            if (b is Constant && Math.Abs((b.Calc(0))) <= 10e-6)
                throw new DivideByZeroException("Function b cannot be zero constant");

            if (b is Constant)
                return (1 / b.Calc(0)) * a.Calc(x);

            return a.Calc(x) / b.Calc(x);
        }

        public override Function Derivative() => (left.Derivative()*right - left*right.Derivative())
                                                 /(right ^ new Constant(2)) ;
    } 
}
