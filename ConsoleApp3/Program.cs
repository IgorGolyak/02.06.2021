using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //11.17(в)
            int n = 12;
            double[] mas = new double[n];
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
          
            for (int i = 0; i < n; i++)
            {
                mas[i] = mas[i] / 2;
            }
            Console.ReadKey();
        }
    }
}
