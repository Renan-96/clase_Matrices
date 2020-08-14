using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;

            do
            {
                Menu();
                opcion = int.Parse(Console.ReadLine());
                if (opcion < 5 && opcion > 0)
                {
                    Operatorias(opcion);
                }
                else if (opcion == 0)
                {
                    Console.WriteLine("Salir");
                }
                else
                {
                    Console.WriteLine("Opcion invalida");
                }
                               
                
            } while (opcion != 0);
            
            Console.ReadLine();

        }
        
        static void Menu()
        {
            Console.WriteLine("*****************");
            Console.WriteLine("*1.- Sumar");
            Console.WriteLine("*2.- Restar");
            Console.WriteLine("*3.- Multiplicar");
            Console.WriteLine("*4.- Dividir");
            Console.WriteLine("*****************");
            Console.WriteLine("Ingrese una opcion: ");
        }

        static void Operatorias(int tipo)
        {
            
            Console.WriteLine("Ingrese numero 1");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese numero 2");
            int n2 = int.Parse(Console.ReadLine());

            switch (tipo)
            {
                case 1: Console.WriteLine("La suma es: "+ (n1+n2));
                    break;
                case 2: Console.WriteLine("La resta es: "+ (n1-n2));
                    break;
                case 3: Console.WriteLine("La multiplicación es: "+ (n1*n2));
                    break;
                case 4: Console.WriteLine("La división es: "+ (n1/n2));
                    break;             
                default:
                    break;
            }

            
        }

    }
}
