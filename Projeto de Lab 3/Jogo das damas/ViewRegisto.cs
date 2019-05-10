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
    public partial class ViewRegisto : Form
    {
        public ViewRegisto()
        {
            InitializeComponent();
        }

        private void b_resgistar_Click(object sender, EventArgs e)
        {
            Program.V_Login.Show();
            this.Hide();
        }

        private void b_cancelar_Click(object sender, EventArgs e)
        {
            Program.V_Login.Show();
            this.Hide();
        }
    }
}
