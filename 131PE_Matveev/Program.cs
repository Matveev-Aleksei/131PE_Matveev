using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _131PE_Matveev
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задание 1. Приложение для расчета ЗП.
           
            int i;
            int z;
            z = 0;
            Console.WriteLine("Введите размер дневной выручки ");
            i = Convert.ToInt32(Console.ReadLine());

            if (i <= 1000)
                {
                    z = i / 100 * 5;
                    Console.WriteLine("Размер выручки равен ");
                    Console.Write(z); 
                }

            if (i > 10000)
                {
                
                    z = i / 100 * 10 + 500;
                    Console.WriteLine("Размер выручки равен ");
                    Console.Write(z);
                }


             // Задание 2. Введение понятия - минимальная ЗП. 

            if (z < 300)
                {
                    Console.WriteLine("Внимание! Минимальный размер оплаты труда за день = 300р");
                    z = 300;
                    Console.WriteLine("Размер выручки равен ");
                    Console.Write(z);
                }

           

            Console.ReadKey();
        }
    }
}
