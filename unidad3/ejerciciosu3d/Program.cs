using System;

namespace ejerciciosu3d
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, menor;
            Console.WriteLine("ingrese un numero");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese un otro");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese otro");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el ultimo");
            d = int.Parse(Console.ReadLine());

            if(a < b){
                menor = a;
            }else{
                menor = b;
            }

            if(c < menor){
                menor = c;
            }

            if(d < menor){
                menor = d;
            }
                
            Console.WriteLine("el menor es: " + menor);
            



        }
    }
}
