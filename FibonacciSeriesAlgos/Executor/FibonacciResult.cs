using System;
using System.Collections.Generic;
using System.Text;

namespace FibonacciSeriesAlgos.Executor
{
    public class FibonacciResult
    {
        public int Index { get; set; }

        public long RecursiveFibonacciValue { get; set; }

        public double RecursiveTimeInMilliseconds { get; set; }

        public long NonRecursiveFibonacciValue { get; set; }

        public double NonRecursiveTimeInMilliseconds { get; set; }
    }
}
