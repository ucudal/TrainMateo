//--------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using ClassLibrary;

namespace ConsoleApplication
{
    /// <summary>
    /// Programa de consola de demostración.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Punto de entrada al programa principal.
        /// </summary>
        public static void Main()
        {
            var train = new Train("Tren3");
            train.StartEngines();
            Console.WriteLine("Hello World!");
            Train tren= new Train("");
            for (int i=0; i<100; i+=1){
                tren=new Train($"Tren{i+1}");
            }
            Train tren10M= new Train("");
            for (int i=0; i<10000000; i+=1){
                tren10M=new Train($"Tren{i+1}");
                Console.WriteLine(tren10M);

            }
        }
    }
}