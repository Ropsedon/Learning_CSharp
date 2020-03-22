using System;
using System.Collections.Generic;

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
            book.Statistic();
        }
    }
}
