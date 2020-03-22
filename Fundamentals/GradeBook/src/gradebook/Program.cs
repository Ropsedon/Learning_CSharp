using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        
            //Array collections
            var arrayExample = new double[] { 11.5, 12.6, 14.7, 18.9 };

            foreach (var item in arrayExample)
            {
                System.Console.WriteLine(item);
            }

            //List collections
            var listExample = new List<double>() { 19.9, 20.2, 30.2, 40.2, 50.2 };

            foreach (var item2 in listExample)
            {
                System.Console.WriteLine(item2);
            }
        }
    }
}
