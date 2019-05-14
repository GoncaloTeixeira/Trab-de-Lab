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
        public event MetodoIniciarTabuleiro RespostaIniciar;
        Tabuleiro tab;
        public ModelJogo()
        {
            
        }
        public PictureBox selecionado;
        public Jogador Jogador1;
        public Jogador Jogador2;



        public void Iniciar()
        {
            Jogador1 = new Jogador();
            Jogador2 = new Jogador();
            //Enviar matriz 
            RespostaIniciar(tab,Jogador1,Jogador2);
        }

        public void SelecionarPeca(object objeto)
        {
            try { selecionado.BackColor = Color.Black; }
            catch { }
            PictureBox ficha = (PictureBox)objeto;
            selecionado = ficha;
            selecionado.BackColor = Color.Lime;
        }


        public void Mover_Peca(PictureBox casa)//casa picturebox nova localizaçao
        {
            bool movExtra;

            if (selecionado != null)
            {
                string color = selecionado.Name.ToString().Substring(0, 4);
                if (Ver_Movimento(selecionado,casa,color))
                //if (true)
                {
                    Point anterior = selecionado.Location;
                    selecionado.Location = casa.Location;
                    //int avance = anterior.Y - casa.Location.Y;
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

        private bool Ver_Movimento(PictureBox Origem, PictureBox Destino, string cor)
        {
            Point pontoOrigem = Origem.Location;
            Point pontoDestino = Destino.Location;
            int avance = pontoOrigem.Y - pontoDestino.Y;
            avance = cor == "Branca" ? avance : (avance * -1);

            if (avance == 50)
            {
                return true;
            }
            else if (avance == 100)
            {
                Point PontoMedio = new Point(Passo_inter(pontoDestino.X, pontoOrigem.X), Passo_inter(pontoDestino.Y, pontoOrigem.Y));
                Jogador2.List_Pecas = cor == "Branca" ? Jogador2.List_Pecas : Jogador1.List_Pecas;//pecas do oponente;
                for (int i = 0; i < Jogador2.List_Pecas.Count; i++)
                {
                    if (Jogador2.List_Pecas[i].Location == PontoMedio)
                    {
                        Jogador2.List_Pecas[i].Location = new Point(0, 0);
                        Jogador2.List_Pecas[i].Visible = false;
                        return true;
                    }
                }
            }
            return false;
        }


        public void IniciarCarregarPecas()
        {

        }

    }
}
    
