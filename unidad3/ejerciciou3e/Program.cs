using System;

namespace ejerciciou3e
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            Console.WriteLine("ingrese un numero");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese otro");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese otro");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el ultimo");
            d = int.Parse(Console.ReadLine());

            if(a > 100)
               Console.WriteLine("EL PRIMER VALOR " + a + " ES MAYOR A 100");

            if(b > 100)
                Console.WriteLine("el segundo valor " + b + " es mayor a 100");

            if(c > 100)
                Console.WriteLine("EL TERCER VALOR " + c + " ES MAYOR A 100");


            if(d > 100)
                Console.WriteLine("el cuarto valor " + d + " es mayor a 100");




            
        }
    }
}
