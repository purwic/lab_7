using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            double[] a = new double[15];
            double[] b = new double[15];

            Console.Write("C = ");
            double C = double.Parse(Console.ReadLine());

            for (int i = 0; i < 15; i++) 
            {
                Console.Write($"a[{i}] = ");
                a[i] = double.Parse(Console.ReadLine());
                b[i] = a[i] / 15.0 + 2;
            }


            double p = 1;
            int count = 0;

            for (int i = 0; i < 15; i++)
            {
                if(a[i] < C)
                {
                    p *= a[i];
                    count++;
                }
            }

            Console.WriteLine("\n\n1.");
            Console.Write("Произведение числа элементов массива {a_i} меньших C = ");
            Console.WriteLine(p);
            Console.Write("Их количество = ");
            Console.WriteLine(count);


            Console.WriteLine("\n\n2.");

            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine($"b[{i}] = {b[i]}");
            }


            Console.WriteLine("\n\n3.");

            double sum = 0;

            for (int i = 0; i < 15; i++)
            {
                if(i % 2 == 0)
                {
                    sum += b[i];
                }
            }

            Console.Write("Сумма элементов массива {b_i}, расположенных на четных позициях = ");
            Console.WriteLine(sum);


        }
    }
}
