using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task__4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Введите длину последовательности: ");
            int length = Convert.ToInt32(Console.ReadLine());
            int minValue = int.MaxValue;
            int number = 0;

            for(int i = 1; i < length+1; i++)
            {
                Console.Write($"Введите {i} цифру: ");
                number = Convert.ToInt32(Console.ReadLine()); 

                if( minValue > number )
                {    
                    minValue = number;

                }
            }
            Console.WriteLine($"Минимальное число = {minValue}");
            Console.ReadKey();
        }
    }
}
