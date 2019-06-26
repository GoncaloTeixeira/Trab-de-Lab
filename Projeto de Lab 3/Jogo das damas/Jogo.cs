using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_das_damas
{
    class Jogo
    {
        public enum Modo_Jogo { X1, BOT, ONLINE };

        public Jogador Jogador1 { get; set; }
        public Jogador Jogador2 { get; set; }
        public int Vez { get; set; }
        public int Num_Jogada { get; set; }
        public Modo_Jogo Modo { get; set; }
       
    }
}
