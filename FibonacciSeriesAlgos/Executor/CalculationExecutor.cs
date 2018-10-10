using FibonacciSeriesAlgos.Calculator;
using System;

namespace FibonacciSeriesAlgos.Executor
{
    public class CalculationExecutor : ICalculationExecutor
    {
        private readonly IFibobanacciCalculator _recursiveCalculator;
        private readonly IFibobanacciCalculator _nonRecursiveCalculator;
        
        public CalculationExecutor(IFibobanacciCalculator recursiveCalculator, IFibobanacciCalculator nonRecursiveCalculator)
        {
            _recursiveCalculator = recursiveCalculator;
            _nonRecursiveCalculator = nonRecursiveCalculator;
        }

        public FibonacciResult Execute(int index)
        {
            var result = new FibonacciResult
            {
                Index = index
            };

            try
            {
                var now1 = DateTime.Now;
                var recursiveResult = _recursiveCalculator.CalculateFibonacciNumber(index);
                var now2 = DateTime.Now;
                var recursiveTimeDiff = now2.Subtract(now1).TotalMilliseconds;

                result.RecursiveFibonacciValue = recursiveResult;
                result.RecursiveTimeInMilliseconds = recursiveTimeDiff;
            }
            catch (Exception)
            {
                result.RecursiveFibonacciValue = -1;
                result.RecursiveTimeInMilliseconds = -1;
            }

            try
            {
                var now3 = DateTime.Now;
                var nonRecursiveResult = _nonRecursiveCalculator.CalculateFibonacciNumber(index);
                var now4 = DateTime.Now;
                var nonRecursiveTimeDiff = now4.Subtract(now3).TotalMilliseconds;

                result.NonRecursiveFibonacciValue = nonRecursiveResult;
                result.NonRecursiveTimeInMilliseconds = nonRecursiveTimeDiff;
            }
            catch (Exception)
            {
                result.RecursiveFibonacciValue = -1;
                result.RecursiveTimeInMilliseconds = -1;
            }         

            return result;
        }
    }
}
