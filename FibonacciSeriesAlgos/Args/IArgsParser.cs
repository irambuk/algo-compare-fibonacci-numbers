using System;
using System.Collections.Generic;
using System.Text;

namespace FibonacciSeriesAlgos.Args
{
    public interface IArgsParser
    {
        ArgsResult ParseArgs(string[] args);

        string GetHelpText();
    }
}
