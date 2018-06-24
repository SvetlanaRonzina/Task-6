using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a1, a2, a3, N, E, colEl = 0;
            // List<Tuple<int, int>> list = new List<Tuple<int, int>>();
          //  List<int> num = new List<int>();
            List<int> El = new List<int>();
            Console.WriteLine("введите число а1");
            while (!int.TryParse(Console.ReadLine(), out a1))
                Console.WriteLine("Введите целое число");
            Console.WriteLine("введите число а2");
            while (!int.TryParse(Console.ReadLine(), out a2))
                Console.WriteLine("Введите целое число");
            Console.WriteLine("введите число а3");
            while (!int.TryParse(Console.ReadLine(), out a3))
                Console.WriteLine("Введите целое число");
            Console.WriteLine("Сколько пар элементов найти?");
            while (!int.TryParse(Console.ReadLine(), out N) || (N < 1))
                Console.WriteLine("Введите целое положительное число");
            Console.WriteLine("введите число E");
            while (!int.TryParse(Console.ReadLine(), out E))
                Console.WriteLine("Введите целое число");
            El.Add(a1);
            El.Add(a2);
            El.Add(a3);
            Console.WriteLine("Последовательность:");
            Console.WriteLine(a1);
            Console.WriteLine(a2);
            Console.WriteLine(a3);
            if (Math.Abs(a2 - a1) > E)
                colEl++;

            Recurs(a1, a2, a3, N, E, colEl, El);
            Console.WriteLine("Пары элементов, удовлетворяющих условию:");
            Show(El, E);
            Console.ReadLine();
        }
        public static void Recurs(int a1, int a2, int a3, int N, int E, int colEl, List<int> El)
        {

            if (Math.Abs(a3 - a2) > E)
            {
                colEl++;
            }

            if (!(colEl == N))
            {
                int a4 = a3 + 2 * a2 * a1;
                El.Add(a4);
                Console.WriteLine(a4);
                Recurs(a2, a3, a4, N, E, colEl, El);
            }
           
        }
        public static void Show(List <int> El,int E)
        {
            for (int i = 1; i < El.Count; i++)
                if (Math.Abs(El[i] - El[i - 1]) > E)
                    Console.WriteLine(El[i - 1] + " и " + El[i] + " Их номера:   "+ i + " и " + (i + 1));
        }
    }
}
