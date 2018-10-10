using System;
using System.Collections.Generic;
using System.Text;

namespace FibonacciSeriesAlgos.Args
{
    public class ArgsParser : IArgsParser
    {
        public ArgsResult ParseArgs(string[] args)
        {
            var result = new ArgsResult();

            if (args == null || args.Length == 0)
            {
                result.ParseFailedMessage = "No argument passed.";
                return result;
            }

            if (args.Length == 1)
            {
                var arg1 = args[0];

                var count = 0;
                if (int.TryParse(arg1, out count))
                {
                    result.IsParsedSuccessfully = true;
                    result.MaxIndex = count;
                    return result;
                }

                if (string.Equals(arg1.ToString(), "--help", StringComparison.OrdinalIgnoreCase))
                {
                    result.IsParsedSuccessfully = false;
                    result.ParseFailedMessage = "Help requested.";
                    return result;
                }
            }

            result.IsParsedSuccessfully = false;
            result.ParseFailedMessage = "Invalid argument passed. Please check the help.";
            return result;
        }

        public string GetHelpText()
        {
            return @"
Fibonacci Series Algo Compare - Recursive and Non-Recursive
===========================================================
Usage:
FibonacciSeriesAlgos.dll
--help  For help
<number> 

E.g. For help -> FibonacciSeriesAlgos.dll --help 
E.g. For count till 10 -> FibonacciSeriesAlgos.dll 10
            ";
        }
    }
}
