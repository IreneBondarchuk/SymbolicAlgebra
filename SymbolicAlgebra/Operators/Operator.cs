using SymbolicAlgebra.Functions;


namespace SymbolicAlgebra.Operators
{
    public abstract class Operator: Function
    {
        protected Operator(Function a, Function b)
        {
            left = a;
            right = b;
        }
        protected readonly Function left;
        protected readonly Function right;
    }
}
