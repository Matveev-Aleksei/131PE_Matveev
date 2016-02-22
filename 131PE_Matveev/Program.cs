using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _131PE_Matveev
{
    class Program
    {
        static void TotalDay(int result, bool isOverride)
        {
            // Задание. Приложение для расчета ЗП.

            int totalMin = 300;
            int total;

            if (result == 10000)
            {
                total = 500;
            }
            else if (result > 10000)
            {
                total = ((result - 10000) / 100) * 10 + 500;
            }
            if (result > 100000)
            {
                total = result / 100 * 15;
            }
            else
            {
                total = totalMin;
            }

            return isOverride ? 2 * total : total;
        }

        static int [] 

         
            

                 //int revenue;
                 //int days;
                 //int wage;
                 //int c = 0;
                 //int a = 0;

                 //Console.WriteLine("Введите колличество дней: ");
                 //days = Convert.ToInt32(Console.ReadLine());

                 //if (days > 5)
                 //{
                 //    Console.WriteLine("Напоминание! Работа в выходные дни оплачивается по двойному тарифу");
                 //}

                 //    do
                 //    {
                 //        Console.WriteLine("Введите размер дневной выручки: ");
                 //        revenue = Convert.ToInt32(Console.ReadLine());

                 //        if (revenue <= 10000)
                 //            {
                 //                wage = revenue * 5 / 100;
                 //                Console.WriteLine("Размер заработной платы равен: " + wage);
                 //            }

                 //        else
                 //            {
                 //                if (revenue == 50000)
                 //                {
                 //                    wage = 4500;
                 //                    Console.WriteLine("Размер заработной платы равен: " + wage);
                 //                }
                 //                else
                 //                {
                 //                    wage = (revenue - 10000) * 10 / 100 + 500;
                 //                    Console.WriteLine("Размер заработной платы равен: " + wage);
                 //                }
                 //            }

                 //        if (wage < 300)
                 //            {
                 //                wage = 300;
                 //                Console.WriteLine("Минимальный размер оплаты труда за 1 день равен 300р. ");
                 //            }

                 //        a++;


                 //        if (a > 5)
                 //            {
                 //                wage = wage * 2;
                 //                Console.WriteLine("Внимание! Двойной тариф. Заработная плата за этот день равна: " + wage);
                 //            }

                 //        c = c + wage;

                 //        if (a == days)
                 //            {
                 //                Console.WriteLine("Заработная плата составляет: " + c);
                 //            }
                 //    }
                 //     while (a < days);



                 Console.ReadKey();
        }
    }
}
