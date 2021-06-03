using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //11.14
            int n = 12;
            int[] mas = new int[n];
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                mas[i] = r.Next(163, 190);
            }

            //Прямой выод массива
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(mas[i]);
            }

            Console.WriteLine();

          
            //Обратный вывод массива
            for(int i=n-1; i>=0; i--)
            {
               Console.WriteLine(mas[i]);
            }

            Console.ReadKey();
        }
    }
}
