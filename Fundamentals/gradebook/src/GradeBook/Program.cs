using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length > 0)
            {
                //Concatenation of string
                Console.WriteLine("Hello " + args[0] + "!");
                //Interpolation
                Console.WriteLine($"Hello, {args[0]}!");
            }
            else 
            {
                Console.WriteLine("Hello!");
            }

            //Basic type of numb. variables
            int a = 12;
            double b = 10.2;
            var c = 40.2;
            var result = a + b + c;
            System.Console.WriteLine($"Result: {result}");

            //Array
            //First way to (standard) create array and add values;
            var simple_array = new int[2];
            simple_array[0] = 10;
            simple_array[1] = 11;
            int result_simple_array = simple_array[0] + simple_array[1];
            System.Console.WriteLine("The sum of values simple array: " + result_simple_array);

            //Second way to create array and add values;
            var complex_array = new int[2] {10, 11};
            int result_complex_array = complex_array[0] + complex_array[1];
            System.Console.WriteLine($"The sum of values complex array: {result_complex_array}");

            //Third way to create array without limit:
            var unlimited = new double[] { 11.1, 12.2, 13.3, 14.4, 15.5 };
            double unlimited_array = unlimited[0] + unlimited[1] + unlimited[2] + unlimited[3] + unlimited[4];
            System.Console.WriteLine($"The sum of values unlimited array: {unlimited_array}");

            //Fourth way to create array without type:
            var untype = new[] { 11.1, 12.2, 13.3, 14.4, 15.5 };
            var untype_array = untype[0] + untype[1] + untype[2] + untype[3] + untype[4];
            System.Console.WriteLine($"The sum of values unlimited array: {untype_array}");

            //Foreach
            foreach(double number in untype)
            {
                System.Console.WriteLine($"Values from array: {number}");
            }

            //Foreach sum of values in loop
            double result_loop = 0.0;
            foreach(double number in unlimited)
            {
                result_loop += number;
            }
            System.Console.WriteLine($"Result of sum in loop: {result_loop}");

            //List
            //First way to create list and add values;
            var simple_list = new List<double>();
            simple_list.Add(66.1);
            System.Console.WriteLine($"First element in the list {simple_list[0]}");

            //Second way to create list and add values;
            var complex_list = new List<double>() { 11.1, 12.2, 13.3, 14.4, 15.5, 16.6 };
            var result_list = 0.0;
            foreach(double number in complex_list)
            {
                result_list += number;
                System.Console.WriteLine($"Values from list: {number}");
            }
            System.Console.WriteLine($"The sum of values from list: {result_list}");
            var avarage_value = result_list / complex_list.Count;
            System.Console.WriteLine($"The average value of list: {avarage_value}");
            System.Console.WriteLine($"The average value of list: {avarage_value:N1}");
            System.Console.WriteLine($"The average value of list: {avarage_value:N2}");
            System.Console.WriteLine($"The average value of list: {avarage_value:N3}");

            //Use another class in one space
            var book = new Book();
            book.AddGrade(99.1);

        }
    }
}
