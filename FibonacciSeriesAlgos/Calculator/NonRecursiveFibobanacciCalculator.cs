using System;

namespace FibonacciSeriesAlgos.Calculator
{
    public class NonRecursiveFibobanacciCalculator : IFibobanacciCalculator
    {
        public long CalculateFibonacciSeries(int number)
        {
            if (number < 0)
            {
                throw new NotSupportedException($"Invalid input {number} given");
            }
            if (number == 0)
            {
                return 0;
            }
            if (number == 1)
            {
                return 1;
            }
            long fibonnaciNMinus1 = 0;
            long fibonnaciNMinus2 = 1;
            for (int i = 2; i <= number; i++)
            {
                var temp = fibonnaciNMinus1 + fibonnaciNMinus2;
                fibonnaciNMinus2 = fibonnaciNMinus1;
                fibonnaciNMinus1 = temp;
            }
            return fibonnaciNMinus2 + fibonnaciNMinus1;
        }
    }
}
