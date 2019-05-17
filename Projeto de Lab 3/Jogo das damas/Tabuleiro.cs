using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Jogo_das_damas
{
    public class Tabuleiro
    {
        public char[,] Mat_Tabuleiro { get; set; }

        public Tabuleiro()
        {
            Mat_Tabuleiro = new char[8, 8];
            for(int i =0; i< 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    
                    if (i % 2 == 0)
                    {
                        if (j % 2 == 0)
                        {
                            if (i <= 2)
                            {
                                Mat_Tabuleiro[i, j] = 'P';//Pretas
                            }else if (i >=5)
                            {
                                Mat_Tabuleiro[i, j] = 'B';//Brancas
                            }
                            else
                            {
                                Mat_Tabuleiro[i, j] = 'V';//Vacuo Vazias
                            }                          
                        }
                    }
                    if ( j % 2 ==1 && i%2==1)
                    {
                        if (i <= 2)
                        {
                            Mat_Tabuleiro[i, j] = 'P';//Pretas
                        }
                        else if (i >= 5)
                        {
                            Mat_Tabuleiro[i, j] = 'B';//Brancas
                        }
                        else
                        {
                            Mat_Tabuleiro[i, j] = 'V';//Vacuo Vazias
                        }
                    }


                }

            }

        }
        public void VerificarJogada(Point atual,Point proximo,char cor)
        {
            int avanceY = proximo.Y - atual.Y;
            int avanceX = proximo.X - atual.X;
            avanceX = Math.Abs(avanceX);
            avanceY = Math.Abs(avanceY);


            if (cor == 'B')
            {
                avanceY = avanceY * -1;
            }
            if (avanceY == 1 && avanceX == 1)
            {
                if (Mat_Tabuleiro[proximo.X, proximo.Y] == 'V')
                {
                    Mat_Tabuleiro[atual.X, atual.Y] = 'V';
                    Mat_Tabuleiro[proximo.X, proximo.Y] = cor;

                }
            }
            if (avanceY == 2 && avanceX == 2)
            {
                if (Mat_Tabuleiro[proximo.X, proximo.Y] == 'V')
                {
                    if (Mat_Tabuleiro[(atual.X + proximo.X) / 2, (atual.Y + proximo.Y) / 2] != 'V' && Mat_Tabuleiro[(atual.X + proximo.X) / 2, (atual.Y + proximo.Y) / 2] != cor)
                    {
                        Mat_Tabuleiro[atual.X, atual.Y] = 'V';
                        Mat_Tabuleiro[(atual.X + proximo.X) / 2, (atual.Y + proximo.Y) / 2] = 'V';//peca comida
                        //remover das pecas do jogador
                        Mat_Tabuleiro[proximo.X, proximo.Y] = cor;
                    }
                }
            }





            else if (Mat_Tabuleiro[proximo.X, proximo.Y] == 'B' || (Mat_Tabuleiro[proximo.X, proximo.Y] == 'P'))
            {
                return ;
            }
            
        }



        public void Desenhar(List<PictureBox> ListaP, List<PictureBox> ListaB,PictureBox CasaP)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (Mat_Tabuleiro[i, j] == 'P')
                    {
                        CasaP.Location = new Point(85 + j * 50, 30 + i * 50);
                    }






                }
            }







        }









    }










}
