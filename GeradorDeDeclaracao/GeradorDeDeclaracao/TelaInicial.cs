using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeradorDeDeclaracao
{
    public partial class frmInicial : Form
    {
        public frmInicial()
        {
            InitializeComponent();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            Thread _thread = new Thread(abrirJanelaCadastro);
            _thread.SetApartmentState(ApartmentState.STA);
            _thread.Start();
            this.Close();
        }
        private void btnGerar_Click(object sender, EventArgs e)
        {
            Thread _thread = new Thread(abrirJanelaMenuDeclaracoes);
            _thread.SetApartmentState(ApartmentState.STA);
            _thread.Start();
            this.Close();
        }
        public void abrirJanelaCadastro()
        {
            Application.Run(new frmCadastro());
        }

        public void abrirJanelaMenuDeclaracoes()
        {
            Application.Run(new frmMenuDeclaracao());
        }

        private void pctMenuDeclaracao_Click(object sender, EventArgs e)
        {

        }
    }
}
