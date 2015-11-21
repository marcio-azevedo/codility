using System;
using Code.Katas.Codility.Lessons;
using Serilog;

namespace Code.Katas.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var log = new LoggerConfiguration()
                          .WriteTo.ColoredConsole()
                          .CreateLogger();

            try
            {
                // https://github.com/serilog/serilog/wiki/Getting-Started
                //log.Information("Starting log...");

                var array = new int[] { 3, 1, 2, 4, 3 };
                var result = TimeComplexity.solutionTapeEquilibrium(array);

                log.Information($"Result:{result}.");
                Console.ReadLine();
            }
            catch (Exception exception)
            {
                log.Fatal(exception, "Fatal error");
            }
        }
    }
}
