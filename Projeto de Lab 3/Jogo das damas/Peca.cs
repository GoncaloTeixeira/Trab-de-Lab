using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;




namespace Jogo_das_damas
{
    public class Peca
    {
        
        public bool Dama { get; set; }    
        public char Cor { get; set; }
       
        public Peca()
        {
            Cor = ' ';
            Dama = false;
        }
        public Peca(char cor2)
        {
            Cor = cor2;
        }


       





    }
}
