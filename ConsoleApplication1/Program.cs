using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            double R1, R2;

            Console.Write("Введите радиус первого круга: ");
            R1 = double.Parse( Console.ReadLine() );

            Console.Write("Введите радиус второго круга: ");
            R2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"R1 = {R1}\nR2 = {R2}");

            if ( R2 >= R1 ) {
                Console.WriteLine("Неверные входные данные!");
                return;
            }

            double S1 = 3.14 * R1 * R1;
            double S2 = 3.14 * R2 * R2;

            Console.WriteLine($"S1 = {S1}\nS2 = {S2}\nS3 = {S1 - S2}");
        }
    }
}
