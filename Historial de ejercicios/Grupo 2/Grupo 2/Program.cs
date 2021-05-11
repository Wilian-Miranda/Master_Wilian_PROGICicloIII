using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo_2
{
    class Program
    {

        static void Main(string[] args)
        {
            mostrar();

             void mostrar()
            {
                Console.WriteLine("BIENVENIDO" + "\n\n" + "Introduzca su nombre: ");
                String nombre = Console.ReadLine();

                Console.WriteLine("\n" + "Introduzca su edad: ");
                String edad = Console.ReadLine();

                Console.WriteLine("\n" + "Introduzca su sexo(Hombre=H,h y Mujer=M,m): ");
                String sexo = Console.ReadLine();

                if (sexo == "H" || sexo == "h")
                {
                    Console.WriteLine("El Sr." + nombre + " ha sido registrado");
                    Console.ReadLine();
                }
                else if (sexo == "M" || sexo == "m")
                {
                    Console.WriteLine("El Sra." + nombre + " ha sido registrada");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Datos incompletos");
                }
            }

            continuar();
            void continuar()
            {
                Console.WriteLine("¿Desea continuar?s/n");
                string desicion = Console.ReadLine();
                if (desicion == "s")
                {
                    mostrar();
                    continuar();
                }
                else if (desicion == "n")
                {
                    Console.WriteLine("Programa finalizado");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Dato inválido");
                    Console.ReadLine();
                    continuar();
                }

            }
        }
    }
}
