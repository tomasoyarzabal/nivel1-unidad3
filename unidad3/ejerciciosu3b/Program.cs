using System;

namespace ejerciciosu3b
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("ingrese un numero");
            n = int.Parse(Console.ReadLine());
            if(n > 0){
                Console.WriteLine("Positivo");
            }else if(n < 0){
                Console.WriteLine("Negativo");
            }else{
                Console.WriteLine("0");
            }
                
            
        }
    }
}
