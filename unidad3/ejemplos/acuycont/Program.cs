using System;

namespace acuycont
{
    class Program
    {
        static void Main(string[] args)
        {
         //acumuladores y cntadores
         int contador = 0, e1 = 40, e2 = 40, e3 = 40;
         int acumulador = 0;
         int promedio;
         //contador = contador +1
         //++
         //--
         //acumulador = acumulador + lo que sea pero numerico
         //+=
         //-=
         if(e1 > 18){
             contador++;
             acumulador = acumulador + e1;
         }
         if(e2 > 18){
             contador = contador + 1;
             acumulador += e2;
         }
         if(e3 > 18){
             contador++;
             acumulador += e3;
         }
         promedio = acumulador/contador;
         Console.WriteLine("el promedio es " + promedio);


        }
    }
}
