using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int argument;
            int startRange = 50;
            int endRange = 150;
            int startUserInterval = 10;
            int endUserInterval = 25;
            int numberMultiples = 0;

            Console.WriteLine($"Введите число N от {startUserInterval} до {endUserInterval} включительно");
            argument = Convert.ToInt32(Console.ReadLine());

            for (int i = argument; i <= endRange; i += argument)
            {
                if ( i >= startRange)
                {
                    numberMultiples++;
                }    
            }
            Console.WriteLine($"Количество чисел кратных выбранному N: {numberMultiples}");
        }
    }
}
