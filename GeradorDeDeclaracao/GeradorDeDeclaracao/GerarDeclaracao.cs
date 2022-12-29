using Controlador;
using controladorDeclaracao;
using Funcionario;
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
using Microsoft.VisualBasic;
using ControladorTelas;

namespace GeradorDeDeclaracao
{
    public partial class frmGerarDeclacarao : Form
    {
        public int cracha;
        public string nome;
        public string setor;
        public string cargo;
        public string momento = "";
        public string data;
        public string horario;

        public List<mdlFuncionario> listaFuncionario = new List<mdlFuncionario>();
        public ListViewItem item;
        public frmGerarDeclacarao()
        {
            InitializeComponent();
        }  
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            nome = txtPesquisa.Text;
            var dados = controlador.searchName(nome);
            if(dados != null)
            {
            dtFuncionarios.DataSource = dados;
            }
        }  
        private void btnAdcionar_Click(object sender, EventArgs e)
        {
            cracha = Convert.ToInt32(txtCracha.Text);
            nome = txtNome.Text;
            setor = txtSetor.Text;
            cargo = txtCargo.Text;

            if (cracha.ToString() == String.Empty || nome == String.Empty || 
                setor == String.Empty || cargo == String.Empty || data == String.Empty || horario == String.Empty)
            {
                MessageBox.Show("Verifique se todos os dados estão preenchidos", "Erro !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                listaFuncionario.Add(new mdlFuncionario(cracha, nome, setor, cargo));

                foreach (var i in listaFuncionario)
                {
                    item = new ListViewItem(i.getCracha().ToString());
                    item.SubItems.Add(i.getNome());
                }

                listFuncionario.Items.Add(item);
            }
        }
        private void btnRemover_Click(object sender, EventArgs e)
        {
            var indice = listFuncionario.SelectedItems[0].Index;
            listaFuncionario.RemoveAt(indice);
            listFuncionario.SelectedItems[0].Remove();
        }
        private void btnGerar_Click_1(object sender, EventArgs e)
        {
            if(controladorTelas.getTela() == "1")
            {
                declaracaoPonto();
            }
            else if (controladorTelas.getTela() == "2")
            {
                declaracaoAviso("AVISO ANTECIPADO");
            }else if (controladorTelas.getTela() == "3")
            {
                declaracaoSaida("SAÍDA ANTECIPADA");
            }
        }
        private void btnGerarTudo_Click(object sender, EventArgs e)
        {
            if (controladorTelas.getTela() == "1")
            {
                declaracaoPontoTudo();
            }
            else if (controladorTelas.getTela() == "2")
            {
                declaracaoAvisoTudo("AVISO ANTECIPADO");
            }
            else if (controladorTelas.getTela() == "3")
            {
                declaracaoSaidaTudo("SAÍDA ANTECIPADA");
            }
        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Thread _thread = new Thread(abrirJanelaMenuDeclaracoes);
            _thread.SetApartmentState(ApartmentState.STA);
            _thread.Start();
            this.Close();
        }
        private void radRetornoAlmoco_CheckedChanged(object sender, EventArgs e)
        {
            momento = "no retorno do Almoço";
        }
        private void radSaidaExpediente_CheckedChanged(object sender, EventArgs e)
        {
            momento = "na saída do expediente";
        }
        private void radSaidaAlmoco_CheckedChanged(object sender, EventArgs e)
        {
            momento = "na saída para o Almoço";
        }
        private void radEntrada_CheckedChanged(object sender, EventArgs e)
        {
            momento = "na entrada do expediente";
        }
        private void radOutro_CheckedChanged(object sender, EventArgs e)
        {
            txtOutro.Enabled = true;
        }
        private void frmGerarDeclacarao_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            var dados = controlador.read();
            dtFuncionarios.DataSource = dados;
        }
        private void dtFuncionarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            nome = dtFuncionarios.SelectedCells[0].Value.ToString();
            var dados = controlador.searchName(nome);

            if (dados != null)
            {
                txtCracha.Text = controlador.getCracha().ToString();
                txtNome.Text = controlador.getNome();
                txtCargo.Text = controlador.getCargo();
                txtSetor.Text = controlador.getSetor();
            }
            else
            {
                MessageBox.Show("Sem dados");
            }
        }
        public void abrirJanelaMenuDeclaracoes()
        {
            Application.Run(new frmMenuDeclaracao());
        }
        private void declaracaoPonto()
        {
            try
            {
                if (txtNome.Text == String.Empty
                    || txtCracha.Text == String.Empty
                    || txtCargo.Text == String.Empty
                    || txtSetor.Text == String.Empty 
                    )
                {
                    MessageBox.Show("Verifique se todos os dados foram preenchidos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    data = Interaction.InputBox("Informe a data", "Informe");
                    horario = Interaction.InputBox("Informe a hora", "Hora");

                    if (data != "" && horario != "")
                    {
                        SaveFileDialog salvar = new SaveFileDialog();
                        salvar.Filter = ".PDF | .pdf";
                        salvar.FilterIndex = 2;
                        salvar.FileName = "Arquivo";

                        if (salvar.ShowDialog() == DialogResult.OK)
                        {
                            txtCracha.Text = String.Empty;
                            txtNome.Text = String.Empty;
                            txtSetor.Text = String.Empty;
                            txtCargo.Text = String.Empty;
                            listFuncionario.Items.Clear();
                            radEntrada.Checked = false;
                            radSaidaAlmoco.Checked = false;
                            radRetornoAlmoco.Checked = false;
                            radSaidaExpediente.Checked = false;
                            geradorDeclaracao.declaracaoPonto(listaFuncionario, salvar.FileName, momento.ToUpper(), data, horario);
                            MessageBox.Show("Arquivo Salvo", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                txtCracha.Text = String.Empty;
                txtNome.Text = String.Empty;
                txtSetor.Text = String.Empty;
                txtCargo.Text = String.Empty;
                radEntrada.Checked = false;
                radSaidaAlmoco.Checked = false;
                radRetornoAlmoco.Checked = false;
                radSaidaExpediente.Checked = false;
                listFuncionario.Items.Clear();
                MessageBox.Show("Existe um arquivo com o mesmo nome ja aberto", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void declaracaoPontoTudo()
        {
            try
            {
                txtNome.Text = String.Empty;
                txtCracha.Text = String.Empty;
                txtSetor.Text = String.Empty;
                txtCargo.Text = String.Empty;

                var dados = controlador.read();
                data = Interaction.InputBox("Informe a data", "Informe");
                horario = Interaction.InputBox("Informe a hora", "Hora");

                    if (data != "" && horario != "")
                    {
                        SaveFileDialog salvar = new SaveFileDialog();
                        salvar.Filter = ".PDF | .pdf";
                        salvar.FilterIndex = 2;
                        salvar.FileName = "Arquivo";

                        if (salvar.ShowDialog() == DialogResult.OK)
                        {
                            txtCracha.Text = String.Empty;
                            txtNome.Text = String.Empty;
                            txtSetor.Text = String.Empty;
                            txtCargo.Text = String.Empty;
                            radEntrada.Checked = false;
                            radSaidaAlmoco.Checked = false;
                            radRetornoAlmoco.Checked = false;
                            radSaidaExpediente.Checked = false;
                            listFuncionario.Items.Clear();
                            geradorDeclaracao.declaracaoPontoTudo(dados, salvar.FileName, momento.ToUpper(), data, horario);
                            MessageBox.Show("Arquivo Salvo", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                
            }
            catch (Exception ex)
            {
                txtCracha.Text = String.Empty;
                txtNome.Text = String.Empty;
                txtSetor.Text = String.Empty;
                txtCargo.Text = String.Empty;
                radEntrada.Checked = false;
                radSaidaAlmoco.Checked = false;
                radRetornoAlmoco.Checked = false;
                radSaidaExpediente.Checked = false;
                listFuncionario.Items.Clear();
                MessageBox.Show("Existe um arquivo com o mesmo nome ja aberto", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void declaracaoAviso(string titulo)
        {
            try
            {
                if (txtNome.Text == String.Empty
                    || txtCracha.Text == String.Empty
                    || txtCargo.Text == String.Empty
                    || txtSetor.Text == String.Empty
                    )
                {
                    MessageBox.Show("Verifique se todos os dados foram preenchidos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    momento = txtOutro.Text;
                    data = Interaction.InputBox("Informe a data", "Informe");
                    horario = Interaction.InputBox("Informe a hora", "Hora");

                    if (data != "" && horario != "")
                    {
                        SaveFileDialog salvar = new SaveFileDialog();
                        salvar.Filter = ".PDF | .pdf";
                        salvar.FilterIndex = 2;
                        salvar.FileName = "Arquivo";

                        if (salvar.ShowDialog() == DialogResult.OK)
                        {
                            txtCracha.Text = String.Empty;
                            txtNome.Text = String.Empty;
                            txtSetor.Text = String.Empty;
                            txtCargo.Text = String.Empty;
                            listFuncionario.Items.Clear();
                            radEntrada.Checked = false;
                            radSaidaAlmoco.Checked = false;
                            radRetornoAlmoco.Checked = false;
                            radSaidaExpediente.Checked = false;
                            geradorDeclaracao.declaracaoAntecipada(listaFuncionario, salvar.FileName, titulo, momento.ToUpper(), data, horario);
                            MessageBox.Show("Arquivo Salvo", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                txtCracha.Text = String.Empty;
                txtNome.Text = String.Empty;
                txtSetor.Text = String.Empty;
                txtCargo.Text = String.Empty;
                radEntrada.Checked = false;
                radSaidaAlmoco.Checked = false;
                radRetornoAlmoco.Checked = false;
                radSaidaExpediente.Checked = false;
                listFuncionario.Items.Clear();
                MessageBox.Show("Existe um arquivo com o mesmo nome ja aberto"+ ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void declaracaoAvisoTudo(string titulo)
        {
            try
            {
                txtNome.Text = String.Empty;
                txtCracha.Text = String.Empty;
                txtSetor.Text = String.Empty;
                txtCargo.Text = String.Empty;

                var dados = controlador.read();
                momento = txtOutro.Text;
                data = Interaction.InputBox("Informe a data", "Informe");
                horario = Interaction.InputBox("Informe a hora", "Hora");

                if (data != "" && horario != "")
                {
                    SaveFileDialog salvar = new SaveFileDialog();
                    salvar.Filter = ".PDF | .pdf";
                    salvar.FilterIndex = 2;
                    salvar.FileName = "Arquivo";

                    if (salvar.ShowDialog() == DialogResult.OK)
                    {
                        txtCracha.Text = String.Empty;
                        txtNome.Text = String.Empty;
                        txtSetor.Text = String.Empty;
                        txtCargo.Text = String.Empty;
                        radEntrada.Checked = false;
                        radSaidaAlmoco.Checked = false;
                        radRetornoAlmoco.Checked = false;
                        radSaidaExpediente.Checked = false;
                        listFuncionario.Items.Clear();
                        geradorDeclaracao.declaracaoAntecipadaTudo(dados, salvar.FileName, titulo, momento.ToUpper(), data, horario);
                        MessageBox.Show("Arquivo Salvo", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
            catch (Exception ex)
            {
                txtCracha.Text = String.Empty;
                txtNome.Text = String.Empty;
                txtSetor.Text = String.Empty;
                txtCargo.Text = String.Empty;
                radEntrada.Checked = false;
                radSaidaAlmoco.Checked = false;
                radRetornoAlmoco.Checked = false;
                radSaidaExpediente.Checked = false;
                listFuncionario.Items.Clear();
                MessageBox.Show("Existe um arquivo com o mesmo nome ja aberto", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void declaracaoSaida(string titulo)
        {
            try
            {
                if (txtNome.Text == String.Empty
                    || txtCracha.Text == String.Empty
                    || txtCargo.Text == String.Empty
                    || txtSetor.Text == String.Empty
                    )
                {
                    MessageBox.Show("Verifique se todos os dados foram preenchidos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    momento = txtOutro.Text;
                    data = Interaction.InputBox("Informe a data", "Informe");
                    horario = Interaction.InputBox("Informe a hora", "Hora");

                    if (data != "" && horario != "")
                    {
                        SaveFileDialog salvar = new SaveFileDialog();
                        salvar.Filter = ".PDF | .pdf";
                        salvar.FilterIndex = 2;
                        salvar.FileName = "Arquivo";

                        if (salvar.ShowDialog() == DialogResult.OK)
                        {
                            txtCracha.Text = String.Empty;
                            txtNome.Text = String.Empty;
                            txtSetor.Text = String.Empty;
                            txtCargo.Text = String.Empty;
                            listFuncionario.Items.Clear();
                            radEntrada.Checked = false;
                            radSaidaAlmoco.Checked = false;
                            radRetornoAlmoco.Checked = false;
                            radSaidaExpediente.Checked = false;
                            geradorDeclaracao.declaracaoAntecipada(listaFuncionario, salvar.FileName, titulo, momento.ToUpper(), data, horario);
                            MessageBox.Show("Arquivo Salvo", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                txtCracha.Text = String.Empty;
                txtNome.Text = String.Empty;
                txtSetor.Text = String.Empty;
                txtCargo.Text = String.Empty;
                radEntrada.Checked = false;
                radSaidaAlmoco.Checked = false;
                radRetornoAlmoco.Checked = false;
                radSaidaExpediente.Checked = false;
                listFuncionario.Items.Clear();
                MessageBox.Show("Existe um arquivo com o mesmo nome ja aberto", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void declaracaoSaidaTudo(string titulo)
        {
            try
            {
                txtNome.Text = String.Empty;
                txtCracha.Text = String.Empty;
                txtSetor.Text = String.Empty;
                txtCargo.Text = String.Empty;

                var dados = controlador.read();
                momento = txtOutro.Text;
                data = Interaction.InputBox("Informe a data", "Informe");
                horario = Interaction.InputBox("Informe a hora", "Hora");

                if (data != "" && horario != "")
                {
                    SaveFileDialog salvar = new SaveFileDialog();
                    salvar.Filter = ".PDF | .pdf";
                    salvar.FilterIndex = 2;
                    salvar.FileName = "Arquivo";

                    if (salvar.ShowDialog() == DialogResult.OK)
                    {
                        txtCracha.Text = String.Empty;
                        txtNome.Text = String.Empty;
                        txtSetor.Text = String.Empty;
                        txtCargo.Text = String.Empty;
                        radEntrada.Checked = false;
                        radSaidaAlmoco.Checked = false;
                        radRetornoAlmoco.Checked = false;
                        radSaidaExpediente.Checked = false;
                        listFuncionario.Items.Clear();
                        geradorDeclaracao.declaracaoAntecipadaTudo(dados, salvar.FileName, titulo, momento.ToUpper(), data, horario);
                        MessageBox.Show("Arquivo Salvo", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
            catch (Exception ex)
            {
                txtCracha.Text = String.Empty;
                txtNome.Text = String.Empty;
                txtSetor.Text = String.Empty;
                txtCargo.Text = String.Empty;
                radEntrada.Checked = false;
                radSaidaAlmoco.Checked = false;
                radRetornoAlmoco.Checked = false;
                radSaidaExpediente.Checked = false;
                listFuncionario.Items.Clear();
                MessageBox.Show("Existe um arquivo com o mesmo nome ja aberto", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
