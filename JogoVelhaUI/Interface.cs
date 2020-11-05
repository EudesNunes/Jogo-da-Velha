using System;
using System.Windows.Forms;
using JogoVelhaBLL;
using JogoVelhaDTO;

namespace JogoVelhaUI
{
    public partial class Interface : Form
    {
        BLL bll = new BLL();
        DTO dto = new DTO();
        
        
        public Interface()
        {
            InitializeComponent();
            dto.Vez = true;
        }
        //=================================================================
        //Acionar BTNs.

        private void Vez()
        {
            
            if (dto.Vez == true)
            {
                dto.Vez=false;
                pictureBox1.BackgroundImage = Properties.Resources.circulo;
                pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
              

            }
            else 
            {
               dto.Vez=true;
                pictureBox1.BackgroundImage = Properties.Resources.x;
                pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
              
            }
        }
        //-----------------
        private void Selecionar()
        {
            bll.Checar(dto);

           if(dto.VitoriaX==true)
            {
                MessageBox.Show("O X Ganhou");
                Mudar();
            }
            if (dto.VitoriaO == true)
            {
                MessageBox.Show("O Circulo Ganhou");
                Mudar();
            }
            if (dto.Numero1 != null && dto.Numero2 != null && dto.Numero3 != null && dto.Numero4 != null & dto.Numero5 != null && dto.Numero6 != null && dto.Numero7 != null && dto.Numero8 != null && dto.Numero9 != null)
            {
                MessageBox.Show("O Jogo deu Velha");
                Mudar();
            }
           
        }
        //-----------------
        private void Mudar()
        {

            btn_1.BackgroundImage = null;
            btn_2.BackgroundImage = null;
            btn_3.BackgroundImage = null;
            btn_4.BackgroundImage = null;
            btn_5.BackgroundImage = null;
            btn_6.BackgroundImage = null;
            btn_7.BackgroundImage = null;
            btn_8.BackgroundImage = null;
            btn_9.BackgroundImage = null;

            btn_1.Enabled = true;
            btn_2.Enabled = true;
            btn_3.Enabled = true;
            btn_4.Enabled = true;
            btn_5.Enabled = true;
            btn_6.Enabled = true;
            btn_7.Enabled = true;
            btn_8.Enabled = true;
            btn_9.Enabled = true;

            dto.Numero1 = null;
            dto.Numero2 = null;
            dto.Numero3 = null;
            dto.Numero4 = null;
            dto.Numero5 = null;
            dto.Numero6 = null;
            dto.Numero7 = null;
            dto.Numero8 = null;
            dto.Numero9 = null;

            dto.VitoriaO = false;
            dto.VitoriaX = false;
            
           
            dto.Vez = true;
            
                Vez();           
          
        }
        //==================================================================
         private void btn_1_Click(object sender, EventArgs e)
        {
            if (dto.Vez == true)
            {
                btn_1.BackgroundImage = Properties.Resources.x;
                btn_1.BackgroundImageLayout = ImageLayout.Zoom;

                dto.Numero1 = "M_X";
            }
            else if (dto.Vez == false)
            {
                btn_1.BackgroundImage = Properties.Resources.circulo;
                btn_1.BackgroundImageLayout = ImageLayout.Zoom;
                dto.Numero1 = "M_O";
            }


            btn_1.Enabled = false;
            Selecionar();
            Vez();
        }
        //-----------------
        private void btn_2_Click(object sender, EventArgs e)
        {
            if (dto.Vez == true)
            {
                btn_2.BackgroundImage = Properties.Resources.x;
                btn_2.BackgroundImageLayout = ImageLayout.Zoom;
                dto.Numero2 = "M_X";

            }
            else if (dto.Vez == false)
            {
                btn_2.BackgroundImage = Properties.Resources.circulo;
                btn_2.BackgroundImageLayout = ImageLayout.Zoom;
                dto.Numero2 = "M_O";

            }
            btn_2.Enabled = false;

            Selecionar();
            Vez();

        }
        //-----------------
        private void btn_3_Click(object sender, EventArgs e)
        {
            if (dto.Vez == true)
            {
                btn_3.BackgroundImage = Properties.Resources.x;
                btn_3.BackgroundImageLayout = ImageLayout.Zoom;
                dto.Numero3 = "M_X";

            }
            else if (dto.Vez == false)
            {
                btn_3.BackgroundImage = Properties.Resources.circulo;
                btn_3.BackgroundImageLayout = ImageLayout.Zoom;
                dto.Numero3 = "M_O";

            }
            btn_3.Enabled = false;
            Selecionar();
            Vez();

        }
        //-----------------
        private void btn_4_Click(object sender, EventArgs e)
        {
            if (dto.Vez == true)
            {
                btn_4.BackgroundImage = Properties.Resources.x;
                btn_4.BackgroundImageLayout = ImageLayout.Zoom;
                dto.Numero4 = "M_X";

            }
            else if (dto.Vez == false)
            {
                btn_4.BackgroundImage = Properties.Resources.circulo;
                btn_4.BackgroundImageLayout = ImageLayout.Zoom;
                dto.Numero4 = "M_O";

            }
            btn_4.Enabled = false;
            Selecionar();
            Vez();
        }
        //-----------------
        private void btn_5_Click(object sender, EventArgs e)
        {
            if (dto.Vez == true)
            {
                btn_5.BackgroundImage = Properties.Resources.x;
                btn_5.BackgroundImageLayout = ImageLayout.Zoom;
                dto.Numero5 = "M_X";

            }
            else if (dto.Vez == false)
            {
                btn_5.BackgroundImage = Properties.Resources.circulo;
                btn_5.BackgroundImageLayout = ImageLayout.Zoom;
                dto.Numero5 = "M_O";

            }
            btn_5.Enabled = false;
            Selecionar();
            Vez();

        }
        //-----------------
        private void btn_6_Click(object sender, EventArgs e)
        {
            if (dto.Vez == true)
            {
                btn_6.BackgroundImage = Properties.Resources.x;
                btn_6.BackgroundImageLayout = ImageLayout.Zoom;
                dto.Numero6 = "M_X";

            }
            else if (dto.Vez == false)
            {
                btn_6.BackgroundImage = Properties.Resources.circulo;
                btn_6.BackgroundImageLayout = ImageLayout.Zoom;
                dto.Numero6 = "M_O";

            }
            btn_6.Enabled = false;
            Selecionar();
            Vez();
        }
        //-----------------
        private void btn_7_Click(object sender, EventArgs e)
        {
            if (dto.Vez == true)
            {
                btn_7.BackgroundImage = Properties.Resources.x;
                btn_7.BackgroundImageLayout = ImageLayout.Zoom;
                dto.Numero7 = "M_X";

            }
            else if (dto.Vez == false)
            {
                btn_7.BackgroundImage = Properties.Resources.circulo;
                btn_7.BackgroundImageLayout = ImageLayout.Zoom;
                dto.Numero7 = "M_O";

            }
            btn_7.Enabled = false;
            Selecionar();
            Vez();

        }
        //-----------------
        private void btn_8_Click(object sender, EventArgs e)
        {
            if (dto.Vez == true)
            {
                btn_8.BackgroundImage = Properties.Resources.x;
                btn_8.BackgroundImageLayout = ImageLayout.Zoom;
                dto.Numero8 = "M_X";

            }
            else if (dto.Vez == false)
            {
                btn_8.BackgroundImage = Properties.Resources.circulo;
                btn_8.BackgroundImageLayout = ImageLayout.Zoom;
                dto.Numero8 = "M_O";

            }
            btn_8.Enabled = false;
            Selecionar();
            Vez();
        }
        //-----------------
        private void btn_9_Click(object sender, EventArgs e)
        {
            if (dto.Vez == true)
            {
                btn_9.BackgroundImage = Properties.Resources.x;
                btn_9.BackgroundImageLayout = ImageLayout.Zoom;
                dto.Numero9 = "M_X";

            }
            else if (dto.Vez == false)
            {
                btn_9.BackgroundImage = Properties.Resources.circulo;
                btn_9.BackgroundImageLayout = ImageLayout.Zoom;
                dto.Numero9 = "M_O";

            }
            btn_9.Enabled = false;
            Selecionar();
            Vez();

        }
        //============================================================

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mudar();
            
        }
        //-------------------
        private void Interface_Load(object sender, EventArgs e)
        {
            Mudar();

        }
        //--------------------
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
        //=======================================================================

    }
}
