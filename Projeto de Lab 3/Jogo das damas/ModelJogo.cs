using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace Jogo_das_damas
{
    class ModelJogo
    {
        public ModelJogo()
        {
            
        }
        public PictureBox selecionado;
        public Jogador Jogador1;
        public JogadorBot Jogador2;


        public void SelecionarPeca(object objeto)
        {
            try { selecionado.BackColor = Color.Black; }
            catch { }
            PictureBox ficha = (PictureBox)objeto;
            selecionado = ficha;
            selecionado.BackColor = Color.Lime;
        }


        public void Mover_Peca(PictureBox casa)
        {
            bool movExtra;

            if (selecionado != null)
            {
                string color = selecionado.Name.ToString().Substring(0, 4);
                //if (Ver_Movimento(selecionado,casa,color))
                if (true)
                {
                    Point anterior = selecionado.Location;
                    selecionado.Location = casa.Location;
                    int avance = anterior.Y - casa.Location.Y;
                }
                if (true)//turnos extras no caso de poder comer outra peça de seguida
                {
                    selecionado.BackColor = Color.Black;
                    selecionado = null;
                    movExtra = false;
                }
                else
                {
                    movExtra = true;
                }
            }
        }


        public int Passo_inter(int n1, int n2)
        {
            int resultado = n1 + n2;
            resultado = resultado / 2;
            return Math.Abs(resultado);
        }

        public void IniciarCarregarPecas()
        {
            //Brancas
            Jogador1.List_Pecas.Add(Program.V_Jogo.Branca1);
            Jogador1.List_Pecas.Add(Program.V_Jogo.Branca2);
            Jogador1.List_Pecas.Add(Program.V_Jogo.Branca3);
            Jogador1.List_Pecas.Add(Program.V_Jogo.Branca4);
            Jogador1.List_Pecas.Add(Program.V_Jogo.Branca5);
            Jogador1.List_Pecas.Add(Program.V_Jogo.Branca6);
            Jogador1.List_Pecas.Add(Program.V_Jogo.Branca7);
            Jogador1.List_Pecas.Add(Program.V_Jogo.Branca8);
            Jogador1.List_Pecas.Add(Program.V_Jogo.Branca9);
            Jogador1.List_Pecas.Add(Program.V_Jogo.Branca10);
            Jogador1.List_Pecas.Add(Program.V_Jogo.Branca11);
            Jogador1.List_Pecas.Add(Program.V_Jogo.Branca12);
            //Pretas
            Pretas.Add(Preta1);
            Pretas.Add(Preta2);
            Pretas.Add(Preta3);
            Pretas.Add(Preta4);
            Pretas.Add(Preta5);
            Pretas.Add(Preta6);
            Pretas.Add(Preta7);
            Pretas.Add(Preta8);
            Pretas.Add(Preta9);
            Pretas.Add(Preta10);
            Pretas.Add(Preta11);
            Pretas.Add(Preta12);
        }
























    }
}
    
