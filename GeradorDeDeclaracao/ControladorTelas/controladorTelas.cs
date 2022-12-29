using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControladorTelas
{
    public class controladorTelas
    {
        private static string tela { get;set; }

        public controladorTelas(string pTela) { 
        tela = pTela;
        }
        public static string getTela()
        {
            return tela;
        }
    }
}
