using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Dao;
using Controller;
using System.Data;

namespace Controller
{
    public class controlador
    {
        public static int getCracha()
        {
            return daoFuncionario.getCracha();
        }
        public static string getNome()
        {
            return daoFuncionario.getNome();
        }
        public static string getSetor()
        {
            return daoFuncionario.getSetor();
        }
        public static string getCargo()
        {
            return daoFuncionario.getCargo();
        }
        public static DataTable insert (mdlFuncionario funcionario)
        {
           return daoFuncionario.insert(funcionario);
        }
        public static bool alter(mdlFuncionario funcionario)
        {
            return daoFuncionario.alter(funcionario);
        }
        public static List<mdlFuncionario> read()
        {
            return daoFuncionario.read();
        }
        public static bool delete(string nome)
        {
            return daoFuncionario.delete(nome);
        }
        public static bool search(int cracha)
        {
            return daoFuncionario.search(cracha);
        }
        public static mdlFuncionario searchName(string nome)
        {
            return daoFuncionario.searchName(nome);
        }
    }
}
