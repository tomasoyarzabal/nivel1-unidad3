using System;

namespace ejerciciosu3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("ingrese un numero");
            n = int.Parse(Console.ReadLine());
            if(n > 10){
                Console.WriteLine("si es mayor a 10");
            }else{
                Console.WriteLine("no es mayor a 10");
            }
        }
    }
}
