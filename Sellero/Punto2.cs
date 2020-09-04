using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    class Punto2
    {
        static void Main(string[] args)
        {
           
            double capacidadMayor = 18000;
            double precio = 0;
            double bultoMayor = 0;
            double bultoMenor = 999999;
            double contadorBultos = 0;
            double acumuladorKilos = 0;
            double acumuladorDinero = 0;
            Console.WriteLine("**************** BOING 747 *************** \n");
            Console.WriteLine("------¿Desea ingresar un bulto?  1. Si 2. No  -------");
            int opcion = int.Parse(Console.ReadLine());
            while (opcion !=1 && opcion != 2)
            {
                Console.WriteLine("*****Ingrese una opción valida, ¿Desea ingresar un bulto? ***** \n1. Si 2. No");
                opcion = int.Parse(Console.ReadLine());

            }
            while (opcion == 1)
            {
                
                Console.WriteLine("----Ingrese el peso en kilos del bulto");
                double kiloBulto = double.Parse(Console.ReadLine());
                if (kiloBulto > 500)
                {
                    Console.WriteLine("----El peso del bulto no puede superar los 500 kg");

                }
                else if (kiloBulto <0)
                {
                    Console.WriteLine("*****Ingrese un valor válido*****");
                }
                else if(kiloBulto>-1 || kiloBulto<501)
                {
          
                    acumuladorKilos = acumuladorKilos + kiloBulto;
                    if (acumuladorKilos > capacidadMayor)
                    {
                        Console.WriteLine("----Este bulto no se puede registrar porque excede el límite de carga del BOING 747");
                        acumuladorKilos = acumuladorKilos - kiloBulto;
                       
                    }
                    else
                    {
                        contadorBultos++;
                        if (bultoMayor < kiloBulto)
                        {
                            bultoMayor = kiloBulto;
                        }
                        if (bultoMenor > kiloBulto)
                        {
                            bultoMenor = kiloBulto;
                        }

                        if (kiloBulto > 0 && kiloBulto <= 25)
                        {
                            precio = 0;

                        }
                        else if (kiloBulto > 25 && kiloBulto <= 300)
                        {
                            //CONVERTIR 
                            precio = 1500;
                        }
                        else if (kiloBulto > 300 && kiloBulto <= 500)
                        {
                            precio = 2500;
                        }

                        Console.WriteLine("el precio del bulto en pesos es: " + precio + "\nEl precio del bulto en dolares es: " + precio / 3670);
                        acumuladorDinero = acumuladorDinero + precio;
                    }
                }
                Console.WriteLine("`\n *****¿Desea ingresar otro  bulto?  1. Si 2.No *******");
                opcion = int.Parse(Console.ReadLine());
                while (opcion != 1 && opcion != 2)
                {
                    Console.WriteLine("*****Ingrese una opción valida***** \n1. Si 2. No");
                    opcion = int.Parse(Console.ReadLine());

                }
            }
            double promedioBultos = acumuladorKilos / contadorBultos;
            Console.WriteLine("el bulto mayor es: "+bultoMayor);
            Console.WriteLine("el bulto menor es: " + bultoMenor);
            Console.WriteLine("La cantidad de bultos es:"+contadorBultos);
            Console.WriteLine("El promedio de bultos es:" +promedioBultos);
            Console.WriteLine("El precio total en pesos es: "+acumuladorDinero + "\nEl precio total en dolares es: " + acumuladorDinero / 3670);
            Console.ReadKey();


                // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
