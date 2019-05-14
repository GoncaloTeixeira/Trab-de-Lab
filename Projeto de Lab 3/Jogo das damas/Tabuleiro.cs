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
            Mat_Tabuleiro = new char[7, 7];
            for(int i = 0; i< 8; i++)
            {
                for (int j = 0; i < 8; j++)
                {
                    
                    if (i % 2 == 0)
                    {
                        if (j % 2 == 0)
                        {
                            if (i <= 2)
                            {
                                Mat_Tabuleiro[i, j] = 'P';//Pretas
                            }else if (i > 5)
                            {
                                Mat_Tabuleiro[i, j] = 'B';//Brancas
                            }
                            else
                            {
                                Mat_Tabuleiro[i, j] = 'V';//Vacuo Vazias
                            }                          
                        }
                    }else if ( j % 2 ==1)
                    {
                        if (i <= 2)
                        {
                            Mat_Tabuleiro[i, j] = 'P';//Pretas
                        }
                        else if (i > 5)
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
