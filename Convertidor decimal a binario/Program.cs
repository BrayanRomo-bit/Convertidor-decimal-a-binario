using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convertidor_decimal_a_binario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero decimal: ");//pedimos el numero decimal al usuario
            int numeroDecimal = int.Parse(Console.ReadLine());//leemos el numero ingresado y lo convertimos a entero

            string numeroBinario = ""; // Inicializar la variable antes de usarla

            while (numeroDecimal > 0)//mientras el numero decimal sea mayor a 0 
            {
                int residuo = numeroDecimal % 2; // obtengo el residuo
                numeroBinario = residuo + numeroBinario;//guardo el residuo en la variable numeroBinario
                numeroDecimal = numeroDecimal / 2; // actualizo el numero decimal
            }

            Console.WriteLine("El número binario es: " + numeroBinario);//muestro el resultado
        }
    }
}

