using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Sistemas_Vendas
{
    public partial class Caixa : Form
    {
        public Caixa()
        {
            InitializeComponent();
        }
        int precototal = 0;

        MySqlConnection con = new MySqlConnection("server=localhost;database=sistemadevendas; username=root;password=;");
        private string txtpronumero;

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtquantidade.Enabled = true;
                txtquantidade.Focus();

            }
        }

        private void txtquantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                try
                {
                    string txt = "select *from produtos where id='" + txtpronumero.Text + "'";
                    MySqlCommand cmd = new MySqlCommand(txtpronumero, con);

                    con.Open();
                    MySqlDataReader r = cmd.ExecuteReader();
                    while (r.Read())
                    {
                        int preco = int.Parse(txtquantidade.Text.ToString()) * int.Parse(r[4].ToString());
                        precototal = preco;

                        dataGridView1.Rows.Add(dataGridView1.RowCount, r[0], r[1], txtquantidade.Text.Trim(), r[4], preco);

                    }
                    lbltotalitens.Text = "" + (dataGridView1.RowCount - 1) + "";
                    lbltotal.Text = "" + precototal + "";

                    con.Close();
                }
                catch (Exception.ee)
                {
                    MessageBox.Show(ee.message, "ESTE E UM ERRO VINDO DO BANCO DE DADOS");

                }
                txtpronumero.Focus();
                txtpronumero.Clear();
                txtquantidade.Enabled = false;
                txtquantidade.Clear();

            }
        }
    }
}
