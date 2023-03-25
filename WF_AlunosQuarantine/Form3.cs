using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;


namespace WF_AlunosQuarantine
{
    public partial class Form3 : Form
    {
        Model modelo = new Model(); //instancia ou objeto; nesse caso, o Model() é uma classe

        int count = 1, act = -1;// -1 = DELETE     0 = INSERT    >0 = UPDATE

        private void DisableFields()
        {
            txtRM.Enabled = false;
            txtNome.Enabled = false;
            txtGrito.Enabled = false;
            txtTurma.Enabled = false;
            
            btnEditar.Enabled = true;
            btnNovo.Enabled = true;
            btnEnviar.Enabled = false;
        }

        public void EnableFields()
        {
            txtGrito.Enabled = true;
            txtRM.Enabled = true;
            txtNome.Enabled = true;
            txtTurma.Enabled = true;

            btnEditar.Enabled = false;
            btnNovo.Enabled = false;
            btnEnviar.Enabled = true;
        }

        public void CleanFields()
        {
            txtGrito.Clear();
            txtRM.Clear();
            txtNome.Clear();
            txtTurma.Clear();
            txtRM.Focus();
        }

        public void LoadData(String sql)
        {
            if (sql == "")
            {
                sql = "Select * from tb01_aluno_isolated ORDER BY tb01_aluno_rm ASC";
            }
            else
            {
                sql = "Select * from tb01_aluno_isolated WHERE tb01_aluno_nome LIKE '%" + txtPesquisa.Text + "%' ORDER BY tb01_aluno_rm ASC";
            }
  
            MySqlDataReader Resultado = modelo.Consulta(sql);
            if (Resultado.HasRows)
            {
                dataGridView.Rows.Clear();
                while (Resultado.Read())
                {
                    dataGridView.Rows.Add(Resultado["tb01_aluno_rm"].ToString(), Resultado["tb01_aluno_nome"].ToString(), Resultado["tb01_aluno_turma"].ToString(), Resultado["tb01_aluno_grito"].ToString());
                }
            }
        }

        public Form3()
        {
            InitializeComponent();
            LoadData("");
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String sql;

           
            if (act == 0)
            {
                sql = "INSERT INTO tb01_aluno_isolated(tb01_aluno_rm, tb01_aluno_nome, tb01_aluno_grito, tb01_aluno_turma) VALUES('" + txtRM.Text + "', '" + txtNome.Text + "', '" + txtGrito.Text + "', '" + txtTurma.Text + "')";
            }
            else
            {
                sql = "UPDATE tb01_aluno_isolated SET tb01_aluno_rm = '" + txtRM.Text + "', tb01_aluno_turma = '" + txtTurma.Text + "', tb01_aluno_nome = '" + txtNome.Text + "', tb01_aluno_grito = '" + txtGrito.Text + "' WHERE  tb01_aluno_rm = " + act;
            }
            modelo.NonQuery(sql);
            LoadData("");
            CleanFields();
            DisableFields();
            act = -1;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            

                if (count % 2 == 0)
                {
                    pnDelete.Visible = false;
                DisableFields();
                LoadData("");
                act = -1;

            }
                else {

                    pnDelete.Visible = true;
            }
            count++;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (tbRM.Text != "")
            {
                String sql = "DELETE FROM tb01_aluno_isolated WHERE tb01_aluno_rm='" + tbRM.Text + "'";
                modelo.NonQuery(sql);
                tbRM.Clear();
            }
            LoadData("");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void lbPesquisar_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            txtRM.Text = dataGridView.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = dataGridView.CurrentRow.Cells[1].Value.ToString();
            txtTurma.Text = dataGridView.CurrentRow.Cells[2].Value.ToString();
            txtGrito.Text = dataGridView.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            CleanFields();
            EnableFields();
            btnEnviar.Enabled = true;
            btnEditar.Enabled = false;
            count++;
            act = 0;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            act = Convert.ToInt32(txtRM.Text);           
            EnableFields();
            btnEnviar.Enabled = true;
            btnNovo.Enabled = false;
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            LoadData(txtPesquisa.Text);
        }
    }
}
