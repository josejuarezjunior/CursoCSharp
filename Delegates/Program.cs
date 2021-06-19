using System;
using System.Collections.Generic;
using System.Linq;
using Delegates.Services;

namespace Delegates
{
    /*
     * Esse é um delegate que é uma referência para uma função com dois valores
     * double, que retorna um valor double
     * Para o exemplo em questão, esse delegate funciona com as funções SUM e MAX,
     * porém não funciona com a função SQUARE, pois a mesma possui apenas um
     * argumento double.
    */
    delegate double BinaryNumericOperation(double n1, double n2);
    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;
            // BinaryNumericOperation op = CalculationService.Sum;
            BinaryNumericOperation op = CalculationService.Sum;
            // double result = op(a, b);
            double result = op.Invoke(a, b);
            Console.WriteLine(result);
        }
    }
}
