﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePruebaGit2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola mundo C#");
            Console.WriteLine("Integracion de VS con Git");
            Console.ReadKey();

            //Imprimir la suma de 2 numeros
            Console.WriteLine("la suma de 10 + 20: {0} ", (10 + 20));
            Console.ReadKey();


            //Saludos desde la PUCESE
            Console.WriteLine("BIENVENIDOS A LA PUCESE");
            Console.WriteLine("SEGUNDO DE TIC");
            Console.ReadKey();

            Console.WriteLine("Probando la funcion");
            int suma = funcionSuma(10, 20);
            Console.WriteLine("Resultado funcion ={0}",suma);

        }

        //funcion suma
        int funcionSuma(int a, int b)
        {
            retun (a * 10 + b * 100);
        }
}
