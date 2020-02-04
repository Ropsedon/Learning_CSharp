using System;
using System.Collections.Generic;

namespace PlayGround
{
    class Program
    {
        static void Main(string[] args)
        {
            // string[] somestring = new string[3];
            // somestring[0] = "Hello";
            // somestring[1] = "World";
            // somestring[2] = "Array";

            // foreach(string first_string in somestring)
            // {
            //     System.Console.WriteLine(first_string);
            // }


            // int[] somekind = new[] {1, 2, 3, 4, 5};
            
            // foreach(int first_number in somekind)
            // {
            //     System.Console.WriteLine(first_number);
            // }

            // var test = new double[] { 1, 2, 3, 4, 5.1 };
            // var result = 0.0;

            // foreach(double test_number in test)
            // {
            //     result += test_number;
            // }

            // System.Console.WriteLine($"Result: {result}");

            // var simple_array = new[] {1.2, 1.3, 2.5};

            // foreach(var number in simple_array)
            // {
            //     System.Console.WriteLine(number);
            // }

            // //Lists
            // List<double> firs_list = new List<double>();
            // firs_list.Add(1.86);
            // firs_list.Add(2.4);
            // System.Console.WriteLine("Created first list");
            // foreach(double check_value in firs_list)
            // {
            //     System.Console.WriteLine(check_value);
            // }

            // var second_list = new List<string>() {"First value", "Second value"};

            // foreach(string check_string in second_list)
            // {
            //     System.Console.WriteLine(check_string);
            // }

            var someTest = new ListCreator();

            someTest.AddValue(99.1);
            someTest.AddValue(99.9);
            someTest.AddValue(99.8);

            someTest.ShowStatistic();

            var someTest2 = new ArrayCreator();

            someTest2.AddValueArray(1, 100);
            someTest2.AddValueArray(2, 200);
            someTest2.AddValueArray(3, 300);

            someTest2.ShowStatistic();


        }
    }
}
