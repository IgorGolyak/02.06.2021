using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //11.17
            int n = 12;
            double[] mas = new double[n];
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                mas[i] = r.Next(1630, 1900)/10.0;
            }
            //Прямой выод массива
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(mas[i]);
            }

            Console.WriteLine();

            double a = Convert.ToDouble(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                mas[i] = mas[i]/a;
            }

            Console.WriteLine();

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
