using System.Text;
using System.Diagnostics;
using System.Threading;


namespace Task3
{

    internal class Program
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();
            long number = long.Parse(Console.ReadLine());
            for (long i = 1; i <= number; i++)
            {
                sb.Append(i);
                if (i < number) sb.Append(", ");
            }
            Console.WriteLine(sb.ToString());

            // The complexity of this code Amortized is O(n)
            // O(n) for the for loop and O(1) for appending in the stringBuilder
            // The space complexity is O(n) for storing the string in the StringBuilder
            // Also the stringBuilder may need O(n) time to resize and handle more characters
            // but it is amortized, so we consider it O(1) for each append

            // It's an array of characters that is used to build strings efficiently
            // It is mutable, meaning you can change its content without creating a new object
            // in contrast of normal strings which are immutable
            // And it's more efficient in appending than normal strings as it appends in O(1)
        }
    }
}