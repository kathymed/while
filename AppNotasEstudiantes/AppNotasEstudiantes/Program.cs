using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNotasEstudiantes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Escribir un programa que lea 10 notas de alumnos 
             * y nos informe cuántos tienen notas mayores o
             * iguales a 7 y cuántos menores.Para resolver este
             * problema se requieren tres contadores.*/
            int cont1, cont2=0, cont3=0, valor=0;
            float nota;
            Console.WriteLine("PROGRAMA NOTAS");
            Console.WriteLine("Digitar el numero de notas");
            valor = int.Parse(Console.ReadLine());
            for (cont1 = 1; cont1 <= valor; cont1++)
            {
                Console.WriteLine("Digitar nota:");
                nota = float.Parse(Console.ReadLine());
                Console.WriteLine("la nota" + cont1 + "es:"+nota);
                if (nota >= 3)
                {
                   cont2 = cont2 + 1;
                }
                else
                {
                    cont3 = cont3 + 1;
                }
            }
            Console.WriteLine("Digitar notas mayores de 3 son:" +cont2);
            Console.WriteLine("Digitar nota: menores de 3 son:" +cont3);
            Console.ReadKey();
        }
     }
}
