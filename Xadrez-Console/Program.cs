﻿using System;
using tabuleiro;

namespace Xadrez_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Posicao P;

            P = new Posicao(3, 4);

            Console.WriteLine("Posição: " + P);

            Tabuleiro tab = new Tabuleiro(8, 8);
            Console.ReadLine();
        }
    }
}
