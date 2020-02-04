using System;

namespace PlayGround
{
    public class ArrayCreator
    {
        public ArrayCreator()
        {
            someArray = new int[3];
        }

        public void AddValueArray(int position, int valueArray)
        {
            someArray.SetValue(position, valueArray);
        }

        public void ShowStatistic()
        {
            foreach(int values in someArray)
            {
                Console.WriteLine(values);
            }
        }
        int[] someArray;
    }
}