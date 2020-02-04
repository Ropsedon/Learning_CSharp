using System;
using System.Collections.Generic;

namespace PluralSite
{
    public class BasicClass
    {
        
        public void FirstMessage(string message)
        {
            System.Console.WriteLine("First Message:");
            System.Console.WriteLine("Hello " + message);
        }

        public void SecondMessage(string message)
        {
            System.Console.WriteLine("Second Message:");
            System.Console.WriteLine($"Hello {message}!");
        }

        int i = 0;


        public void SetValue(int values)
        {
            i = values;
        }

        public void ExampleArray()
        {
            var example = new[] { 1.1, 1.2, 1.3, 1.4, 1.5 };
            var result = 0.0;

            foreach(var j in example)
            {
                result += j;
            }

            System.Console.WriteLine($"Example of array: {result}");
        }

        public void ExampleList()
        {
            List<double> somelist = new List<double> { 1.1, 1.2, 1.3, 1.4, 1.5 };
            var result_list = 0.0;
            var average_result = 0.0;

            foreach(var l in somelist)
            {
                result_list += l;    
            }
            
            average_result = result_list / somelist.Count;

            System.Console.WriteLine($"Example of list: {result_list}");
            System.Console.WriteLine($"Everage of list: {average_result:N1}");

        }

        public void PrintValue()
        {
            System.Console.WriteLine(i);
        }
    }
}