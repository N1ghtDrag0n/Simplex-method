using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplex_method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в программу для решения задач симплекс методом");

            double[] NB = new double[3];
            double[] CB= new double[3];
            double[] Bm = new double[3];
            double[] Cn = new double[6];
            double[] Dn = new double[6];
            double F=0;
            double[,] Am = new double[3, 6];

            Console.Clear();

            Console.WriteLine("Введите свободные члены");
            for(int i = 0; i <= 2; i++)
            {
                Console.WriteLine($"Введите {i+1}-й свободный член");
                Bm[i] = double.Parse(Console.ReadLine());               
            }

            Console.Clear();

            Console.WriteLine("Введите члены целевой");
            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine($"Введите {i + 1}-й члены целевой");
                Cn[i] = double.Parse(Console.ReadLine());
            }

            Console.Clear();



            Console.ReadKey();
        
        }
    }
}
