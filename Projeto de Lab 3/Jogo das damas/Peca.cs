using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;



namespace Jogo_das_damas
{
    public class Peca
    {
        public Point Loc { get; set; }
        public bool Dama { get; set; }
        public PictureBox PBpeca=null;      

       
        public Peca()
        {
            Dama = false;

        }



       





    }
}
