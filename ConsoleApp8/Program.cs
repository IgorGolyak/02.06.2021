using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            //11.36
            Console.WriteLine("Введите длину массива");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] mas = new int[n];
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                mas[i] = r.Next(50, 70);
                Console.WriteLine(mas[i]);
            }
            double m = 0;
            for(int i=0; i<n; i++)
            {
                m = m + Math.Pow(mas[i], 2);
            }
            Console.WriteLine(m);
            if (9999 < m && m < 1000000)
            {
                Console.WriteLine("Пятизначное");
            }
            else
            {
                Console.WriteLine("Не пятизначное");
            }
            Console.ReadLine();
        }
    }
}
