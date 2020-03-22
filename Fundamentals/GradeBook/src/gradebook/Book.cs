using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {  
        //Constructor of the class
        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }

        //Add value of collection
        public void AddGrades(double grade)
        {
            grades.Add(grade);
        }

        //Remove value of collection
        public void RemoveGrade(double grade)
        {
            if(grades.Contains(grade))
            {
                grades.Remove(grade);
            }
            else
            {
                Console.WriteLine("Wrong value of grade!");
            }
        }

        //Statistic of the collection
        public void Statistic()
        {
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;
            var everageGrade = 0.0;

            foreach(var number in grades)
            {
                lowGrade = Math.Min(number, lowGrade);
                highGrade = Math.Max(number, highGrade);
                everageGrade += number;
            }

            everageGrade /= grades.Count;

            Console.WriteLine($"The lowest grade is: {lowGrade}");
            Console.WriteLine($"The average grade is: {everageGrade:N2}");
            Console.WriteLine($"The highest grade is: {highGrade}");
        }

     
    private List<double> grades;
    private string name;

    }
}