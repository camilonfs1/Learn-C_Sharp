﻿using System;

namespace First_Software
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int num1 = 13;
            int num2 = 5;
            int sum =  num1+num2;

            double d1 = 3.2;
            double d2 = 1.337;
            double sumd = d1 + d2;

            Console.WriteLine("La suma de " + num1 + " + " + num2 + " da como resultado: " + sum);
            Console.WriteLine("La suma de " + d1 + " + " + d2 + " da como resultado: " + sumd);*/

            string nombre = "Camilo";
            string mensaje = "Mensaje numero 1 es ";

            string mensmay = mensaje.ToUpper();//Todo en mayuscula

            Console.WriteLine(mensmay + nombre);           
            Console.Read();
        }
    }
}