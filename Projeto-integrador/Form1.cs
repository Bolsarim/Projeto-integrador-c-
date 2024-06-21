using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_integrador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MySqlConnection conn = new MySqlConnection ("server=localhost;user=root;database=bd_projetointegrador;password=;");
            //MySqlCommand cmd = new MySqlCommand("INSERT INTO tb_produtos (tipo, produto, preco) VALUES (@tipo, @produto, @preco)", conn);

            
            cmd.Parameters.AddWithValue("@tipo", textBox1.Text);
            cmd.Parameters.AddWithValue("@produto", textBox2.Text);
            cmd.Parameters.AddWithValue("@preco", textBox3.Text);

            
            conn.Open();
            int rowsAffected = cmd.ExecuteNonQuery();
            conn.Close();

            
            if (rowsAffected > 0)
            {
                MessageBox.Show("Dados inseridos com sucesso");
            }
            else
            {
                MessageBox.Show("Falha ao inserir dados. ");
            }
        }
    }
}
