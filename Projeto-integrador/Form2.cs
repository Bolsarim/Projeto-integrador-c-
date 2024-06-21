using MySql.Data.MySqlClient;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
                      
               MySqlConnection conn = new MySqlConnection("server=localhost;user=root;database=bd_projetointegrador;password=;");
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM tb_produtos", conn);



            DataTable dt = new DataTable();
            conn.Open();



            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            conn.Close();


            dataGridView1.DataSource = dt;


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            {
                string pesquisa = textBox1.Text;
                MySqlConnection conn = new MySqlConnection("server=localhost;user=root;database=bd_pokemon;password=;");
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM tb_pokemon where nome like '%" + pesquisa + "%'", conn);


                
                DataTable dt = new DataTable();
                conn.Open();


                
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                conn.Close();

                
                dataGridView1.DataSource = dt;
            }

           
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            {
                Form fcadastro = new Form2();
                fcadastro.Show();
            }
        }
    }
    }
}
