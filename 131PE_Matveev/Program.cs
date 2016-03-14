using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _131PE_Matveev
{
    class Program
    {
        static int TotalDay(int result, bool isOverride)
        {
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
            else if (result > 100000)
            {
                total = result / 100 * 15;
            }
            else
            {
                total = totalMin;
            }
            return isOverride ? 2 * total : total;
        }

        static int[] GetDaysFromConsole()
        {
            Console.Write("Введете отработанные дни: ");
            int weekSize = Convert.ToInt32(Console.ReadLine());
            int[] days = new int[weekSize];

            for (int i = 0; i < weekSize; i++)
            {
                Console.Write("Введете размер дневной выручки: ");
                days[i] = Convert.ToInt32(Console.ReadLine());
            }

            return days;
        }

        static void Main(string[] args)
        {
            int total = 0;
            int[] days = null;
            ConsoleKeyInfo mode;

            while (days == null)
            {
                Console.WriteLine("2 - ручной ввод ");

                mode = Console.ReadKey(true);

                switch (mode.Key)
                {
                    case ConsoleKey.D1:

                        //days = 

                        break;
                    case ConsoleKey.D2:

                        days = GetDaysFromConsole();

                        break;
                }

            }


            for (int i = 1; i < days.Length; i++)
            {
                int dayPay = TotalDay(days[i], i > 4);
                total += dayPay;
                Console.WriteLine("День {0}: {1} руб.", i, dayPay);
            }
            Console.WriteLine("Выручка за неделю: {0} руб.", total);
            Console.ReadKey();
        }
    }

}
