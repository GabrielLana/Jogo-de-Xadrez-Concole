using JogoDeXadrezConsole.tabuleiro;
using JogoDeXadrezConsole.tabuleiro.Enums;
using JogoDeXadrezConsole.tabuleiro.Exceptions;
using JogoDeXadrezConsole.xadrez;
using System;

namespace JogoDeXadrezConsole
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);

            tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
            tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
            tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 2));

            tab.ColocarPeca(new Torre(tab, Cor.Branca), new Posicao(3, 5));

            Tela.ImprimirTabuleiro(tab);

            Console.ReadLine();

            Console.ReadLine();
        }
    }
}
