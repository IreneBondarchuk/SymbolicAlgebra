using SymbolicAlgebra.Operators;


namespace SymbolicAlgebra.Functions
{
    public abstract partial class Function
    {
        public static Function operator +(Function a, Function b) => new Add(a, b);
        public static Function operator +(double a, Function b) => new Add(new Constant(a), b);
        public static Function operator +(Function b, double a) => new Add(b, new Constant(a));


        public static Function operator -(Function a, Function b) => new Difference(a, b);
        public static Function operator -(double a, Function b) => new Difference(new Constant(a), b);
        public static Function operator -(Function b, double a) => new Difference(b, new Constant(a));

        public static Function operator *(Function a, Function b) => new Multiplication(a, b);
        public static Function operator *(double a, Function b) => new Multiplication(new Constant(a), b);
        public static Function operator *(Function b, double a) => new Multiplication(b, new Constant(a));

        public static Function operator /(Function a, Function b) => new Division(a, b);
        public static Function operator /(double a, Function b) => new Division(new Constant(a), b);
        public static Function operator /(Function b, double a) => new Division(b, new Constant(a));

        public static Function operator ^(Function a, Function b) => new Power(a, b);
        public static Function operator ^(double a, Function b) => new Power(new Constant(a), b);
        public static Function operator ^(Function b, double a) => new Power(b, new Constant(a));
    }
}
