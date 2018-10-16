using FibonacciSeriesAlgos.Args;
using FibonacciSeriesAlgos.Calculator;
using FibonacciSeriesAlgos.Executor;
using System;

namespace FibonacciSeriesAlgos
{
    class Program
    {
        static int Main(string[] args)
        { 
            Console.WriteLine($"Starting fibonacci series calculation");

            // handle the args
            var argsParser = new ArgsParser();
            var argsResult = argsParser.ParseArgs(args);

            if (!argsResult.IsParsedSuccessfully || argsResult.MaxIndex <= 0)
            {
                if (!string.IsNullOrEmpty(argsResult.ParseFailedMessage))
                {
                    Console.WriteLine(argsResult.ParseFailedMessage);
                }

                Console.WriteLine(argsParser.GetHelpText());
                return 1;
            }

            var recursiveCalculator = new RecursiveFibobanacciCalculator();
            var nonRecursiveCalculator = new NonRecursiveFibobanacciCalculator();
            var executor = new CalculationExecutor(recursiveCalculator, nonRecursiveCalculator);

            //warm up the execution
            executor.Execute(1);
            executor.Execute(10);

            //execution - generate a comma separate data for further analysis
            WriteDataTableHeader("Index", "Recursive Result", "Recursive Time(ms)", "Recursive Time(ms) - Log", "Non-Recursive Result", "Non-Recursive Time (ms)");
            for (int i = 1; i < argsResult.MaxIndex; i++)
            {
                var result = executor.Execute(i);
                WriteDataTableRow(i, result.RecursiveFibonacciValue, result.RecursiveTimeInMilliseconds, result.NonRecursiveFibonacciValue, result.NonRecursiveTimeInMilliseconds);
            }

            Console.WriteLine("Press any key to terminate");
            Console.ReadLine();

            return 0;
        }

        private static void WriteDataTableHeader(string header1, string header2, string header3, string header4, string header5, string header6)
        {
            Console.WriteLine($"|{header1}|{header2}|{header3}|{header4}|{header5}|{header6}|");
            Console.WriteLine($"|-----------|-----------|-----------|-----------|-----------|-----------|");
        }

        private static void WriteDataTableRow(int index, long recursiveResult, double recursiveTime, long nonRecursiveResult, double nonRecursiveTime)
        {
            Console.WriteLine($"|{index}|{recursiveResult}|{recursiveTime}|{Math.Log10(recursiveTime)}|{nonRecursiveResult}|{nonRecursiveTime}|");
        }
    }
}
