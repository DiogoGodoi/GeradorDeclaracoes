namespace GeradorDeDeclaracao
{
    partial class frmCadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastro));
            this.panelConteudo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblRodape = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.pctMenuDeclaracao = new System.Windows.Forms.PictureBox();
            this.pctCadastro = new System.Windows.Forms.PictureBox();
            this.panelConteudo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMenuDeclaracao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCadastro)).BeginInit();
            this.SuspendLayout();
            // 
            // panelConteudo
            // 
            this.panelConteudo.Controls.Add(this.panel1);
            this.panelConteudo.Controls.Add(this.panel2);
            this.panelConteudo.Controls.Add(this.btnVoltar);
            this.panelConteudo.Controls.Add(this.btnDeletar);
            this.panelConteudo.Controls.Add(this.pictureBox1);
            this.panelConteudo.Controls.Add(this.pictureBox2);
            this.panelConteudo.Controls.Add(this.btnAlterar);
            this.panelConteudo.Controls.Add(this.btnCadastrar);
            this.panelConteudo.Controls.Add(this.pctMenuDeclaracao);
            this.panelConteudo.Controls.Add(this.pctCadastro);
            this.panelConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelConteudo.Location = new System.Drawing.Point(0, 0);
            this.panelConteudo.Name = "panelConteudo";
            this.panelConteudo.Size = new System.Drawing.Size(864, 788);
            this.panelConteudo.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(864, 76);
            this.panel1.TabIndex = 23;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(353, 23);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(151, 32);
            this.lblTitulo.TabIndex = 13;
            this.lblTitulo.Text = "Cadastros";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.lblRodape);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 732);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(864, 56);
            this.panel2.TabIndex = 22;
            // 
            // lblRodape
            // 
            this.lblRodape.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRodape.AutoSize = true;
            this.lblRodape.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRodape.ForeColor = System.Drawing.Color.White;
            this.lblRodape.Location = new System.Drawing.Point(326, 16);
            this.lblRodape.Name = "lblRodape";
            this.lblRodape.Size = new System.Drawing.Size(231, 22);
            this.lblRodape.TabIndex = 1;
            this.lblRodape.Text = "Gerador de declarações";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVoltar.BackColor = System.Drawing.Color.Navy;
            this.btnVoltar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnVoltar.FlatAppearance.BorderSize = 2;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVoltar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.White;
            this.btnVoltar.Location = new System.Drawing.Point(652, 448);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(125, 23);
            this.btnVoltar.TabIndex = 21;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            // 
            // btnDeletar
            // 
            this.btnDeletar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeletar.BackColor = System.Drawing.Color.Navy;
            this.btnDeletar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDeletar.FlatAppearance.BorderSize = 2;
            this.btnDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeletar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletar.ForeColor = System.Drawing.Color.White;
            this.btnDeletar.Location = new System.Drawing.Point(462, 448);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(125, 23);
            this.btnDeletar.TabIndex = 20;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(652, 318);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::GeradorDeDeclaracao.Properties.Resources.erro;
            this.pictureBox2.Location = new System.Drawing.Point(462, 318);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(125, 110);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAlterar.BackColor = System.Drawing.Color.Navy;
            this.btnAlterar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAlterar.FlatAppearance.BorderSize = 2;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAlterar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.Color.White;
            this.btnAlterar.Location = new System.Drawing.Point(277, 448);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(125, 23);
            this.btnAlterar.TabIndex = 17;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCadastrar.BackColor = System.Drawing.Color.Navy;
            this.btnCadastrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCadastrar.FlatAppearance.BorderSize = 2;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(87, 448);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(125, 23);
            this.btnCadastrar.TabIndex = 16;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // pctMenuDeclaracao
            // 
            this.pctMenuDeclaracao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pctMenuDeclaracao.Image = ((System.Drawing.Image)(resources.GetObject("pctMenuDeclaracao.Image")));
            this.pctMenuDeclaracao.Location = new System.Drawing.Point(277, 318);
            this.pctMenuDeclaracao.Name = "pctMenuDeclaracao";
            this.pctMenuDeclaracao.Size = new System.Drawing.Size(125, 110);
            this.pctMenuDeclaracao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctMenuDeclaracao.TabIndex = 15;
            this.pctMenuDeclaracao.TabStop = false;
            // 
            // pctCadastro
            // 
            this.pctCadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pctCadastro.Image = ((System.Drawing.Image)(resources.GetObject("pctCadastro.Image")));
            this.pctCadastro.Location = new System.Drawing.Point(87, 318);
            this.pctCadastro.Name = "pctCadastro";
            this.pctCadastro.Size = new System.Drawing.Size(125, 110);
            this.pctCadastro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctCadastro.TabIndex = 14;
            this.pctCadastro.TabStop = false;
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 788);
            this.Controls.Add(this.panelConteudo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCadastro";
            this.Text = "Menu Cadastro";
            this.Load += new System.EventHandler(this.frmCadastro_Load);
            this.panelConteudo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMenuDeclaracao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCadastro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelConteudo;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.PictureBox pctMenuDeclaracao;
        private System.Windows.Forms.PictureBox pctCadastro;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblRodape;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitulo;
    }
}