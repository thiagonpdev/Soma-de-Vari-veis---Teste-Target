﻿namespace Soma_de_Variáveis
{
    class Program
    {
        static void Main(string[] args)
        {
            int INDICE = 12;
            int SOMA = 0;
            int K = 1;

            while (K < INDICE)
            {
                K = K + 1;
                SOMA = SOMA + K;
            }
            Console.WriteLine(SOMA);
        }
    }
}