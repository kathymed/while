﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppWhile3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Desarrollar un programa que permita la carga 
             * de 10 valores por teclado y nos muestre posteriormente 
             * la suma de los valores ingresados y su promedio*/
            int valor, numero, suma = 0, promedio, contador = 1;
            Console.WriteLine("PROGRAMA LA SUMA Y SU PROMEDIO");
            Console.WriteLine("Digite Numero:");
            valor = int.Parse(Console.ReadLine());
            while (contador <= valor)
            {
                Console.WriteLine("Digite Numero:");
                numero = int.Parse(Console.ReadLine());
                suma = suma + numero;
                contador++;
            }

            promedio = suma / valor;
            Console.WriteLine("la suma es " + suma);
            Console.WriteLine("El promedio es " + promedio);
            Console.ReadKey();

        }
    }
}
