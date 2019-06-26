using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Jogo_das_damas
{
    class Peca
    {
        public Point Loc { get; set; }
        public bool Dama { get; set; }

        public Peca()
        {
            Dama = false;
        }
    }
}
