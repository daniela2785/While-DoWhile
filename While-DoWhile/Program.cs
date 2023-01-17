//estrutura de repetição
//While: recebe a condiçao e enquanto essa condição for verdadeira ele vai repetir
using System;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {


            /*
                //quando a condição  for pra sempre verdade ela vai ficar em loop infinito
                       int contador =  0;
                       while (contador < 20)
                       {
                           Console.WriteLine("Rodando o while!");
                           //contador = contador + 1;
                           //contador += 1;
                           contador++; 
                       }
                   Console.WriteLine("FIM DA LINHA");
              */


            int contador2 = 0;
            while (contador2 < 20)
            {
                Console.WriteLine("do while!");
                //contador = contador + 1; outro jeito de fazer
                //contador += 1;
                contador2++;
            }
            Console.WriteLine("FIM DA LINHA");
            Console.ReadLine();

        }
    }
}