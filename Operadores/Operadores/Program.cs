using System;

namespace Operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = -5;
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



        }
    }
}
