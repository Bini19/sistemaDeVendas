﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistemas_Vendas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Value + 1;
            if (progressBar1.Value >= 100)
            {

                Login In = new Login();
                this.Hide();
                In.Show();


                timer1.Enabled = true;
                progressBar1.Visible = false;
                timer1.Enabled = false;
            }
        }
    }
}
