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
            int d;
            int z;
            int c = 0;
            int a = 0;

            Console.WriteLine("Введите колличество дней: ");
            d = Convert.ToInt32(Console.ReadLine());

            if (d > 5)
            {
                Console.WriteLine("Напоминание! Работа в выходные дни оплачивается по двойному тарифу");
            }

                do
                {
                    Console.WriteLine("Введите размер дневной выручки: ");
                    i = Convert.ToInt32(Console.ReadLine());

                    if (i <= 10000)
                        {
                            z = i * 5 / 100;
                            Console.WriteLine("Размер заработной платы равен: " + z);
                        }

                    else
                        {
                            z = i * 10 / 100 + 500;
                            Console.WriteLine("Размер заработной платы равен: " + z);
                        }

                    if (z < 300)
                        {
                            z = 300;
                            Console.WriteLine("Минимальный размер оплаты труда за 1 день равен 300р. ");
                        }

                    a++;
                    

                    if (a > 5)
                        {
                            z = z * 2;
                            Console.WriteLine("Внимание! Двойной тариф. Заработная плата за этот день равна: " + z);
                        }

                    c = c + z;

                    if (a == d)
                        {
                            Console.WriteLine("Заработная плата составляет: " + c);
                        }
                }
                while (a < d);
            
           

            Console.ReadKey();
        }
    }
}
