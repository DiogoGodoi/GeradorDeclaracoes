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
using Model;
using Dao;
using Controller;

namespace GeradorDeDeclaracao
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private void btnLogar_Click(object sender, EventArgs e)
        {
            string nome = txtUsuario.Text;
            string senha = txtPassword.Text;

           mdlUsuario usuario = new mdlUsuario(nome.ToUpper(), senha.ToUpper());
           
           new daoUsuario(nome.ToUpper(), senha.ToUpper());
           
           bool retorno = ctrlLogin.autenticar(usuario);

           if(retorno == false)
            {
                MessageBox.Show("Usuario inválido, verifique os dados", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else
            {
                Thread thread = new Thread(telaInicial);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
                this.Close();
            }            
        }
        private void telaInicial()
        {
            Application.Run(new frmInicial());
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
