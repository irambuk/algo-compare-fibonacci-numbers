using System;

namespace FibonacciSeriesAlgos.Calculator
{
    public class RecursiveFibobanacciCalculator : IFibobanacciCalculator
    {
        public long CalculateFibonacciNumber(int number)
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
            return CalculateFibonacciNumber(number-1) + CalculateFibonacciNumber(number - 2);
        }
    }
}
