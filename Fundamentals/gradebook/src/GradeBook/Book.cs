using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        public Book()
        {
            grades = new List<double>();
        }
        
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public void ShowStatistics()
        {
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;
            var averageGrade = 0.0;

            foreach(var number in grades)
            {
                lowGrade = Math.Min(number, lowGrade);
                highGrade = Math.Max(number, highGrade);
                averageGrade += number;
            }

            averageGrade /= grades.Count;
            Console.WriteLine($"The lowest grade is: {lowGrade}");
            Console.WriteLine($"The highest grade is: {highGrade}");
            Console.WriteLine($"The average grade is: {averageGrade:N1}");
        }

        private List<double> grades;
    }
}