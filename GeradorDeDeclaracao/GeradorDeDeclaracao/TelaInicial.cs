using Controller;
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
        Form formAtivo = new Form();
        public frmInicial()
        {
            InitializeComponent();
        }
 
        private void frmInicial_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
        private void btnGerar_Click(object sender, EventArgs e)
        {
            
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            FecharForm();
            Form TelaDeCadastro = new frmCadastrar();
            formAtivo = TelaDeCadastro;
            formAtivo.TopLevel = false;
            PanelConteudo.Controls.Add(formAtivo);
            formAtivo.Show();
            formAtivo.BringToFront();
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            FecharForm();
            Form TelaDeAlteracao = new frmAlterar();
            formAtivo = TelaDeAlteracao;
            formAtivo.TopLevel = false;
            PanelConteudo.Controls.Add(formAtivo);
            formAtivo.Show();
            formAtivo.BringToFront();
        }
        private void btnExluir_Click(object sender, EventArgs e)
        {
            FecharForm();
            Form TelaDeExlusao = new frmDeletar();
            formAtivo = TelaDeExlusao;
            formAtivo.TopLevel = false;
            PanelConteudo.Controls.Add(formAtivo);
            formAtivo.Show();
            formAtivo.BringToFront();
        }
        private void FecharForm()
        {
            if (formAtivo != null)
            {
                formAtivo.Close();
            }
        }
        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            Thread _thread = new Thread(abrirJanelaLogin);
            _thread.SetApartmentState(ApartmentState.STA);
            _thread.Start();
            this.Close();
        }
        public void abrirJanelaLogin()
        {
            Application.Run(new frmLogin());
        }

        private void btnDeclaracoes_Click(object sender, EventArgs e)
        {
            FecharForm();
            new controladorTelas("1");
            Form telaDeclaracao = new frmGerarDeclacarao();
            formAtivo = telaDeclaracao;
            formAtivo.TopLevel = false;
            PanelConteudo.Controls.Add(formAtivo);
            formAtivo.Show();
            formAtivo.BringToFront();
        }

        private void btnAviso_Click(object sender, EventArgs e)
        {
            FecharForm();
            new controladorTelas("2");
            Form telaDeclaracao = new frmGerarDeclacarao();
            formAtivo = telaDeclaracao;
            formAtivo.TopLevel = false;
            PanelConteudo.Controls.Add(formAtivo);
            formAtivo.Show();
            formAtivo.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FecharForm();
            new controladorTelas("3");
            Form telaDeclaracao = new frmGerarDeclacarao();
            formAtivo = telaDeclaracao;
            formAtivo.TopLevel = false;
            PanelConteudo.Controls.Add(formAtivo);
            formAtivo.Show();
            formAtivo.BringToFront();
        }
    }
}
