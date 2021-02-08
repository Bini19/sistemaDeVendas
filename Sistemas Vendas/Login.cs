using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Sistemas_Vendas
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private static readonly MySqlConnection mySqlConnection = new MySqlConnection("server=localgost; database=sistemacsharp; username=root; password=;");
        MySqlConnection con = mySqlConnection;

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        
        }
        int count;
        private void button1_Click(object sender, EventArgs e)
        {
            string usuario, pass;

            usuario = txt_usuario.Text;
            pass = txt_senha.Text;

            count = count + 1;
            if (count > 3)
            {
                MessageBox.Show("FECHANDO SISTEMA", "SAINDO DO SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            else if (usuario=="" && pass=="")
            {
                label4.Text = "OS CAMPOS USUARIO E SENHA DEVEM SER PREENCHIDOS CORRETAMENTE";

            }
            else
            {
                string query = " select from Login where username = '" + usuario + "' && passoword='" + pass + "' ";
                MySqlDataAdapter data = new MySqlDataAdapter(query, con);
                DataTable dt = new DataTable();

                if (dt.Rows.Count == 1)

                {
                    Menu form = new Sistemas_Vendas.Menu();
                    this.Hide();
                    form.Show();

                }
                else
                {
                    label4.Text = "DADOS ERRADOS, TENTE NOVAMENTE";
                    txt_usuario.Clear();
                    txt_senha.Clear();
                    txt_usuario.Focus();
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult fechar = MessageBox.Show("VOCE TEM CERTEZA ?","FAVOR SALVAR DADOS DO SISTEMA",MessageBoxButtons.YesNo);
            if (fechar==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
