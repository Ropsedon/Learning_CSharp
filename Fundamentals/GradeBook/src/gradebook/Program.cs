using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Alex's Grades");
            book.AddGrades(89.99);
            book.AddGrades(92.12);
            book.AddGrades(99.99);
            book.GetStatistic();

            var stat = book.GetStatistic();
            Console.WriteLine($"The lowest grade is: {stat.Low}");
            Console.WriteLine($"The average grade is: {stat.Average:N2}");
            Console.WriteLine($"The highest grade is: {stat.High}");
        }
    }
}
