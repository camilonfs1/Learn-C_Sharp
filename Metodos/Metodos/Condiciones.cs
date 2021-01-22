using System;
using System.Collections.Generic;
using System.Text;

namespace Metodos
{
    class Condiciones
    {
        static void mm(string[] args)
        {
            Console.WriteLine("Ingrese un numero");
            String valorIngresado = Console.ReadLine();

            try
            {
                int valorComoInt = int.Parse(valorIngresado);
            }
            catch (FormatException)
            {
                Console.WriteLine("El formato del valor ingresado es incorrecto");
            }
            catch (OverflowException)
            {
                Console.WriteLine("El numero ingresado es demasiado largo o demasiado corto");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("No se a ingresado ningun valor");
            }
            finally
            {
                Console.WriteLine("Esta frase saldra pase lo que pase");
            }

        }
        static void divide(string[] args)
        {
            int num1 = 10;
            int num2 = 0;
            

            try
            {
                int div = num1 / num2;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("No se puede dividir por cero");
            }
        }
    }
}
