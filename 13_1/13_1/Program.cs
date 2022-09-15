using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 2, i;
            Console.Write("Введите натуральное число не меньше двух: ");
            i = Convert.ToInt32(Console.ReadLine());
            while (a * a <= i)
            {
                if (a % i == 0)
                {
                    Console.WriteLine(i);
                    break;
                }
                a++;
            }
            Console.ReadKey();
        }
    }
}
