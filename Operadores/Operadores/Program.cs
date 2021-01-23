using System;

namespace Operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 3;
            int num3;

            //Operadores numericos
            num3 = -num1;
            Console.WriteLine("El valor negativo del num1 es {0}",num3);

            bool haysol = true;
            Console.WriteLine("Hay Sol? {0}", !haysol);

            //Operadores de adicion
            int num = 0;

            num++;
            Console.WriteLine("Num = {0} ", num);

            //Operadores de sustraccion

            num--;
            Console.WriteLine("Num = {0}", num);
            Console.WriteLine("Num = {0}", --num);
            Console.WriteLine("Num = {0}", num);


            //operadores matematicos

            int resutlado = num1 + num2;
            Console.WriteLine("El resultado " + num1 + " + " + num2 + " es igual a " + resutlado);
            resutlado = num1 - num2;
            Console.WriteLine("El resultado " + num1 + " - " + num2 + " es igual a " + resutlado);
            resutlado = num1 * num2;
            Console.WriteLine("El resultado " + num1 + " * " + num2 + " es igual a " + resutlado);
            resutlado = num1 / num2;
            Console.WriteLine("El resultado " + num1 + " / " + num2 + " es igual a " + resutlado);
            
            //operador modular          
            
            resutlado = num1 % num2;  //solo muestra el resto
            Console.WriteLine("El resultado " + num1 + " mod " + num2 + " es igual a " + resutlado);

            //operadores relacionales

            bool esMenor;
            esMenor = num1 < num2;

            Console.WriteLine("El resultado " + num1 + " < " + num2 + " es igual a " + esMenor);


            //operadores de igualdad

            bool esIgual;
            esIgual = num1 == num2;
            Console.WriteLine("El resultado " + num1 + " == " + num2 + " es igual a " + esIgual);

            esIgual = num1 != num2;
            Console.WriteLine("El resultado " + num1 + " != " + num2 + " es igual a " + esIgual);



            if (true)
            {

            }
            else if(true)
            {

            }
            else
            {

            }
        }
    }
}
