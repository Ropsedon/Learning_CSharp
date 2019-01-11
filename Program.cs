using System;

// Просчет ферзя
//namespace Stepik
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int x1 = int.Parse(Console.ReadLine());
//            int y1 = int.Parse(Console.ReadLine());
//            int x2 = int.Parse(Console.ReadLine());
//            int y2 = int.Parse(Console.ReadLine());
//            if (x1 == x2 || y1 == y2 || Math.Abs(x1 - x2) == Math.Abs(y1 - y2)) 
//            {
//                Console.WriteLine("yes");
//            }
//            else
//            {
//                Console.WriteLine("no");
//            }
//        }
//    }
//}

// Просчет Коня
//namespace Stepik
//{
//    class Program
//    {
//        static void Main()
//        {
//            int x1 = int.Parse(Console.ReadLine());
//            int y1 = int.Parse(Console.ReadLine());
//            int x2 = int.Parse(Console.ReadLine());
//            int y2 = int.Parse(Console.ReadLine());
//            if ((x1 - 1 == x2 || x1 + 1 == x2) && (y1 - 2 == y2 || y1 + 2 == y2))
//            {
//                Console.WriteLine("yes");
//            }
//            else if ((x1 - 2 == x2 || x1 + 2 == x2) && (y1 - 1 == y2 || y1 + 1 == y2))
//            {
//                Console.WriteLine("yes");
//            }
//            else
//            {
//                Console.WriteLine("no");
//            }
//        }
//    }
//}

//Клетки одного цвета
//namespace Stepik
//{
//    class Program
//    {
//        static void Main()
//        {
//            int a = int.Parse(Console.ReadLine());
//            int b = int.Parse(Console.ReadLine());
//            int c = int.Parse(Console.ReadLine());
//            int d = int.Parse(Console.ReadLine());
//            if (((a + b) % 2 == 0) && ((c + d) % 2 == 0) || (((a + b) % 2 != 0) && ((c + d) % 2 != 0)))
//            {
//                Console.WriteLine("yes");
//            }
//            else
//            {
//                Console.WriteLine("no");
//            }
//        }
//    }
//}

//Прямоугольный лист бумаги разлинован на n×m клеточек. 
//Лист можно один раз разрезать по прямой вдоль линий на две части. 
//Определите, можно ли таким образом отрезать от листа ровно k целых клеток.
namespace Stepik
{
    class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if (((a * b) >= c) && (c % a == 0 || c % b == 0))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}