using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Procedimientos y funciones

            int numero1 = 10;
            int numero2 = 20;
            
            Suma(numero1, numero2);//se pueden elegir las variables o se pueden designar valores)
            Suma(32, 12);
            Suma(123, -12);
            Resta(numero1,numero2);
            Resta(102, 93);
            Resta(21, -12);
            
            Console.ReadKey();
        }
        static void Suma(int n1, int n2)
        {
            if (n1<0 || n2<0)
            {
                Console.WriteLine("No se pueden sumar numeros negativos");
            }
            else
            {
                Console.WriteLine(n1 + n2);
            }            
        }
        static void Resta(int n1, int n2)
        {
            if (n1 < 0 || n2 < 0)
            {
                Console.WriteLine("No se pueden restar numeros negativos");
            }
            else
            {
                Console.WriteLine(n1 - n2);
            }
        }

    }
}
