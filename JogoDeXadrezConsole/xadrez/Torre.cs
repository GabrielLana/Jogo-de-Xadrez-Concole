using JogoDeXadrezConsole.tabuleiro;
using JogoDeXadrezConsole.tabuleiro.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDeXadrezConsole.xadrez
{
    public class Torre : Peca
    {
        public Torre(Tabuleiro tab, Cor cor) : base(tab,cor)
        {

        }

        public override string ToString()
        {
            return "T";
        }
    }
}
