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
    public partial class Form4 : Form
    {
        Model modelo = new Model();

        int  act = -1, count= 1;// -1 = DELETE     0 = INSERT    >0 = UPDATE

        private void DisableFields()
        {
            txtMatricula.Enabled = false;
            txtNomeProf.Enabled = false;
            txtComponente.Enabled = false;

            btnEditar2.Enabled = true;
            btnconfirmar.Enabled = true;
            btnEnviar2.Enabled = false;
        }

        public void EnableFields()
        {
            txtMatricula.Enabled = true;
            txtNomeProf.Enabled = true;
            txtComponente.Enabled = true;

            btnEditar2.Enabled = false;
            btnconfirmar.Enabled = false;
            btnEnviar2.Enabled = true;
        }

        public void CleanFields()
        {
            txtMatricula.Clear();
            txtNomeProf.Clear();
            txtComponente.Clear();
            txtMatricula.Focus();
        }

        public void LoadData(String sql)
        {
            if (sql == "")
            {
                sql = "Select * from tb02_professores_isolated ORDER BY tb02_prof_matricula ASC";
            }
            else
            {
                sql = "Select * from tb02_professores_isolated WHERE tb02_prof_nome LIKE '%" + txtPesquisa2.Text + "%' ORDER BY tb02_prof_matricula ASC";
            }
            MySqlDataReader Resultado = modelo.Consulta(sql);
            if (Resultado.HasRows)
            {
                dataGridView2.Rows.Clear();
                while (Resultado.Read())
                {
                    dataGridView2.Rows.Add(Resultado["tb02_prof_matricula"].ToString(), Resultado["tb02_prof_nome"].ToString(), Resultado["tb02_prof_componente"].ToString());
                }
            }
        }

        public Form4()
        {
            InitializeComponent();
            LoadData("");
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtRM_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir2_Click(object sender, EventArgs e)
        {


            if (count % 2 == 0)
            {
                pnDelete2.Visible = false;
                DisableFields();
                LoadData("");
                act = -1;

            }
            else
            {

                pnDelete2.Visible = true;
            }
            count++;
        }



        private void btnconfirmar_Click(object sender, EventArgs e)
        {
            if (tbMatricula.Text != "")
            {
                String sql = "DELETE FROM tb02_professores_isolated WHERE tb02_prof_matricula = '" + tbMatricula.Text + "'";
                modelo.NonQuery(sql);
                tbMatricula.Clear();
            }
            pnDelete2.Visible = false;
            LoadData("");
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pnDelete2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEnviar2_Click(object sender, EventArgs e)
        {
            String sql;
            if (act == 0)
            {
                sql = "INSERT INTO tb02_professores_isolated (tb02_prof_matricula, tb02_prof_nome, tb02_prof_componente) VALUES ('" + txtMatricula.Text + "', '" + txtNomeProf.Text + "', '" + txtComponente.Text + "')";
            }
            else
            {
                sql = "UPDATE tb02_professores_isolated SET tb02_prof_matricula = '" + tbMatricula.Text + "', tb02_prof_nome = '" + txtNomeProf.Text + "', tb02_prof_componente = '" + txtComponente.Text + "' WHERE  tb02_prof_matricula = " + act;
            }
            modelo.NonQuery(sql);
            LoadData("");
            CleanFields();
            DisableFields();
            act = -1;
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            txtMatricula.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            txtNomeProf.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            txtComponente.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnEditar2_Click(object sender, EventArgs e)
        {
            act = Convert.ToInt32(txtMatricula.Text);
            CleanFields();
            btnNovo2.Enabled = false;
            btnEnviar2.Enabled = true;
        }

        private void btnNovo2_Click(object sender, EventArgs e)
        {
            act = 0;
            CleanFields();
            EnableFields();
            btnEditar2.Enabled = false;
            btnEnviar2.Enabled = true;
            count++;
        }

        private void txtPesquisa2_TextChanged(object sender, EventArgs e)
        {
            LoadData(txtPesquisa2.Text);
        }
    }
}
