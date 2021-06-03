using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            //11.36(в)
            Console.WriteLine("Введите длину массива");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] mas = new int[n];
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                mas[i] = r.Next(70, 140);
                Console.WriteLine(mas[i]);
            }
            Console.WriteLine("Числа меньше 100");
            for (int i = 0; i < n; i++)
            {
                if (mas[i] < 100)
                {
                    Console.WriteLine(mas[i]);
                }
            }
            Console.ReadKey();
        }
    }
}
