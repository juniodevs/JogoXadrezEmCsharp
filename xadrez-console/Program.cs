using System;
using tabuleiro;
using xadrez_console;
using xadrez;
using xadrez_console.tabuleiro;
using xadrez_console.xadrez;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            PosicaoXadrez pos = new PosicaoXadrez('c', 7);

            Console.WriteLine(pos);

            Console.WriteLine(pos.toPosicao());
        }
    }
}