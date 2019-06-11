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
        public Point proximo1 { get; set; }


        public Tabuleiro()
        {
            CopiaMatriz = new Peca[8, 8];
            Mat_Tabuleiro = new Peca[8, 8];
            Piece = new Peca();
            for (int i = 0; i < 8; i++)
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
                            } else if (j >= 5)
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
                    if (j % 2 == 1 && i % 2 == 1)
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
            int aux;
            int avanceY = proximo.Y - atual.Y;
            int avanceX = proximo.X - atual.X;
            avanceX = Math.Abs(avanceX);



                    if (Mat_Tabuleiro[atual.X, atual.Y].Dama == true)
                    {
                        aux = VerificarJogadaDama(atual, proximo, cor);
                        return aux;
                    }

                    if (cor == 'P' && (avanceY == -1 || avanceY == -2))
                    {
                        avanceY = Math.Abs(avanceY);
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
                                    return 0;//mover peca sem comer
                                }

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










        


        public int VerificarJogadaDama(Point atual, Point proximo, char cor)
        {
            int avanceY = proximo.Y - atual.Y;
            int avanceX = proximo.X - atual.X;


            if ((Math.Abs(avanceX)) == (Math.Abs(avanceY))){


                return 0;
            }




            if (avanceY == 1 && avanceX == 1)
            {
                if (Mat_Tabuleiro[proximo.X, proximo.Y].Cor == 'V')
                {
                    if (Mat_Tabuleiro[proximo.X, proximo.Y].Cor == 'V') { 
                        Mat_Tabuleiro[atual.X, atual.Y].Cor = 'V';
                        Mat_Tabuleiro[atual.X, atual.Y].Dama= false;
                        Mat_Tabuleiro[proximo.X, proximo.Y].Cor = cor;
                        Mat_Tabuleiro[proximo.X, proximo.Y].Dama = true;
                        EndBoard(proximo, cor);
                        return 0;//mover peca sem comer

                    }
                }
            }
            return 2;
        //    if (avanceY == -1 && avanceX == -1)
        //    {
        //        if (Mat_Tabuleiro[proximo.X, proximo.Y].Cor == 'V')
        //        {
        //            Mat_Tabuleiro[atual.X, atual.Y].Cor = 'V';
        //            Mat_Tabuleiro[atual.X, atual.Y].Dama = false;
        //            Mat_Tabuleiro[proximo.X, proximo.Y].Cor = cor;
        //            Mat_Tabuleiro[proximo.X, proximo.Y].Dama = true;
        //            return 0;//mover peca sem comer
        //        }

        //    }
        //    if (avanceY == 1 && avanceX == -1)
        //    {
        //        if (Mat_Tabuleiro[proximo.X, proximo.Y].Cor == 'V')
        //        {
        //            Mat_Tabuleiro[atual.X, atual.Y].Cor = 'V';
        //            Mat_Tabuleiro[atual.X, atual.Y].Dama = false;
        //            Mat_Tabuleiro[proximo.X, proximo.Y].Cor = cor;
        //            Mat_Tabuleiro[proximo.X, proximo.Y].Dama = true;
        //            EndBoard(proximo, cor);
        //            return 0;//mover peca sem comer
        //        }

        //    }
        //    if (avanceY == -1 && avanceX == 1)
        //    {
        //        if (Mat_Tabuleiro[proximo.X, proximo.Y].Cor == 'V')
        //        {
        //            Mat_Tabuleiro[atual.X, atual.Y].Cor = 'V';
        //            Mat_Tabuleiro[atual.X, atual.Y].Dama = false;
        //            Mat_Tabuleiro[proximo.X, proximo.Y].Cor = cor;
        //            Mat_Tabuleiro[proximo.X, proximo.Y].Dama = true;
        //            return 0;//mover peca sem comer
        //        }

        //    }


        //    if (avanceY == 2 && avanceX == 2)
        //    {
        //        if (Mat_Tabuleiro[proximo.X, proximo.Y].Cor == 'V')
        //        {

        //            if (Mat_Tabuleiro[(atual.X + proximo.X) / 2, (atual.Y + proximo.Y) / 2].Cor != 'V' && Mat_Tabuleiro[(atual.X + proximo.X) / 2, (atual.Y + proximo.Y) / 2].Cor != cor)
        //            {

        //                Mat_Tabuleiro[atual.X, atual.Y].Dama = false;
        //                Mat_Tabuleiro[atual.X, atual.Y].Cor = 'V';
        //                Mat_Tabuleiro[(atual.X + proximo.X) / 2, (atual.Y + proximo.Y) / 2].Cor = 'V';//peca comida
        //                //remover das pecas do jogador
        //                Mat_Tabuleiro[proximo.X, proximo.Y].Cor = cor;
        //                Mat_Tabuleiro[proximo.X, proximo.Y].Dama = true;
        //                return 1;//mover peca com peca comida 
        //            }
        //        }
        //    }
        //    if (avanceY == -2 && avanceX == -2)
        //    {
        //        if (Mat_Tabuleiro[proximo.X, proximo.Y].Cor == 'V')
        //        {

        //            if (Mat_Tabuleiro[(atual.X + proximo.X) / 2, (atual.Y + proximo.Y) / 2].Cor != 'V' && Mat_Tabuleiro[(atual.X + proximo.X) / 2, (atual.Y + proximo.Y) / 2].Cor != cor)
        //            {

        //                Mat_Tabuleiro[atual.X, atual.Y].Dama = false;
        //                Mat_Tabuleiro[atual.X, atual.Y].Cor = 'V';
        //                Mat_Tabuleiro[(atual.X + proximo.X) / 2, (atual.Y + proximo.Y) / 2].Cor = 'V';//peca comida
        //                //remover das pecas do jogador
        //                Mat_Tabuleiro[proximo.X, proximo.Y].Cor = cor;
        //                Mat_Tabuleiro[proximo.X, proximo.Y].Dama = true;
        //                return 1;//mover peca com peca comida 
        //            }
        //        }
        //    }
        //    if (avanceY == 2 && avanceX == -2)
        //    {
        //        if (Mat_Tabuleiro[proximo.X, proximo.Y].Cor == 'V')
        //        {

        //            if (Mat_Tabuleiro[(atual.X + proximo.X) / 2, (atual.Y + proximo.Y) / 2].Cor != 'V' && Mat_Tabuleiro[(atual.X + proximo.X) / 2, (atual.Y + proximo.Y) / 2].Cor != cor)
        //            {

        //                Mat_Tabuleiro[atual.X, atual.Y].Dama = false;
        //                Mat_Tabuleiro[atual.X, atual.Y].Cor = 'V';
        //                Mat_Tabuleiro[(atual.X + proximo.X) / 2, (atual.Y + proximo.Y) / 2].Cor = 'V';//peca comida
        //                //remover das pecas do jogador
        //                Mat_Tabuleiro[proximo.X, proximo.Y].Cor = cor;
        //                Mat_Tabuleiro[proximo.X, proximo.Y].Dama = true;
        //                return 1;//mover peca com peca comida 
        //            }
        //        }
        //    }
        //    if (avanceY == -2 && avanceX == 2)
        //    {
        //        if (Mat_Tabuleiro[proximo.X, proximo.Y].Cor == 'V')
        //        {

        //            if (Mat_Tabuleiro[(atual.X + proximo.X) / 2, (atual.Y + proximo.Y) / 2].Cor != 'V' && Mat_Tabuleiro[(atual.X + proximo.X) / 2, (atual.Y + proximo.Y) / 2].Cor != cor)
        //            {

        //                Mat_Tabuleiro[atual.X, atual.Y].Dama = false;
        //                Mat_Tabuleiro[atual.X, atual.Y].Cor = 'V';
        //                Mat_Tabuleiro[(atual.X + proximo.X) / 2, (atual.Y + proximo.Y) / 2].Cor = 'V';//peca comida
        //                //remover das pecas do jogador
        //                Mat_Tabuleiro[proximo.X, proximo.Y].Cor = cor;
        //                Mat_Tabuleiro[proximo.X, proximo.Y].Dama = true;
        //                return 1;//mover peca com peca comida 
        //            }
        //        }
        //    }
        //    else if (Mat_Tabuleiro[proximo.X, proximo.Y].Cor == 'B' || (Mat_Tabuleiro[proximo.X, proximo.Y].Cor == 'P'))
        //    {
        //        return 3;//casa já ocupada
        //    }
        //    return -1;


        }
    }



      












    }











