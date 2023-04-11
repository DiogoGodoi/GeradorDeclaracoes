using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Dao;
using Controller;

namespace GeradorDeDeclaracao
{
    public partial class frmDeletar : Form
    {
        public string nome;
        public frmDeletar()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Thread _thread = new Thread(abrirJanelaCadastro);
            _thread.SetApartmentState(ApartmentState.STA);
            _thread.Start();
            this.Close();
        }

        public void abrirJanelaCadastro()
        {
            Application.Run(new frmCadastro());
        }

        private void frmDeletar_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            var dados = controlador.read();
            dtGridFuncionario.DataSource = dados;
        }

        private void dtGridFuncionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNome.Text = dtGridFuncionario.SelectedCells[0].Value.ToString();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            nome = txtNome.Text;

            bool retorno = controlador.delete(nome);

            if(retorno == true)
            {
                var dados = controlador.read();
                dtGridFuncionario.DataSource = dados;
                txtNome.Text = String.Empty;
                MessageBox.Show("Deletado com sucesso", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erro na exclusão", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
