
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
using Model;
using Dao;
using Controller;

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
        ListViewItem listViewItem;

        public List<mdlFuncionario> listaFuncionario = new List<mdlFuncionario>();
        public ListViewItem item;
        public frmGerarDeclacarao()
        {
            InitializeComponent();
        }  
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            listViewFuncionarios.Items.Clear();
            nome = txtPesquisa.Text;
            var dados = controlador.searchName(nome);

            if(dados != null)
            {
                ListViewItem item = new ListViewItem(dados.getNome());
                listViewFuncionarios.Items.Add(item);
            }
        }  
        private void btnAdcionar_Click(object sender, EventArgs e)
        {
            try
            {
                nome = txtNome.Text;
                setor = txtSetor.Text;
                cargo = txtCargo.Text;
                cracha = Convert.ToInt32(txtCracha.Text);

                if (cracha.ToString() == String.Empty || nome == String.Empty || 
                    setor == String.Empty || cargo == String.Empty)
                {
                    MessageBox.Show("Verifique se todos os dados estão preenchidos", "Erro !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    listaFuncionario.Add(new mdlFuncionario(cracha, nome, setor, cargo));

                    foreach (var i in listaFuncionario)
                    {
                        item = new ListViewItem(i.getNome());
                    }

                    listFuncionario.Items.Add(item);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Por favor selecione o funcionário antes de adcionar a lista", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (listaFuncionario.Count == 0)
            {
                MessageBox.Show("Funcionário não adcionado a lista de funcionários", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtOutro.Text == "" && radEntrada.Checked == false && radSaidaAlmoco.Checked == false
                && radRetornoAlmoco.Checked == false && radSaidaExpediente.Checked == false)
            {
                MessageBox.Show("Por favor informe o motivo da declaração", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (controladorTelas.getTela() == "1")
                {
                    declaracaoPonto();
                }
                else if (controladorTelas.getTela() == "2")
                {
                    declaracaoAviso("AVISO ANTECIPADO");
                }
                else if (controladorTelas.getTela() == "3")
                {
                    declaracaoSaida("SAÍDA ANTECIPADA");
                }
            }
        }
        private void btnGerarTudo_Click(object sender, EventArgs e)
        {
            if (txtOutro.Text != "" || radEntrada.Checked != false || radSaidaAlmoco.Checked != false 
                || radRetornoAlmoco.Checked != false || radSaidaExpediente.Checked != false)
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
            else
            {
                MessageBox.Show("Por favor insira o motivo da declaração", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            if(controladorTelas.getTela() == "2" || controladorTelas.getTela() == "3")
            {
                foreach (var item in controlador.read())
                {
                 listViewItem = new ListViewItem(item.getNome());
                 listViewItem.SubItems.Add(item.getCracha().ToString());
                 listViewFuncionarios.Items.Add(listViewItem);
                }

                radEntrada.Enabled = false;
                radSaidaAlmoco.Enabled = false;
                radRetornoAlmoco.Enabled = false;
                radSaidaExpediente.Enabled = false;
                radOutro.Checked = true;
            }else
            {
                foreach (var item in controlador.read())
                {
                    listViewItem = new ListViewItem(item.getNome());
                    listViewItem.SubItems.Add(item.getCracha().ToString());
                    listViewFuncionarios.Items.Add(listViewItem);
                }

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
                MessageBox.Show("Existe um arquivo com o mesmo nome ja aberto: "+ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Existe um arquivo com o mesmo nome ja aberto: "+ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void listViewFuncionarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in listViewFuncionarios.SelectedItems)
            {
                txtNome.Text = listViewFuncionarios.SelectedItems[0].Text.ToString();
                var retorno = controlador.searchName(txtNome.Text);
                if(retorno != null)
                {
                    txtCracha.Text = controlador.getCracha().ToString();
                    txtSetor.Text = controlador.getSetor();
                    txtCargo.Text = controlador.getCargo();
                }

            }
        }
    }
}
