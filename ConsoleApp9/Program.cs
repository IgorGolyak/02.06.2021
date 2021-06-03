using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            //11.36(а)
            Console.WriteLine("Введите длину массива");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] mas = new int[n];
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                mas[i] = r.Next(-50, 50);
                Console.WriteLine(mas[i]);
            }
            Console.WriteLine("Неотрицательное число");
            for(int i = 0; i < n; i++)
            {
                if (mas[i] > 0)
                {
                    Console.WriteLine(mas[i]);
                }
            }
            Console.ReadKey();
        }
    }
}
