using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using Usuario;

namespace UsuarioDAO
{
    public class daoUsuario
    {
        private static string nome { get; set; }
        private static string senha { get; set; }
        public static string getNome()
        {
            return nome;
        }
        public static string getSenha()
        {
            return senha;
        }
        public daoUsuario(string pNome, string pSenha)
        {
            nome = pNome;
            senha = pSenha;
        }
        public static bool Autenticar(mdlUsuario usuario)
        {
                var acessDB = new MySqlConnectionStringBuilder {
                    Server = "192.168.0.253",
                    UserID = nome,
                    Password = senha,
                    Database = "gerador",
                    Port = 4550,
                };

                MySqlConnection conn = new MySqlConnection(acessDB.ConnectionString);
            
            try
            {
                
                conn.Open();
                string query = "SELECT nome, senha FROM usuario WHERE nome = @nome";
                MySqlCommand comando = new MySqlCommand(query, conn);
                comando.Parameters.AddWithValue("@nome", usuario.getNome());
                var leitura = comando.ExecuteReader();
                
                if (leitura.Read() == true )
                {
                    if (leitura["nome"].ToString() == usuario.getNome() && leitura["senha"].ToString() == usuario.getSenha())
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
                return true;
            }
            catch
            {
                return false;
                throw;
            }
        }
    }
}
