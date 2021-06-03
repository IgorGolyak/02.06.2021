using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 12;
            double[] mas = new double[n];
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                mas[i] = r.Next(16, 19) / 10.0;
            }
            //Прямой выод массива
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(mas[i]);
            }
            double p = 1;
            for(int i=0; i<n; i++)
            {
                p = p * mas[i];
            }
            Console.WriteLine("p=" + p);
            Console.ReadKey();
        }
    }
}
