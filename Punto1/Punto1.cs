using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    class Punto1
    {
        static void Main(string[] args)
        {
           
            double descuento = 0;
            Console.WriteLine("****DETERMINAR EL VALOR DE UN PASAJE DE AVIÓN**** \n");
            string respuesta = "si";
            while (respuesta.Equals("si"))
            {
                Console.WriteLine("------Ingrese la cantidad de kilometros a recorrer-------- ");
                double distancia = double.Parse(Console.ReadLine());

                Console.WriteLine("-----Ingrese el número de días de estancia \n");
                int dias = int.Parse(Console.ReadLine());

                double precioDistancia = distancia * 35000;
                if (distancia > 1000 && dias > 7)
                {
                    descuento = precioDistancia * 0.30;
                    double precioDescuento = precioDistancia - descuento;
                }
                Console.WriteLine("El precio del pasaje es:" + precioDistancia+"\n");

                Console.WriteLine("******¿Desea consultar el precio de otro pasaje?  Si - No********");
                respuesta = Console.ReadLine().ToLower();
            }

            Console.WriteLine("\n ********GRACIAS POR CONSULTAR EL VALOR DE SU PASAJE**********");
            Console.ReadKey();
            
        }
    }
}
