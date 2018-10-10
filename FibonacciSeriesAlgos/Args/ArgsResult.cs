using System;
using System.Collections.Generic;
using System.Text;

namespace FibonacciSeriesAlgos.Args
{
    public class ArgsResult
    {
        public bool IsParsedSuccessfully { get; set; }

        public string ParseFailedMessage { get; set; }

        public int MaxIndex { get; set; }
    }
}
