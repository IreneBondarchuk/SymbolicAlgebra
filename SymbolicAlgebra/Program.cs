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

            Console.WriteLine("Integral of " + f1.ToString() + "(on [2, 5] delta = 0.5) = " +
                f1.Integrate(2, 5, 0.5).ToString() + "\n");
           Console.WriteLine("Derivative of " + f2.ToString() + " = " +
               f2.Derivative().ToString() + "\n");
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
