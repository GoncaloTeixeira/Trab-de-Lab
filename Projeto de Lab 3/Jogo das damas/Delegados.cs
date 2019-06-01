using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_das_damas
{

    public delegate void MetodoComUmPictureBox(PictureBox casa);
    public delegate void MetodoComUmObject(object objeto);
    public delegate void MetodoComDoisPoints(Point atual, Point proximo,char cor);
    public delegate void MetodoRespostaMoverPeca(Point atual, Point proximo, char cor,Point Comida);
    public delegate void MetodoRespostaMoverPecaSemComida(Point proximo, char cor);
    public delegate void MetodoVerficarMovimento(PictureBox Origem, PictureBox Destino, string cor);
    public delegate void MetodoSemParametros();
    public delegate void MetodoEnviaPeca(List<PictureBox> Pecas);
    public delegate void MetodoIniciarTabuleiro(Tabuleiro Tabu,Jogador J1,Jogador J2);

}
