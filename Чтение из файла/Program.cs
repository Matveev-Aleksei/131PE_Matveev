using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Чтение_из_файла
{
    class Program
    {
        static int[] Array(int[] total)
        {
            int[] p = new int[total.Length];

            for (int i = 0; i < total.Length; i++)
            {
                if (i > 4)
                {
                    if (total[i] <= 100000)
                    {
                        p[i] = total[i] / 100 * 15;
                    }
                    if (total[i] > 10000)
                    {
                        p[i] = ((total[i] - 10000) / 100 * 10 + 500) * 2;
                    }
                    else
                    {
                        p[i] = (total[i] / 100) * 5;
                    }

                }
                else
                {
                    if (total[i] > 10000)
                    {
                        p[i] = (total[i] - 10000) / 100 * 10 + 500;
                    }
                    else
                    {
                        p[i] = (total[i] / 100) * 5;
                    }

                }

            }
            return p;


        }


static void Main(string[] args)
        {

            int i = 0;
            int[] t;
            Console.WriteLine("ВВедите название файла");
            string name = Console.ReadLine();
            string[] mas = File.ReadAllText(name).Split(new char[] { ' ' });
            int[] total = new int[mas.Length];
            for (i = 0; i < mas.Length; i++)
            {
                total[i] = Int32.Parse(mas[i]);
            }

            t = Array(total);

            for (i = 0; i < t.Length; i++)
            {
                Console.WriteLine("Заработок за {0} День равен: {1}", i + 1, t[i]);
            }
            int sum = t.Sum();

            Console.WriteLine("\n");
            Console.WriteLine("Сумма заработка: {0} ", sum);

            Console.ReadKey();


            Console.ReadKey();
        }
    }
}
