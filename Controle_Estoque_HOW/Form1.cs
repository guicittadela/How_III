using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Controle_Estoque_HOW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rdbtnalfabetico_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnapagar_Click(object sender, EventArgs e)
        {
            txtcor.Clear();
            txtproduto.Clear();
            txttamanho1.Clear();

        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            string strCon = @"server=localhost;user id=root;database=controledeestoque;SslMode=none";
            MySqlConnection cn = new MySqlConnection(strCon);
            cn.Open(); //abre a conexão
            MySqlCommand comm = new MySqlCommand();
            comm.Connection = cn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "insert into curso values (0, '" + txtproduto.Text +
                "'," + txtcor.Text + " ," + txtsexo1 + " , " + txttamanho1.Text + ", default)";
            comm.ExecuteNonQuery();
            comm.Connection.Close();//fecha a conexão
            MessageBox.Show("Produto inserido com sucesso!");
        }
    }
}
