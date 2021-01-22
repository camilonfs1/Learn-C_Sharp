using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {

            //Line for change console color 
            /* Console.ForegroundColor = ConsoleColor.DarkBlue;
             Console.BackgroundColor = ConsoleColor.Yellow;
             Console.Clear();*/

            //Tipos de datos
            sbyte s = 125;
            int i = 200000000;
            long r = 30000000000000000;
            float x = 99.99f;   //Decimales en un rango desde 1.5x10^-45 hasta 3.4x10^38, Precision de 7 digitos
            double y = 1.5;     //Precision de 15 digitos
            bool b = true;
            char letraUnica = 'A';
            string numbreUser = "Camilo";

            Console.WriteLine("Hello World!");


            Console.WriteLine("Hello Camilo !");          
            Console.Read();


        }
    }
}
 