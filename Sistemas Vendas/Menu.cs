using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sistemas_Vendas
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://gmail.com/");

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Catc form = new Catc();
                form.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult sair = MessageBox.Show("DESEJA REALMENTE SAIR DO SISTEMA?, CONFIRMAR A SAIDA?", "FAVOR CONFIRMAR A SAIDA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sair== DialogResult.Yes)

            {
                Application.Exit();
            }
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Prod form = new Prod();
            form.Show();
        }


        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Caixa form = new Caixa();
            form.Show();
        }
    }
}
