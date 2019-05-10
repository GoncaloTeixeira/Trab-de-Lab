using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_das_damas
{

    public delegate void MetodoComUmPictureBox(PictureBox casa);
    public delegate void MetodoComUmObject(object objeto);
    public delegate void MetodoComDoisInteiros(int x, int y);
    public delegate void MetodoVerficarMovimento(PictureBox Origem, PictureBox Destino, string cor);
    public delegate void MetodoSemParametros();
    public delegate void MetodoEnviaPeca(List<PictureBox> Pecas);
}
