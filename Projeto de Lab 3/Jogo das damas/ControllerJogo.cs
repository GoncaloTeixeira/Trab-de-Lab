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

            Program.V_Jogo.MoverPeca += V_Jogo_MoverPeca;
            Program.V_Jogo.Selecionar += V_Jogo_Selecionar;
            Program.V_Jogo.EnviarPeca += V_Jogo_EnviarPeca;
            Program.V_Jogo.Iniciar += V_Jogo_Iniciar;
        }

        private void V_Jogo_Iniciar()
        {
            Program.M_Jogo.Iniciar();
        }

        private void V_Jogo_EnviarPeca(List<PictureBox> Pecas)
        {
            
        }

        private void V_Jogo_Selecionar(object objeto)
        {

            Program.M_Jogo.SelecionarPeca(objeto);

        }

        private void V_Jogo_MoverPeca(PictureBox casa)
        {
            Program.M_Jogo.Mover_Peca(casa);
        }
    }
}
