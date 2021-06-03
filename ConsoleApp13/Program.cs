using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            //11.46(б)
            Console.WriteLine("Введите длину массива");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] mas = new int[n];
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                mas[i] = r.Next(1, 140);
                Console.WriteLine(mas[i]);
            }
            Console.WriteLine("После модификации");
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    mas[i] = Math.Sqrt(mas[i]);
                }
                Console.WriteLine(mas[i]);
            }
            Console.ReadKey();
        }
    }
}
