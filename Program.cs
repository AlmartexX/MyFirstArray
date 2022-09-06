using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_first_array
{
    class Program
    {
        static void Main()
        {
            int[] array = new int[10];
            Random random = new Random();
            Console.WriteLine($"Your array:");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0,10);
                Console.Write("{0,4}",array[i]);
            }

            int[,] matrix = new int[5,5];
            Console.WriteLine($"\nYour matrix:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrix[i,j] = random.Next(0, 10);
                    Console.Write("{0,3}",matrix[i,j]);

                }
                
            }

            Console.ReadKey();
            
        }
    }
}
