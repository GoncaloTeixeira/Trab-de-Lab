using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Jogo_das_damas
{
    class ControllerJogo : ViewJogo
    {



        //PictureBox selecionado;
        //PictureBox selecionado = new PictureBox();

        public ControllerJogo()
        {
            Program.V_Jogo.PedidoMoverPeca += V_Jogo_PedidoMoverPeca;
            
            Program.V_Jogo.EnviarPeca += V_Jogo_EnviarPeca;
            Program.V_Jogo.Iniciar += V_Jogo_Iniciar;
        }

        private void V_Jogo_PedidoMoverPeca(Point atual, Point proximo,char cor)
        {
            Program.M_Jogo.MoverPeca(atual, proximo,cor);
        }

        private void V_Jogo_Iniciar()
        {
            Program.M_Jogo.Iniciar();
        }

        private void V_Jogo_EnviarPeca(List<PictureBox> Pecas)
        {
            
        }

       

    }
}
