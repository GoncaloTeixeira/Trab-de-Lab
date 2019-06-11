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
        Tabuleiro tab;
        Point comida;
        public event MetodoIniciarTabuleiro RespostaIniciar;
        public event MetodoRespostaMoverPeca RespostaMoverPeca;
        public event MetodoRespostaMoverPecaSemComida RespostaMoverPecaSemComida;
        public event MetodoEnviaPonto NotificaPecaASerJogada;
        public event MetodoComUmaCor NotificacaoTrocarVez;
        public event MetodoSemParametros Resettabuleiro;
        public ModelJogo()
        {
            //tab = new Tabuleiro();
            comida = new Point();
        }

        public Jogador Jogador1;
        public Jogador Jogador2;
        public Peca piece1;
        public Point Ponto;
        public List<Peca> List_VerLei { get; set; }
        public List<Peca> List_VerLei2 { get; set; }
        public int res;




        public void Iniciar()
        {
            tab = new Tabuleiro();
            Jogador1 = new Jogador();
            Jogador2 = new Jogador();
            Jogador1.Vez = true;
            Jogador1.Cor = 'B';
            Jogador2.Vez = false;
            Jogador2.Cor = 'P';

            //Enviar matriz 
            CarregarPecasParaCadaJogador();
            //RespostaIniciar(tab,Jogador1,Jogador2);
        }

        public void CarregarPecasParaCadaJogador()
        {
            Jogador1.List_Pecas.Clear();
            Jogador2.List_Pecas.Clear();
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    try
                    {
                        if (tab.Mat_Tabuleiro[i, j].Cor == 'B')
                        {
                            Ponto = new Point(i, j);
                            piece1 = new Peca('B', Ponto);
                            if (tab.Mat_Tabuleiro[i, j].Dama == true)
                                piece1.Dama = true;
                            Jogador1.List_Pecas.Add(piece1);
                        }
                        if (tab.Mat_Tabuleiro[i, j].Cor == 'P')
                        {
                            Ponto = new Point(i, j);
                            piece1 = new Peca('P', Ponto);
                            if (tab.Mat_Tabuleiro[i, j].Dama == true)
                                piece1.Dama = true;
                            Jogador2.List_Pecas.Add(piece1);
                        }
                    }
                    catch
                    {

                    }
                }
            }



        }

        public void MoverDama(Point atual, Point proximo, char cor)
        {

            if (Jogador1.Vez == true && Jogador1.Cor != cor)
            {
                return;
            }
            if (Jogador2.Vez == true && Jogador2.Cor != cor)
            {
                return;
            }
















        }

        public void TrocarVez()
        {
            CarregarPecasParaCadaJogador();

            if (Jogador1.Vez == true)
            {
                NotificacaoTrocarVez(Jogador2.Cor);//da enable nas pecas do jogador que envia como parametros
                Jogador2.Vez = true;


                Jogador1.Vez = false;

                verificarComer(Jogador2);
            }
            else
            {
                NotificacaoTrocarVez(Jogador1.Cor);
                Jogador1.Vez = true;

                Jogador2.Vez = false;
                verificarComer(Jogador1);
                
            }

        }






        public void MoverPeca(Point atual, Point proximo, char cor)
        {



            if (Jogador1.Vez == true && Jogador1.Cor != cor)
            {
                return;
            }
            if (Jogador2.Vez == true && Jogador2.Cor != cor)
            {
                return;
            }


            int aux = 0;
            if (Jogador1.Vez == true)
            if (Jogador2.Vez == true) { }
            


        


            int res = tab.VerificarJogada(atual, proximo, cor);
       
            if (res == 0)
            {
                RespostaMoverPecaSemComida(proximo, cor);
                TrocarVez();


            }
            else if (res == 1)
            {
                comida = new Point((atual.X + proximo.X) / 2, (atual.Y + proximo.Y) / 2);
                if (Jogador1.Vez == false)
                {
                    Jogador2.List_Pecas_Com.Add(new Peca(cor, comida));
                    foreach (Peca peca in Jogador1.List_Pecas)
                    {
                        if (peca.Loc == comida)
                        {
                            Jogador1.List_Pecas.Remove(peca);
                            TrocarVez();
                            RespostaMoverPeca(atual, proximo, cor, comida);

                            return;
                        }
                    }

                }
                else
                {
                    Jogador1.List_Pecas_Com.Add(new Peca(cor, comida));
                    foreach (Peca peca in Jogador2.List_Pecas)
                    {
                        if (peca.Loc == comida)
                        {
                            Jogador2.List_Pecas.Remove(peca);
                            TrocarVez();
                            RespostaMoverPeca(atual, proximo, cor, comida);

                            return;
                        }
                    }
                }
                //TrocarVez();
                //RespostaMoverPeca(atual, proximo, cor, comida);

            }


        }




        //        

        public void verificarComer(Jogador J)
        {

            if (J.Cor == 'B'||J.Dama==true)
            {

                foreach (Peca peca in J.List_Pecas)
                {
                    if (peca.Loc.Y >= 0 && peca.Loc.Y < 6)
                    {
                        if (peca.Loc.X < 6)
                        {
                            if ((tab.Mat_Tabuleiro[peca.Loc.X + 1, peca.Loc.Y + 1].Cor == 'P') && (tab.Mat_Tabuleiro[peca.Loc.X + 2, peca.Loc.Y + 2].Cor == 'V'))
                            {
                                
                                    Resettabuleiro();;
                                                          
                                NotificaPecaASerJogada(Ponto = new Point(peca.Loc.X, peca.Loc.Y));

                            }
                            if (peca.Loc.X > 1)
                            {

                                if ((tab.Mat_Tabuleiro[peca.Loc.X - 1, peca.Loc.Y + 1].Cor == 'P') && (tab.Mat_Tabuleiro[peca.Loc.X - 2, peca.Loc.Y + 2].Cor == 'V'))
                                {
                                  
                                        Resettabuleiro();;
                                    
                                    NotificaPecaASerJogada(Ponto = new Point(peca.Loc.X, peca.Loc.Y));
                                }
                            }
                        }
                    }


                }



            }
            else if (J.Cor == 'P' || J.Dama == true)
            {
                foreach (Peca peca in J.List_Pecas)
                {
                    if (peca.Loc.Y >= 0 && peca.Loc.Y < 6)
                    {
                        if (peca.Loc.X < 6)
                        {
                            if ((tab.Mat_Tabuleiro[peca.Loc.X + 1, peca.Loc.Y - 1].Cor == 'B') && (tab.Mat_Tabuleiro[peca.Loc.X + 2, peca.Loc.Y - 2].Cor == 'V'))
                            {
                               
                                NotificaPecaASerJogada(Ponto = new Point(peca.Loc.X, peca.Loc.Y));

                            }
                            if (peca.Loc.X > 1)
                            {
                                if ((tab.Mat_Tabuleiro[peca.Loc.X - 1, peca.Loc.Y - 1].Cor == 'B') && (tab.Mat_Tabuleiro[peca.Loc.X - 2, peca.Loc.Y - 2].Cor == 'V'))
                                {                              
                                    NotificaPecaASerJogada(Ponto = new Point(peca.Loc.X, peca.Loc.Y));
                                }
                            }
                        }
                    }



                }


            }




        }
    }
}






















/*
    public void MoverPeca(PictureBox casa)
    {
        bool movExtra;

        if (selecionado != null)
        {
            string color = selecionado.Name.ToString().Substring(0, 4);
            if (Ver_Movimento(selecionado,casa,color))

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
    //private bool movimentoExtra() funcao para comer mais que uma peca

    */
