    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa2
{
    class PruebaVector
    {
       
        

            private string[] nombres; //Declaramos un vector de tipo estring para los nombres
            private float[] sueldos; //Declaramos un vector de tipo float para los sueldos
            public void cargar()
            {

                nombres = new string [5];
                sueldos = new float [5];
                for (int f = 0; f< nombres.Length; f++)
                {
                    Console.Write("Ingrese el nombre del empleado" +(f+1)+": ");
                    nombres[f] = Console.ReadLine();
                    string linea;
                    linea = Console.ReadLine();
                    sueldos[f] = float.Parse(linea);

                }
            }

        public void Mayorsueldo()
        {
            float mayor;
            int pos;
            mayor = sueldos[0];
            pos = 0;
            for (int f = 1; f< nombres.Length; f++)
            {
                if (sueldos[f] > mayor)
                {
                    mayor = sueldos[f];
                    pos = f;

                }
            }
            Console.WriteLine("El empleado con sueldo mayor es:" + nombres[pos]);
            Console.WriteLine("Tiene un sueldo de:" + mayor);
            Console.ReadKey();
        }
static void Main(string[] args)
    {

        Console.WriteLine("Rangel Arias Peguero  Matricula:16-EIIN-1-025 seccion:0463");
    Console.WriteLine ("Julio Angel Brito Diaz  Matricula:16-EIIN-1-033 seccion:0463");
    Console.WriteLine("Marialis Raquel Lebron Abad  Matricula:16-EIIt-1-044 seccion:0463");
    
    PruebaVector pv = new PruebaVector();
      pv.cargar();
        pv.Mayorsueldo();
















        }
    }
}
