using System;

namespace ejerciciosu3c
{
    class Program
    {
        static void Main(string[] args)
        {
            float iv,descuento,total;
            Console.WriteLine("ingrese el importe de venta");
            iv = float.Parse(Console.ReadLine());
            if(iv < 1000){
                Console.WriteLine("no hay descuento");
            }else if(iv < 5000){
                Console.WriteLine("10 OFF");
                descuento = iv * 10 / 100;
                total = iv - descuento;
                Console.WriteLine("El importe final es " + total);
            }else{
                Console.WriteLine("18 OFF");
                descuento = iv * 18 / 100;
                total = iv - descuento;
                Console.WriteLine("El importe final es de " + total);

            }
            


        }
    }
}
