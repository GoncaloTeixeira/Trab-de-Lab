using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


namespace Jogo_das_damas
{
     public class Jogador :Peca
    {
        public List<PictureBox> List_Pecas { get; set; }
        public List<PictureBox> List_Pecas_Com { get; set; }
        public string Nome { get; set; }
        public string Password { get; set; }
        public string Pais { get; set; }
        public string Email { get; set; }
        // data de nascimento
        public bool cor { get; set; }
        public Image Foto { get; set; }
        public int Num_Vitorias { get; set; }
        public int Num_Jogos { get; set; }
        public int Num_Derrotas{ get; set; }
        public int Num_Abandonos { get; set; }


        public Jogador()
        {
            List_Pecas = new List<PictureBox>();
            List_Pecas_Com = new List<PictureBox>();
        }
        
        



    }
}
