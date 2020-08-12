using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Uso matrices  registro de usuarios

            string[,] usuario = new string[2, 4];

            for (int i = 0; i < 2; i++)
            {
                Console.Write("Ingrese su nombre: ");
                usuario[i, 0] = Console.ReadLine();

                Console.Write("Ingrese su apellido: ");
                usuario[i, 1] = Console.ReadLine();

                Console.Write("Ingrese su Mail: ");
                usuario[i, 2] = Console.ReadLine();

                Console.Write("Ingrese su N° de Celular");
                usuario[i, 3] = Console.ReadLine();
            }

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Usuario:{0} Nombre:{1} Apellido:{2} Mail:{3}",i+1, usuario[i,0], usuario[i,1], usuario[i,2], usuario[i, 3]);
            }
            Console.ReadKey();
        }
    }
}
