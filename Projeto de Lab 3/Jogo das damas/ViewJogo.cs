﻿using System;
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
        public event MetodoComUmPictureBox MoverPeca;
        public event MetodoComUmObject Selecionar;
        public event MetodoComDoisInteiros IniciarVer; //iniciar verificaçao
        public event MetodoEnviaPeca EnviarPeca;

        public ViewJogo()
        {
            InitializeComponent();
            //jogo1.CarregarPecas();
            
        }
        
        public List<PictureBox> Brancas = new List<PictureBox>();
        public List<PictureBox> Pretas = new List<PictureBox>();
        
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




        /*
           PictureBox selecionado = null;

        public void Selecionar(object objeto)
        {
            try { selecionado.BackColor = Color.Black; }
            catch { }
            PictureBox ficha = (PictureBox)objeto;
            selecionado = ficha;
            selecionado.BackColor = Color.Lime;

        }
        */
        /*
        public void MoverPeca(PictureBox casa)
        {
            bool movExtra;

            if (selecionado != null)
            {
                string color = selecionado.Name.ToString().Substring(0, 4);
                //if (Ver_Movimento(selecionado,casa,color))
                if(true)
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

      
        private bool Ver_Movimento(PictureBox Origem,PictureBox Destino, string cor)
        {
            Point pontoOrigem = Origem.Location;
            Point pontoDestino = Destino.Location;
            int avance = pontoOrigem.Y - pontoDestino.Y;
            avance = cor == "Branca" ? avance :(avance*-1);
            
            if(avance == 50)
            {
                return true;
            }
            else if(avance==100){
                Point PontoMedio = new Point(Passo_inter(pontoDestino.X, pontoOrigem.X), Passo_inter(pontoDestino.Y, pontoOrigem.Y));
                List<PictureBox> PecasOponente = cor == "Branca" ? Pretas : Brancas;
                for(int i=0; i < PecasOponente.Count; i++)
                {
                    if (PecasOponente[i].Location == PontoMedio)
                    {
                        PecasOponente[i].Location = new Point(0, 0);
                        PecasOponente[i].Visible = false;
                        return true;
                    }
                }
            }
            return false;
        }















        private void Form1_Load(object sender, EventArgs e)
        {
            CarregarPecas();
            if (EnviarPeca != null)  
                EnviarPeca(Brancas);
            if (EnviarPeca != null)
                EnviarPeca(Pretas);
        }

        private void ClickCasa(object sender, MouseEventArgs e)
        {
            if (MoverPeca != null)
                MoverPeca((PictureBox)sender);


        }
        private void ClickBranca(object sender, MouseEventArgs e)
        {
            //Selecionar(sender);

           if (Selecionar != null)
                Selecionar((PictureBox)sender);
        }
      
        private void ClickPreta(object sender, MouseEventArgs e)
        {
            
            if(Selecionar != null)
                Selecionar((PictureBox)sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.V_Menu.Show();
            this.Hide();
        }
    }
}