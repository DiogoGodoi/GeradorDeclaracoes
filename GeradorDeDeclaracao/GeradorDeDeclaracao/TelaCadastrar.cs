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
    public partial class frmCadastrar : Form
    {
        private int cracha;
        private string nome;
        private string setor;
        private string cargo;
        public frmCadastrar()
        {
            InitializeComponent();
        }

        private void radTI_CheckedChanged(object sender, EventArgs e)
        {
            txtSetor.Text = "TI";
        }

        private void radSolda_CheckedChanged(object sender, EventArgs e)
        {
            txtSetor.Text = "SOLDA";
        }

        private void radSegTrab_CheckedChanged(object sender, EventArgs e)
        {
            txtSetor.Text = "SEGURANÇA DO TRABALHO";
        }

        private void radRh_CheckedChanged(object sender, EventArgs e)
        {
            txtSetor.Text = "RECURSOS HUMANOS";
        }

        private void radQualidade_CheckedChanged(object sender, EventArgs e)
        {
            txtSetor.Text = "QUALIDADE";
        }

        private void radProducao_CheckedChanged(object sender, EventArgs e)
        {
            txtSetor.Text = "PRODUÇÃO";
        }

        private void radOxicorte_CheckedChanged(object sender, EventArgs e)
        {
            txtSetor.Text = "OXICORTE";
        }

        private void radManutencao_CheckedChanged(object sender, EventArgs e)
        {
            txtSetor.Text = "MANUTENÇÃO";
        }

        private void radLogisitica_CheckedChanged(object sender, EventArgs e)
        {
            txtSetor.Text = "LOGISTICA";
        }

        private void radLixadeira_CheckedChanged(object sender, EventArgs e)
        {
            txtSetor.Text = "LIXADEIRA";
        }

        private void radLamincacao_CheckedChanged(object sender, EventArgs e)
        {
            txtSetor.Text = "LAMINAÇÃO";
        }

        private void radHigiene_CheckedChanged(object sender, EventArgs e)
        {
            txtSetor.Text = "HIGIENE";
        }

        private void radForjaria_CheckedChanged(object sender, EventArgs e)
        {
            txtSetor.Text = "FORJARIA";
        }

        private void radFiscal_CheckedChanged(object sender, EventArgs e)
        {
            txtSetor.Text = "FISCAL";
        }

        private void radFinanceiro_CheckedChanged(object sender, EventArgs e)
        {
            txtSetor.Text = "FINANCEIRO";
        }

        private void radExpedicao_CheckedChanged(object sender, EventArgs e)
        {
            txtSetor.Text = "EXPEDIÇÃO";
        }

        private void radEstamparia_CheckedChanged(object sender, EventArgs e)
        {
            txtSetor.Text = "ESTAMPARIA DE COLHER";
        }

        private void radComercial_CheckedChanged(object sender, EventArgs e)
        {
            txtSetor.Text = "COMERCIAL";
        }

        private void radAcab_CheckedChanged(object sender, EventArgs e)
        {
            txtSetor.Text = "ACABAMENTO GERAL";
        }

        private void radAlmox_CheckedChanged(object sender, EventArgs e)
        {
            txtSetor.Text = "ALMOXARIFADO";
        }

        private void radTornMec_CheckedChanged(object sender, EventArgs e)
        {
            txtCargo.Text = "TORNEIRO MECÂNICO";
        }

        private void radTecSeg_CheckedChanged(object sender, EventArgs e)
        {
            txtCargo.Text = "TÉCNICO DE SEGURANÇA DO TRABALHO";
        }

        private void radServGerais_CheckedChanged(object sender, EventArgs e)
        {
            txtCargo.Text = "SERVIÇOS GERAIS";
        }

        private void radOpSoldaMig_CheckedChanged(object sender, EventArgs e)
        {
            txtCargo.Text = "OPERADOR DE SOLDA MIG";
        }

        private void radOpEmpilhadeira_CheckedChanged(object sender, EventArgs e)
        {
            txtCargo.Text = "OPERADOR DE EMPILHADEIRA";
        }

        private void radOpProdIII_CheckedChanged(object sender, EventArgs e)
        {
            txtCargo.Text = "OPERADOR DE PRODUÇÃO III";
        }

        private void radOpProdII_CheckedChanged(object sender, EventArgs e)
        {
            txtCargo.Text = "OPERADOR DE PRODUÇÃO II";
        }

        private void radOpProdI_CheckedChanged(object sender, EventArgs e)
        {
            txtCargo.Text = "OPERADOR DE PRODUÇÃO I";
        }

        private void radMotorista_CheckedChanged(object sender, EventArgs e)
        {
            txtCargo.Text = "MOTORISTA";
        }

        private void radMecSoldador_CheckedChanged(object sender, EventArgs e)
        {
            txtCargo.Text = "MECÂNICO SOLDADOR";
        }

        private void radMecMan_CheckedChanged(object sender, EventArgs e)
        {
            txtCargo.Text = "MECÂNICO DE MANUTENÇÃO";
        }

        private void radLiderProdII_CheckedChanged(object sender, EventArgs e)
        {
            txtCargo.Text = "LIDER DE PRODUÇÃO II";
        }

        private void radLiderProdI_CheckedChanged(object sender, EventArgs e)
        {
            txtCargo.Text = "LIDER DE PRODUÇÃO I";
        }

        private void radJardineiro_CheckedChanged(object sender, EventArgs e)
        {
            txtCargo.Text = "JARDINEIRO";
        }

        private void radInspetQualid_CheckedChanged(object sender, EventArgs e)
        {
            txtCargo.Text = "INSPETORA DE QUALIDADE";
        }

        private void radGerProd_CheckedChanged(object sender, EventArgs e)
        {
            txtCargo.Text = "GERENTE DE PRODUÇÃO";
        }

        private void radEncarProdII_CheckedChanged(object sender, EventArgs e)
        {
            txtCargo.Text = "ENCARREGADO DE PRODUÇÃO II";
        }

        private void radEncarProdI_CheckedChanged(object sender, EventArgs e)
        {
            txtCargo.Text = "ENCARREGADO DE PRODUÇÃO I";
        }

        private void radElectMec_CheckedChanged(object sender, EventArgs e)
        {
            txtCargo.Text = "ELETROMECÂNICO";
        }

        private void radCordRH_CheckedChanged(object sender, EventArgs e)
        {
            txtCargo.Text = "COORDENADOR(A) DE RECURSOS HUMANOS";
        }

        private void radAuxMec_CheckedChanged(object sender, EventArgs e)
        {
            txtCargo.Text = "AUXILIAR DE MECÂNICO";
        }

        private void radAuxLimpeza_CheckedChanged(object sender, EventArgs e)
        {
            txtCargo.Text = "AUXILIAR DE LIMPEZA";
        }

        private void radAuxExp_CheckedChanged(object sender, EventArgs e)
        {
            txtCargo.Text = "AUXILIAR DE EXPEDIÇÃO";
        }

        private void radAssistRecFiscal_CheckedChanged(object sender, EventArgs e)
        {
            txtCargo.Text = "ASSISTENTE DE RECEBIMENTO FISCAL";
        }

        private void radAssistFiscal_CheckedChanged(object sender, EventArgs e)
        {
            txtCargo.Text = "ASSISTENTE FISCAL";
        }

        private void radAssistTi_CheckedChanged(object sender, EventArgs e)
        {
            txtCargo.Text = "ASSISTENTE DE TI";
        }

        private void radAssistExp_CheckedChanged(object sender, EventArgs e)
        {
            txtCargo.Text = "ASSISTENTE DE EXPEDIÇÃO";
        }

        private void radAssistComer_CheckedChanged(object sender, EventArgs e)
        {
            txtCargo.Text = "ASSISTENTE COMERCIAL";
        }

        private void radAssisLog_CheckedChanged(object sender, EventArgs e)
        {
            txtCargo.Text = "ASSISTENTE DE LOGISTICA";
        }

        private void radAprendizMec_CheckedChanged(object sender, EventArgs e)
        {
            txtCargo.Text = "APRENDIZ DE MECÂNICO";
        }

        private void radApontador_CheckedChanged(object sender, EventArgs e)
        {
            txtCargo.Text = "APONTADOR DE PRODUÇÃO";
        }

        private void radAdsFinanceiro_CheckedChanged(object sender, EventArgs e)
        {
            txtCargo.Text = "ANALISTA FINANCEIRO";
        }

        private void radAdsLogistica_CheckedChanged(object sender, EventArgs e)
        {
            txtCargo.Text = "ANALISTA DE EXPEDIÇÃO";
        }

        private void radAdsComercial_CheckedChanged(object sender, EventArgs e)
        {
            txtCargo.Text = "ANALISTA COMERCIAL";
        }

        private void radAlmoxarife_CheckedChanged(object sender, EventArgs e)
        {
            txtCargo.Text = "ALMOXARIFE";
        }

        private void radAjMotorista_CheckedChanged(object sender, EventArgs e)
        {
            txtCargo.Text = "AJUDANTE DE MOTORISTAO";
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

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {

                cracha = Convert.ToInt32(txtCracha.Text);
                nome = txtNome.Text;
                setor = txtSetor.Text;
                cargo = txtCargo.Text;

                mdlFuncionario mdlFuncionario = new mdlFuncionario(cracha, nome.ToUpper(), setor, cargo);
                DataTable retorno = controlador.insert(mdlFuncionario);
                if (retorno == null)
                {
                    txtCracha.Text = String.Empty;
                    txtNome.Text = String.Empty;
                    txtSetor.Text = String.Empty;
                    txtCargo.Text = String.Empty;
                    txtCracha.Focus();
                    MessageBox.Show("Cadastrado com sucesso", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    txtCracha.Text = String.Empty;
                    txtNome.Text = String.Empty;
                    txtSetor.Text = String.Empty;
                    txtCargo.Text = String.Empty;
                    txtCracha.Focus();
                    MessageBox.Show("Erro", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                throw;
            }

        }
        private void frmCadastrar_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }

}
