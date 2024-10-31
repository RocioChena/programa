

// Este programa de consola en C# permite al usuario ingresar un año 
// y determina si es un año bisiesto o no. Utiliza componentes básicos de .NET 
// para el ingreso y procesamiento de datos.


using System;

namespace VerificarAnoBisiesto
{
    class Program
    {
    
        static void Main(string[] args)
        {
            // Solicita al usuario ingresar un año
            Console.WriteLine("Ingrese un año para verificar si es bisiesto:");

            
            if (int.TryParse(Console.ReadLine(), out int year))
            {
                
                if (EsBisiesto(year))
                {
                    // Muestra el resultado si el año es bisiesto
                    Console.WriteLine($"El año {year} es bisiesto.");
                }
                else
                {
                    // Muestra el resultado si el año no es bisiesto
                    Console.WriteLine($"El año {year} no es bisiesto.");
                }
            }
            else
            {
                // Indica al usuario que debe ingresar un valor numérico válido
                Console.WriteLine("Por favor, ingrese un año válido.");
            }
        }

                static bool EsBisiesto(int year)
        {
            
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }
    }
}
