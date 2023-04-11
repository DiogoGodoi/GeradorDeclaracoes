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
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Thread _thread = new Thread(abrirJanelaInicial);
            _thread.SetApartmentState(ApartmentState.STA);
            _thread.Start();
            this.Close();
        }

        public void abrirJanelaInicial()
        {
            Application.Run(new frmInicial());
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Thread _thread = new Thread(abrirJanelaCadastrar);
            _thread.SetApartmentState(ApartmentState.STA);
            _thread.Start();
            this.Close();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Thread _thread = new Thread(abrirJanelaAlterar);
            _thread.SetApartmentState(ApartmentState.STA);
            _thread.Start();
            this.Close();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            Thread _thread = new Thread(abrirJanelaDeletar);
            _thread.SetApartmentState(ApartmentState.STA);
            _thread.Start();
            this.Close();
        }

        public void abrirJanelaCadastrar()
        {
            Application.Run(new frmCadastrar());
        }

        public void abrirJanelaAlterar()
        {
            Application.Run(new frmAlterar());
        }

        public void abrirJanelaDeletar()
        {
            Application.Run(new frmDeletar());
        }

        private void frmCadastro_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;   
        }
    }
}
