using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            //11.46(а)
            Console.WriteLine("Введите длину массива");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] mas = new int[n];
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                mas[i] = r.Next(-140, 140);
                Console.WriteLine(mas[i]);
            }
            Console.WriteLine("Массив после модификации");
            for (int i = 0; i < n; i++)
            {
                if (mas[i] < 0)
                {
                    mas[i] = Math.Abs(mas[i]);
                }
                Console.WriteLine(mas[i]);
            }
            Console.ReadKey();
        }
    }
}
