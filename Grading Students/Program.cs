using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grading_Students
{
    class Program
    {
        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i = 0;i<array.Length;i++)
            {
                int temp = 0 ;
                if (array[i] >= 38)
                {
                    temp = (array[i] / 5);
                    if (array[i] % 5 >= 3)
                    {
                        temp++;
                        array[i] = temp * 5;
                    }
                }
                Console.WriteLine(array[i]);
            }
            Console.ReadKey();
        }
    }
}
