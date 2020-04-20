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
            Name = name;
        }

        //Add value of collection
        public void AddGrades(double grade)
        {
            // If statement
            if(grade >= 0 && grade <= 100)
            {
                grades.Add(grade);
            }
            else
            {
                Console.WriteLine("Invalid value!");
            }
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
        public Statistics GetStatistic()
        {
            var result = new Statistics();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;

            foreach(var grade in grades)
            {
                result.Low = Math.Min(grade, result.Low);
                result.High = Math.Max(grade, result.High);
                result.Average += grade;
            }

            result.Average /= grades.Count;

            return result;
        }

     
    private List<double> grades;
    public string Name;

    }
}