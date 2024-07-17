using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace _07_SecuenciaFibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que muestra los primeros 30 números de la secuencia fibonacci.");

            //Declaración de los primeros dos números de la secuencia Fibonacci
            int num1 = 0;
            int num2 = 1;
            for (int i = 0; i < 30; i ++)
            {                
                Console.WriteLine((i+1) + "- El siguiente número de la secuencia fibonacci es: " + num1);                
                int num3 = num1 + num2;
                num1 = num2;
                num2 = num3;
            }
            Console.ReadLine();
        }
    }
}