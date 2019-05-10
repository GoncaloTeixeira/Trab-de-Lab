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
    public partial class ViewRegras : Form
    {
        public ViewRegras()
        {
            InitializeComponent();
        }

        private void b_voltar_Click(object sender, EventArgs e)
        {
            Program.V_Menu.Show();
            this.Hide();
        }
    }
}
