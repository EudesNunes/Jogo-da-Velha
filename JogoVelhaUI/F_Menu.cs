using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoVelhaUI
{
    public partial class F_Menu : Form
    {
        public F_Menu()
        {
            InitializeComponent();
        }
        //==========================================================
        private void btn_novo_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new Interface().ShowDialog();
            this.Close();
        }

        //----------------------------

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
        //========================================================
    }
}
