using System.Text;
using System.Diagnostics;
using System.Threading;


namespace Task2
{

    internal class Program
    {
        static void Main()
        {
            string? input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Please enter a valid input.");
                return;
            }

            long n = long.Parse(input);

            // Validate input
            if (n <= 0)
            {
                Console.WriteLine("Please enter a positive integer.");
                return;
            }

            long sum = 0;

            // Formula approach
            Stopwatch stopwatch1 = Stopwatch.StartNew();

            sum = n * (n + 1) / 2;

            stopwatch1.Stop();

            double elapsedMilliseconds1 = stopwatch1.ElapsedMilliseconds;

            // Loop approach
            sum = 0;
            Stopwatch stopwatch2 = Stopwatch.StartNew();

            for (long i = 1; i <= n; i++)
                sum += i;

            stopwatch2.Stop();

            double elapsedMilliseconds2 = stopwatch2.ElapsedMilliseconds;

            // Output results
            Console.WriteLine($"Execution Time Formula (ms): {elapsedMilliseconds1}");
            Console.WriteLine($"Execution Time (ms) for loop: {elapsedMilliseconds2}");
        }
    }
}