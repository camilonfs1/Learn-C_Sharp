using System;

namespace Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            EscribeAlgo();
            Console.WriteLine("Resultado : "+Calcular());
        }
        public static void EscribeAlgo()
        {
            Console.WriteLine("Por favor ingrese un numero :");
           
        }

        public static int Calcular()
        {
            string txtnum1 = Console.ReadLine();
            Console.WriteLine("Por favor ingrese un segundo numero :");
            string txtnum2 = Console.ReadLine();

            int num1 = int.Parse(txtnum1);
            int num2 = int.Parse(txtnum2);

            int sum = num1 + num2;

            return sum;
        }
    }
}
