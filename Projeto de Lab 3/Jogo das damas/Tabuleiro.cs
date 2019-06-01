using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Jogo_das_damas
{
    public class Tabuleiro : Peca
    {
        public Peca[,] Mat_Tabuleiro { get; set; }
        public Peca[,] CopiaMatriz { get; set; }
        public Peca Piece { get; set; }

        public Tabuleiro()
        {
            CopiaMatriz = new Peca[8, 8];
            Mat_Tabuleiro = new Peca[8, 8];
            Piece = new Peca();
            for (int i =0; i< 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    
                    if (i % 2 == 0)
                    {
                        if (j % 2 == 0)
                        {
                            if (j <= 2)
                            {
                                Piece = new Peca();
                                Piece.Cor = 'B';
                                Mat_Tabuleiro[i, j] = Piece;//Brancas
                            }else if (j >=5)
                            {
                                Piece = new Peca();
                                Piece.Cor = 'P';
                                Mat_Tabuleiro[i, j] = Piece;//Pretas
                            }
                            else
                            {
                                Piece = new Peca();
                                Piece.Cor = 'V';
                                Mat_Tabuleiro[i, j] = Piece;//Vacuo Vazias
                            }                          
                        }
                    }
                    if ( j % 2 ==1 && i%2==1)
                    {
                        if (j <= 2)
                        {
                            Piece = new Peca();
                            Piece.Cor = 'B';
                            Mat_Tabuleiro[i, j] = Piece;//Brancas
                        }
                        else if (j >= 5)
                        {
                            Piece = new Peca();
                            Piece.Cor = 'P';
                            Mat_Tabuleiro[i, j]= Piece;//Pretas
                        }
                        else
                        {
                            Piece = new Peca();
                            Piece.Cor = 'V';
                            Mat_Tabuleiro[i, j] =Piece;//Vacuo Vazias
                        }
                    }


                }

            }

        }


        public void EndBoard(Point Loc, char cor)
        {
            if (Loc.Y == 0 && cor == 'P')
            {
                Mat_Tabuleiro[Loc.X, Loc.Y].Dama = true;
            }
            else if (Loc.Y == 7 && cor == 'B')
            {
                Mat_Tabuleiro[Loc.X, Loc.Y].Dama = true;
            }           
        }



        public int VerificarJogada(Point atual, Point proximo, char cor)
        {
            int avanceY = proximo.Y - atual.Y;
            int avanceX = proximo.X - atual.X;
            avanceX = Math.Abs(avanceX);
            if (Mat_Tabuleiro[atual.X, atual.Y].Dama == true)
            {
                
            }

            if (cor == 'P' && (avanceY == -1 || avanceY == -2))
            {
                if (avanceY == -1)
                {
                    avanceY = 1;
                }
                else if (avanceY == -2)
                {
                    avanceY = 2;
                }
            }
            else if (cor == 'B' && (avanceY == 1 || avanceY == 2))
            {
                
                    avanceY = Math.Abs(avanceY);
                
            }
            else
            {
                return -1;
            }
         
        

            if (avanceY == 1 && avanceX == 1)
            {
                if (Mat_Tabuleiro[proximo.X, proximo.Y].Cor == 'V')
                {
                    Mat_Tabuleiro[atual.X, atual.Y].Cor = 'V';
                    Mat_Tabuleiro[proximo.X, proximo.Y].Cor = cor;
                    EndBoard(proximo, cor);
                }
                return 0;//mover peca sem comer
            }
            if (avanceY == 2 && avanceX == 2)
            {
                if (Mat_Tabuleiro[proximo.X, proximo.Y].Cor == 'V')
                {
                     
                    if (Mat_Tabuleiro[(atual.X + proximo.X) / 2, (atual.Y + proximo.Y) / 2].Cor != 'V' && Mat_Tabuleiro[(atual.X + proximo.X) / 2, (atual.Y + proximo.Y) / 2].Cor != cor)
                    {


                        Mat_Tabuleiro[atual.X, atual.Y].Cor = 'V';
                        Mat_Tabuleiro[(atual.X + proximo.X) / 2, (atual.Y + proximo.Y) / 2].Cor = 'V';//peca comida
                        //remover das pecas do jogador
                        Mat_Tabuleiro[proximo.X, proximo.Y].Cor = cor;
                        EndBoard(proximo, cor);
                        return 1;//mover peca com peca comida 
                    }       
                }
            }
            else if (Mat_Tabuleiro[proximo.X, proximo.Y].Cor == 'B' || (Mat_Tabuleiro[proximo.X, proximo.Y].Cor == 'P'))
            {
                return 3;//casa já ocupada
            }
            return -1;


        }

       

        public Peca[,] CopiarMatriz()
        {
            CopiaMatriz = Mat_Tabuleiro;
            return CopiaMatriz;
        }




        /*

        public int VerificarJogadaDama(Point atual, Point proximo, char cor)
        {
            int avanceY = proximo.Y - atual.Y;
            int avanceX = proximo.X - atual.X;
            //avanceX = Math.Abs(avanceX);
            //avanceY = Math.Abs(avanceY);
            int i = atual.X;
            int j = atual.Y;

            if (Math.Abs(avanceX) == Math.Abs(avanceY))
            {
                if (avanceX < 0)
                {
                    if (avanceY < 0)
                    {
                        for (i = atual.X; i > proximo.X; i--)
                        {
                            for (j = atual.Y; j > proximo.Y; j--)
                            {
                                if (i == j) {
                                    if (Mat_Tabuleiro[i, j].cor == cor)
                                    {
                                        return -1;
                                    } else if (Mat_Tabuleiro[i, j].cor != cor &&)
                                    {

                                    }
                                }
                            }
                        }


                        i = atual.X;
                        j = atual.Y;
                        while(proximo.X != i && proximo.Y != j)
                        {
                            if (Mat_Tabuleiro[i, j].cor == cor)
                            {
                                return -1;
                            }
                            i--; j--;
                        }
                        i = atual.X;
                        j = atual.Y;
                        while (proximo.X!=i && proximo.Y!=j)
                        {
                           
                            if (Mat_Tabuleiro[i, j].cor != cor && Mat_Tabuleiro[i-1, j-1].cor=='V')
                            {
                                Mat_Tabuleiro[i, j].cor = 'V';

                            }


                                i--;j--;
                        }













                    }


                }

             


            }

            return -1;//jogada invalida
        }



        public int VerificarTemDeComer()
        {
            int comer = 0;

            for(int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (CopiaMatriz[i,j].cor == 'P')
                    {
                        try
                        {
                            if((CopiaMatriz[i+1, j+1].cor=='B' && CopiaMatriz[i + 2, j + 2].cor == 'V') || (CopiaMatriz[i + 1, j -1 ].cor == 'B'|| CopiaMatriz[i + 2, j - 2].cor == 'V'))
                            {
                                CopiaMatriz 


                                //obrigado a comer uma 
                                comer++;
                                
                            }
                        }
                        catch
                        {

                        }
                    }
                }
            }





        }

        public int VerificarTemDeComer()
        {
            if 


        }










    */

    }










}
