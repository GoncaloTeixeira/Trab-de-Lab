using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Jogo_das_damas
{
    class Tabuleiro
    {
        public char[,] Mat_Tabuleiro { get; set; }

        public Tabuleiro()
        {
            Mat_Tabuleiro = new char[8, 8];
        }
    }
}


//if(jog1 is bot)