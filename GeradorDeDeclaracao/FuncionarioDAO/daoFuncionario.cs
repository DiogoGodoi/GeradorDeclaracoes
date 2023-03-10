using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data;
using MySqlConnector;
using Funcionario;
using System.Data.Entity;
using System.Security.Cryptography;
using UsuarioDAO;

namespace FuncionarioDAO
{
    public class daoFuncionario
    {
        private static int cracha { get; set; }
        private static string nome { get; set; }
        private static string setor { get; set; }
        private static string cargo { get; set; }
        public static string user { get; set; }
        public static string password { get; set; }
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
        public static string getUser()
        {
            return user;
        }
        public static string getPassword()
        {
            return password;
        }
        public static DataTable insert(mdlFuncionario funcionario)
        {
            var db = new MySqlConnectionStringBuilder
            {
                Server = "192.168.0.253",
                UserID = daoUsuario.getNome(),
                Password = daoUsuario.getSenha(),
                Database = "gerador",
                Port = 4550,
            };
            MySqlConnection conn = new MySqlConnection(db.ConnectionString);

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
            var db = new MySqlConnectionStringBuilder
            {
                Server = "192.168.0.253",
                UserID = daoUsuario.getNome(),
                Password = daoUsuario.getSenha(),
                Database = "gerador",
                Port = 4550,
            };

            MySqlConnection conn = new MySqlConnection(db.ConnectionString);
           
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
        public static List<mdlFuncionario> read()
        {



        List<mdlFuncionario> lista = new List<mdlFuncionario>();

        var db = new MySqlConnectionStringBuilder
            {
                Server = "192.168.0.253",
                UserID = daoUsuario.getNome(),
                Password = daoUsuario.getSenha(),
                Database = "gerador",
                Port = 4550,
            };

            MySqlConnection conn = new MySqlConnection(db.ConnectionString);
            try
            {
                conn.Open();
                string query = "SELECT * FROM Funcionario ORDER BY nome ASC";
                MySqlCommand comando = new MySqlCommand(query, conn);
                comando.CommandType = CommandType.Text;
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                DataTable tabela = new DataTable();
                adaptador.Fill(tabela);
                var leitura = comando.ExecuteReader();;

                if (leitura.Read() == true)
                {
                    foreach (DataRow dados in tabela.Rows)
                    {
                        var pmtCracha = Convert.ToInt32(dados["cracha"]);
                        var pmtNome = dados["nome"].ToString();
                        var pmtSetor = dados["setor"].ToString();
                        var pmtCargo = dados["cargo"].ToString();
                        lista.Add(new mdlFuncionario(pmtCracha, pmtNome, pmtSetor, pmtCargo)); 
                    }
                        conn.Close();
                        return lista;
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
            var db = new MySqlConnectionStringBuilder
            {
                Server = "192.168.0.253",
                UserID = daoUsuario.getNome(),
                Password = daoUsuario.getSenha(),
                Database = "gerador",
                Port = 4550,
            };

            MySqlConnection conn = new MySqlConnection(db.ConnectionString);
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
            var db = new MySqlConnectionStringBuilder
            {
                Server = "192.168.0.253",
                UserID = daoUsuario.getNome(),
                Password = daoUsuario.getSenha(),
                Database = "gerador",
                Port = 4550,
            };

            MySqlConnection conn = new MySqlConnection(db.ConnectionString);
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
        public static mdlFuncionario searchName(string pNome)
        {

            mdlFuncionario funcionario = new mdlFuncionario();

            var db = new MySqlConnectionStringBuilder
            {
                Server = "192.168.0.253",
                UserID = "root",
                Password = "T21nfr@--",
                Database = "gerador",
                Port = 4550,
            };

            MySqlConnection conn = new MySqlConnection(db.ConnectionString);
            try
            {
                conn.Open();
                string query = "SELECT * FROM Funcionario WHERE nome LIKE @nome";
                MySqlCommand comando = new MySqlCommand(query, conn);
                comando.Parameters.AddWithValue("@nome", pNome + "%");
                comando.CommandType = CommandType.Text;
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                DataTable tabela = new DataTable();
                adaptador.Fill(tabela);
                var leitura = comando.ExecuteReader();
                if (leitura.Read() == true)
                {
                    foreach(DataRow dataRow in tabela.Rows)
                    {
                    cracha = Convert.ToInt32(dataRow["cracha"]);
                    nome = dataRow["nome"].ToString();
                    setor = dataRow["setor"].ToString();
                    cargo = dataRow["cargo"].ToString();
                    funcionario.setCracha(cracha);
                    funcionario.setNome(nome);
                    funcionario.setSetor(setor);
                    funcionario.setCargo(cargo);
                    }
                    conn.Close();
                    return funcionario;
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
    }
}
