﻿using Delegates_Multicast.Services;
using System;


namespace Delegates_Multicast
{
    delegate void BinaryNumericOperation(double n1, double n2);
    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            BinaryNumericOperation op = CalculationService.ShowMax;
            op += CalculationService.ShowSum;

            op(a, b);
        }
    }
}
