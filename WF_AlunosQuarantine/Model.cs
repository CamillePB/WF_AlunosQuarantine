using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace WF_AlunosQuarantine
{
    class Model
    {
        public void NonQuery(String sql)
        {
            try
            {
                MySqlConnection conectar = new MySqlConnection("server=localhost;database=bd_quarantine; Uid=root; pwd=;");
                conectar.Open();
                MySqlCommand ExecutaSQL = new MySqlCommand();
                ExecutaSQL.Connection = conectar;
                ExecutaSQL.CommandText = sql;
                ExecutaSQL.ExecuteNonQuery();
                conectar.Close();
                MessageBox.Show("Operação realizada com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro" + ex);
            }
        }
        public MySqlDataReader Consulta(String sql)
        {
            MySqlConnection conectar = new MySqlConnection("server=localhost;database=bd_quarantine; Uid=root; pwd=;");
            conectar.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = sql;
            comando.Connection = conectar;
            MySqlDataReader dados = comando.ExecuteReader();
            return dados;//guarda valores
        }
    }
}
