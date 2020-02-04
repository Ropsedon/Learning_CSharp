using System;
using System.Collections.Generic;

namespace PlayGround
{
    public class ListCreator
    {
        public ListCreator()
        {
            someList = new List<double>();
        }

        public void AddValue(double value)
        {
            someList.Add(value);
        }

        public void ShowStatistic()
        {
            var highValue = double.MinValue;
            var minValue = double.MaxValue;
            var everageValue = 0.0;

            foreach(double i in someList)
            {
                highValue = Math.Max(highValue, i);
                minValue = Math.Min(minValue, i);
                everageValue += i;
            }

            everageValue /= someList.Count;
            
            Console.WriteLine($"Highest value of List:{highValue}");
            Console.WriteLine($"Lowest value of List:{minValue}");
            Console.WriteLine($"Everage value of List:{everageValue:N1}");

        }

        List<double> someList;
        
    }
}