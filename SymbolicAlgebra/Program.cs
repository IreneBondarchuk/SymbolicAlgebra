using SymbolicAlgebra.Functions;
using System;

namespace SymbolicAlgebra
{
    class Program
    {
        static void Main(string[] args)
        {
            Function f1 = new Sqrt(new Cos(new X()));
            
            Function f2 = new Tg(new X()) + new Cos(2*new X());
            
            Console.WriteLine(f1.Derivative().ToString() + "\n");
            Console.WriteLine(f2.Derivative().ToString() + "\n");
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
