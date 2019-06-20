using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            // Concatenation example: dotnet run -- Alex (arugemnt)
            // Console.WriteLine("Hello " + args[0] + "!");
            if(args.Length > 0)
            {
                // interpolation example: dotnet run -- Alex (arugemnt)
                Console.WriteLine($"Hello, {args[0]}!");
            }
            else
            {
                Console.WriteLine("Hello");
            }
        }
    }
}
