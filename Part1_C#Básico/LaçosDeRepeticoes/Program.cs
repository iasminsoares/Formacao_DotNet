using System;

namespace LaçosDeRepeticoes
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;

            while (contador <= 10)
            {
                Console.WriteLine(contador);
                contador++;
            }

            

            for (int contadorLinha  = 0; contadorLinha <= 10; contadorLinha++)
            {
                for (int contadorColuna = 0; contadorColuna <= contadorLinha; contadorColuna++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
           


            for (int contadorLinha = 1; contadorLinha <= 100; contadorLinha++)
            {
                if (contadorLinha % 3 == 0)
                {
                    Console.WriteLine(contadorLinha);
                }
            }

            int fatorial = 1;
            for (int n = 1; n < 11; n++)
            {
                fatorial *= n;
                Console.WriteLine("Fatorial de " + n + " = " + fatorial);
            }

            Console.ReadLine();
        }
    }
}
