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
    public partial class frmMenuDeclaracao : Form
    {
        public frmMenuDeclaracao()
        {
            InitializeComponent();
        }

        private void btnGerarJustificativaPonto_Click(object sender, EventArgs e)
        {
            Thread _thread = new Thread(abrirJanelaGerador);
            _thread.SetApartmentState(ApartmentState.STA);
            _thread.Start();
            this.Close();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Thread _thread = new Thread(abrirJanelaInicial);
            _thread.SetApartmentState(ApartmentState.STA);
            _thread.Start();
            this.Close();
        }

        public void abrirJanelaGerador()
        {
            Application.Run(new frmGerarDeclacarao());
        }

        public void abrirJanelaInicial()
        {
            Application.Run(new frmInicial());
        }

    }
}
