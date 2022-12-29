using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using Funcionario;
using System.Data.Entity;
using System.Security.Cryptography;


namespace FuncionarioDAO
{
    public class daoFuncionario
    {
        private static int cracha { get; set; }
        private static string nome { get; set; }
        private static string setor { get; set; }
        private static string cargo { get; set; }
        public static int getCracha()
        {
            return cracha;
        }
        public static string getNome()
        {
            return nome;
        }
        public static string getSetor()
        {
            return setor;
        }
        public static string getCargo()
        {
            return cargo;
        }
        public static DataTable insert(mdlFuncionario funcionario)
        {
            string acessDB = @"Persist Security Info=False; server=localhost;database=declaracoes;uid=root;pwd=T21nfr@--";
            MySqlConnection conn = new MySqlConnection(acessDB);
            try
            {
                    string query = "INSERT INTO Funcionario (cracha, nome, setor, cargo) VALUES (@cracha, @nome, @setor, @cargo)";
                    MySqlCommand comando = new MySqlCommand(query, conn);
                    comando.Parameters.AddWithValue("@cracha", funcionario.getCracha());
                    comando.Parameters.AddWithValue("@nome", funcionario.getNome());
                    comando.Parameters.AddWithValue("@setor", funcionario.getSetor());
                    comando.Parameters.AddWithValue("@cargo", funcionario.getCargo());
                    comando.CommandType = CommandType.Text;
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                    DataTable tabela = new DataTable();
                    tabela = new DataTable();
                    adaptador.Fill(tabela);
                    conn.Open();
                    comando.ExecuteNonQuery();
                    conn.Close();
                    return tabela;
            }
            catch
            {
                conn.Close();
                return null;
                throw;
            }
            finally
            {
                conn.Close();
            }
        }
        public static bool alter(mdlFuncionario funcionario)
        {

            string acessDB = @"Persist Security Info=False; server=localhost;database=declaracoes;uid=root;pwd=T21nfr@--";
            MySqlConnection conn = new MySqlConnection(acessDB);
           
                    conn.Open();
                    string query = "UPDATE Funcionario SET cracha = @cracha, nome = @nome, setor = @setor, cargo = @cargo WHERE cracha LIKE @pCracha";
                    MySqlCommand comando = new MySqlCommand(query, conn);
                    comando.Parameters.AddWithValue("@cracha", funcionario.getCracha());
                    comando.Parameters.AddWithValue("@nome", funcionario.getNome());
                    comando.Parameters.AddWithValue("@setor", funcionario.getSetor());
                    comando.Parameters.AddWithValue("@cargo", funcionario.getCargo());
                    comando.Parameters.AddWithValue("@pCracha", funcionario.getCracha());
                    comando.ExecuteNonQuery();
                    conn.Close();
                
                return true;
         
        }
        public static DataTable read()
        {
            string acessDB = @"Persist Security Info=False; server=localhost;database=declaracoes;uid=root;pwd=T21nfr@--";
            MySqlConnection conn = new MySqlConnection(acessDB);
            try
            {
                conn.Open();
                string query = "SELECT cracha, nome FROM Funcionario";
                MySqlCommand comando = new MySqlCommand(query, conn);
                comando.CommandType = CommandType.Text;
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                DataTable tabela = new DataTable();
                adaptador.Fill(tabela);
                var leitura = comando.ExecuteReader();
                if (leitura.Read() == true)
                {
                    cracha = Convert.ToInt32(leitura["cracha"]);
                    nome = leitura["nome"].ToString();
                    conn.Close();
                    return tabela;
                }
                else
                {
                    conn.Close();
                    return null;
                }
            }
            catch
            {
                conn.Close();
                return null;
                throw;
            }
            finally
            {
                conn.Close();
            }
        }
        public static bool delete(string pNome)
        {
            string acessDB = @"Persist Security Info=False; server=localhost;database=declaracoes;uid=root;pwd=T21nfr@--";
            MySqlConnection conn = new MySqlConnection(acessDB);
            try
            {
                    conn.Open();
                    string query = "DELETE FROM Funcionario WHERE nome = @nome";
                    MySqlCommand comando = new MySqlCommand(query, conn);
                    comando.Parameters.AddWithValue("@nome", pNome);
                    comando.ExecuteNonQuery();
                    conn.Close();
                    return true;
            }
            catch
            {
                conn.Close();
                return false;
                throw;
            }
            finally
            {
                conn.Close();
            }
        }
        public static bool search(int pCracha)
        {

            string acessDB = @"Persist Security Info=False; server=localhost;database=declaracoes;uid=root;pwd=T21nfr@--";
            MySqlConnection conn = new MySqlConnection(acessDB);
            try
            {
                conn.Open();
                string query = "SELECT * FROM Funcionario WHERE cracha = @cracha";
                MySqlCommand comando = new MySqlCommand(query, conn);
                comando.Parameters.AddWithValue("@cracha", pCracha);
                comando.CommandType = CommandType.Text;
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                DataTable tabela = new DataTable();
                adaptador.Fill(tabela);
                var leitura = comando.ExecuteReader();
                if (leitura.Read() == true)
                {
                    cracha = Convert.ToInt32(leitura["cracha"]);
                    nome = leitura["nome"].ToString();
                    setor = leitura["setor"].ToString();
                    cargo = leitura["cargo"].ToString();
                    conn.Close();
                    return true;
                }
                else
                {
                    conn.Close();
                    return false;
                }
            }
            catch
            {
                conn.Close();
                return false;
                throw;
            }
            finally
            {
                conn.Close();
            }
        }
        public static bool searchName(string pNome)
        {
            string acessDB = @"Persist Security Info=False; server=localhost;database=declaracoes;uid=root;pwd=T21nfr@--";
            MySqlConnection conn = new MySqlConnection(acessDB);
            try
            {
                conn.Open();
                string query = "SELECT * FROM Funcionario WHERE nome = @nome";
                MySqlCommand comando = new MySqlCommand(query, conn);
                comando.Parameters.AddWithValue("@nome", pNome);
                comando.CommandType = CommandType.Text;
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                DataTable tabela = new DataTable();
                adaptador.Fill(tabela);
                var leitura = comando.ExecuteReader();
                if (leitura.Read() == true)
                {
                    cracha = Convert.ToInt32(leitura["cracha"]);
                    nome = leitura["nome"].ToString();
                    setor = leitura["setor"].ToString();
                    cargo = leitura["cargo"].ToString();
                    conn.Close();
                    return true;
                }
                else
                {
                    conn.Close();
                    return false;
                }
            }
            catch
            {
                conn.Close();
                return false;
                throw;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
