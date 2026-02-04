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
            Console.WriteLine("Ingrese un numero decimal: ");
            int numeroDecimal = int.Parse(Console.ReadLine());

            while (numeroDecimal > 0)
            {
               int residuo = numeroDecimal % 2;//obtengo el residuo
                Console.Write(residuo);
                numeroDecimal = numeroDecimal / 2;//actualizo el numero decimal


            }

        }
    }
}
       
    

