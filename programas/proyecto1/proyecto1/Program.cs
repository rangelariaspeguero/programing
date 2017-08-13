using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rangel Arias perguero Matricula:16-EIIN-1-025 Seccion:0463");
            Console.WriteLine("Julio Angel Brito Diaz Matricula:16-EIIN-1-033 Seccion:0463");
            Console.WriteLine("Marialis Raquel Lebron Abad Matricula:16-EIIT-1-044 Seccion:0463");
            int cuenta;
            float saldo, suma;
            string linea;
            suma = 0;
            do
            {

                Console.Write("Ingrese numero de cuenta:");
                linea = Console.ReadLine();
                cuenta = int.Parse(linea);
                if (cuenta >= 0)
                {
 


                Console.Write("Ingrese saldo:");
                linea = Console.ReadLine();
                saldo = float.Parse(linea);
                if (saldo > 0)
                {
                
                    Console.WriteLine("saldo acreedor.");
                    suma = suma + saldo;
                
                
                }


                else

                {

                if(saldo < 0)
               
                {

                    Console.WriteLine("saldo deudor.");

                }
                else
                {

                    Console.WriteLine("saldo nulo.");

                }


           }


            } 

    } while (cuenta >= 0);

                    Console.Write("Total de saldos acreedores:");
    Console.Write(suma);
        Console.ReadKey();
    
    


















        }
    }
}
