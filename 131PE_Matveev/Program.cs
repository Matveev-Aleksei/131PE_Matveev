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
            int i;
            int z;
            Console.WriteLine("Введите размер дневной выручки ");
            i = Convert.ToInt16(Console.ReadLine());

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
            
          
            Console.ReadKey();
        }
    }
}
