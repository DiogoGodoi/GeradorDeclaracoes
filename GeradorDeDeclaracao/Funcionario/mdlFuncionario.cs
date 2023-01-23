using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionario
{
    public class mdlFuncionario
    {
        private int cracha { get; set; }
        private string nome { get; set; }
        private string setor { get; set; }
        private string cargo { get; set; }

        public mdlFuncionario() { }
        public mdlFuncionario(int pCracha, string pNome, string pSetor, string pCargo)
        {
            cracha = pCracha;
            nome = pNome;   
            setor = pSetor; 
            cargo = pCargo;
        }
        public int getCracha()
        {
            return cracha;
        }
        public string getNome()
        {
            return nome;
        }
        public string getSetor()
        {
            return setor;
        }
        public string getCargo()
        {
            return cargo;
        }
        public int setCracha(int pCracha)
        {
            return cracha = pCracha;
        }
        public string setNome(string pNome)
        {
            return nome = pNome;
        }
        public string setSetor(string pSetor)
        {
            return setor = pSetor;
        }
        public string setCargo(string pCargo)
        {
            return cargo = pCargo;
        }
    }
}
