using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_das_damas
{

   
    public partial class ViewJogo : Form
    {
        //internal static event MetodoComUmObjecEventHandler MetodoComUmObjec = delegate { };
       // public event MetodoComUmPictureBox MoverPeca;
        //public event MetodoComUmObject Selecionar;
        public event MetodoComDoisPoints PedidoMoverPeca; //iniciar verificaçao
        public event MetodoEnviaPeca EnviarPeca;
        public event MetodoSemParametros Iniciar;
        public event MetodoComDoisPoints PedidoMoverDama;
        public event MetodoSemParametros PedidoVerificarcomer;
        


        public List<PictureBox> Brancas = new List<PictureBox>();
        public List<PictureBox> Pretas = new List<PictureBox>();
        public Point f1;
        public Point f2;
        public PictureBox selecionado;
        public PictureBox selecionado1;
        public ViewJogo()
        {
            InitializeComponent();
            //jogo1.CarregarPecas();
            selecionado = new PictureBox();
            selecionado1 = new PictureBox();
            //Program.M_Jogo.RespostaIniciar += M_Jogo_RespostaIniciar;
            Program.M_Jogo.RespostaMoverPeca += M_Jogo_RespostaMoverPeca;
            Program.M_Jogo.RespostaMoverPecaSemComida += M_Jogo_RespostaMoverPecaSemComida;
            Program.M_Jogo.NotificaPecaASerJogada += M_Jogo_NotificaPecaASerJogada;
            Program.M_Jogo.NotificacaoTrocarVez += M_Jogo_NotificacaoTrocarVez;
            Program.M_Jogo.Resettabuleiro += M_Jogo_Resettabuleiro;
        }

        private void M_Jogo_Resettabuleiro()
        {
            for (int i = 0; i < 12; i++)
            {
                Brancas[i].BackColor = Color.Black;
                Brancas[i].Enabled = false;
            }
            for (int i = 0; i < 12; i++)
            {
                Pretas[i].BackColor = Color.Black;
                Pretas[i].Enabled = false;
            }
        }

        private void M_Jogo_NotificacaoTrocarVez(char cor)
        {
           if (cor == 'B')
            {
                for(int i = 0; i < 12; i++)
                {
                    Brancas[i].Enabled = true;
                    Pretas[i].Enabled = false;
                }

            }
            else
            {
                for (int i = 0; i < 12; i++)
                {
                    Brancas[i].Enabled = false;
                    Pretas[i].Enabled = true;
                }
            }
        }

        private void M_Jogo_NotificaPecaASerJogada(Point Ponto)
        {
            
            Ponto.X = 50 * Ponto.X + 85;
            Ponto.Y = 50 * Ponto.Y + 30;


           
            for (int i=0; i < 12; i++) { 
                  if (Ponto == Brancas[i].Location) {
                    
                    Brancas[i].BackColor = Color.BlueViolet;
                    Brancas[i].Enabled = true;
                  }
            }
            for (int i = 0; i < 12; i++)
            {
                if (Ponto == Pretas[i].Location)
                {

                    Pretas[i].BackColor = Color.BlueViolet;
                    Pretas[i].Enabled = true;
                }
            }


        }

        public void IfQueen(Point proximo, char cor)
        {
            if (proximo.Y == 30)
            {
                if (cor == 'P')
                {
                    selecionado.BackgroundImage = Properties.Resources.PretaQueen;
                    selecionado.Tag = "Dama";
                }
            }
            if (proximo.Y == 380)
            {
                if (cor == 'B')
                {
                    selecionado.BackgroundImage = Properties.Resources.BrancaQueen;
                    selecionado.Tag = "Dama";
                }
            }
        }

        private void M_Jogo_RespostaMoverPecaSemComida(Point proximo,char cor)
        {
            proximo.X = 50 * proximo.X + 85;
            proximo.Y = 50 * proximo.Y + 30;
           
            selecionado.Location = new Point(proximo.X, proximo.Y);
            IfQueen(proximo, cor);


            //Program.M_Jogo.verificarComer(Program.M_Jogo.Jogador1);
            //Program.M_Jogo.verificarComer(Program.M_Jogo.Jogador2);
        }

      
        private void M_Jogo_RespostaMoverPeca(Point atual, Point proximo, char cor, Point comida)
        {
            proximo.X = 50 * proximo.X + 85;
            proximo.Y = 50 * proximo.Y + 30;
            selecionado.Location = new Point(proximo.X,proximo.Y);
            comida.X = 50 * comida.X + 85;
            comida.Y = 50 * comida.Y + 30;

            //remover picturebox da lista 

            

            if (cor != 'B') {
                foreach (PictureBox peca in Brancas)
                {
                    if (peca.Location == new Point(comida.X, comida.Y))
                    {
                        peca.Hide();
                    }
                }

            }
            else
            {
               
            foreach(PictureBox peca in Pretas)
                {
                    if (peca.Location== new Point(comida.X, comida.Y))
                    {
                        peca.Hide();
                    }
                }

            }
            IfQueen(proximo, cor);

            //Program.M_Jogo.verificarComer(Program.M_Jogo.Jogador1);

        }

        //private void M_Jogo_RespostaIniciar(Tabuleiro Tabu, Jogador J1, Jogador J2)
        //{
        //    J1.List_Pecas = Brancas;
        //    J2.List_Pecas = Pretas;
        //}

       


        public void CarregarPecas()
        {
            //Brancas
            Brancas.Add(Branca1);
            Brancas.Add(Branca2);
            Brancas.Add(Branca3);
            Brancas.Add(Branca4);
            Brancas.Add(Branca5);
            Brancas.Add(Branca6);
            Brancas.Add(Branca7);
            Brancas.Add(Branca8);
            Brancas.Add(Branca9);
            Brancas.Add(Branca10);
            Brancas.Add(Branca11);
            Brancas.Add(Branca12);
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




        
           
        
        public void Selecionar(object objeto)
        {
           
            
            try {
                selecionado.BackColor = Color.Black; }
            catch { }
            PictureBox ficha = (PictureBox)objeto;
            selecionado = ficha;
            selecionado.BackColor = Color.Lime;

        }
        
        

        
                    













    private void Form1_Load(object sender, EventArgs e)
        {
            CarregarPecas();
            Iniciar();

            
        }

        private void ClickCasa(object sender, MouseEventArgs e)
        {
            
            f1 = selecionado.Location;
            
            f2 = ((PictureBox)sender).Location;

            f1.X = ((f1.X - 85) / 50);
            f1.Y = ((f1.Y - 30) / 50);

            f2.X = ((f2.X - 85) / 50);
            f2.Y = ((f2.Y - 30) / 50);

            string cor2 = selecionado.Name.ToString().Substring(0, 1);
            char cor = Convert.ToChar(cor2);

            //if (selecionado.Tag == "Dama")
            //{
            //    PedidoMoverDama(f1, f2, cor);
            //}
           
            PedidoMoverPeca(f1,f2,cor);
            


        }
        private void ClickBranca(object sender, MouseEventArgs e)
        {
                Selecionar((PictureBox)sender);
        }
      
        private void ClickPreta(object sender, MouseEventArgs e)
        {
                Selecionar((PictureBox)sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.V_Menu.Show();
            this.Hide();
        }

       
    }
}
