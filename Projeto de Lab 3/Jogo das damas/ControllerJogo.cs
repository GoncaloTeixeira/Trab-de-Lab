﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Jogo_das_damas
{
    public class ControllerJogo 
    {



        //PictureBox selecionado;
        //PictureBox selecionado = new PictureBox();

        public ControllerJogo()
        {
            Program.V_Jogo.PedidoMoverPeca += V_Jogo_PedidoMoverPeca;
            
            Program.V_Jogo.EnviarPeca += V_Jogo_EnviarPeca;
            Program.V_Jogo.Iniciar += V_Jogo_Iniciar;
            Program.V_Jogo.PedidoMoverDama += V_Jogo_PedidoMoverDama;
            //Program.V_Jogo.PedidoVerificarcomer += V_Jogo_PedidoVerificarcomer;
        }

        //private void V_Jogo_PedidoVerificarcomer()
        //{
        //    //Program.M_Jogo.verificarComer(jo);
        //}

        private void V_Jogo_PedidoMoverDama(Point atual, Point proximo, char cor)
        {
            Program.M_Jogo.MoverDama(atual, proximo, cor);
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
