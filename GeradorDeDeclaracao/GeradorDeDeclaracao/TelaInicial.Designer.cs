namespace GeradorDeDeclaracao
{
    partial class frmInicial
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicial));
            this.btnCadastro = new System.Windows.Forms.Button();
            this.btnGerar = new System.Windows.Forms.Button();
            this.grpTitulo = new System.Windows.Forms.GroupBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pctMenuDeclaracao = new System.Windows.Forms.PictureBox();
            this.pctCadastro = new System.Windows.Forms.PictureBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctMenuDeclaracao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCadastro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCadastro
            // 
            this.btnCadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCadastro.BackColor = System.Drawing.Color.Navy;
            this.btnCadastro.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCadastro.FlatAppearance.BorderSize = 2;
            this.btnCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastro.ForeColor = System.Drawing.Color.White;
            this.btnCadastro.Location = new System.Drawing.Point(65, 280);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(125, 23);
            this.btnCadastro.TabIndex = 2;
            this.btnCadastro.Text = "Cadastro";
            this.btnCadastro.UseVisualStyleBackColor = false;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // btnGerar
            // 
            this.btnGerar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGerar.BackColor = System.Drawing.Color.Navy;
            this.btnGerar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGerar.FlatAppearance.BorderSize = 2;
            this.btnGerar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGerar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerar.ForeColor = System.Drawing.Color.White;
            this.btnGerar.Location = new System.Drawing.Point(255, 280);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(125, 23);
            this.btnGerar.TabIndex = 3;
            this.btnGerar.Text = "Declarações";
            this.btnGerar.UseVisualStyleBackColor = false;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // grpTitulo
            // 
            this.grpTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpTitulo.Controls.Add(this.lblTitulo);
            this.grpTitulo.Location = new System.Drawing.Point(65, 60);
            this.grpTitulo.Name = "grpTitulo";
            this.grpTitulo.Size = new System.Drawing.Size(497, 65);
            this.grpTitulo.TabIndex = 4;
            this.grpTitulo.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Navy;
            this.lblTitulo.Location = new System.Drawing.Point(191, 25);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(118, 22);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Menu Inicial";
            // 
            // pctMenuDeclaracao
            // 
            this.pctMenuDeclaracao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pctMenuDeclaracao.Image = ((System.Drawing.Image)(resources.GetObject("pctMenuDeclaracao.Image")));
            this.pctMenuDeclaracao.Location = new System.Drawing.Point(255, 150);
            this.pctMenuDeclaracao.Name = "pctMenuDeclaracao";
            this.pctMenuDeclaracao.Size = new System.Drawing.Size(125, 110);
            this.pctMenuDeclaracao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctMenuDeclaracao.TabIndex = 1;
            this.pctMenuDeclaracao.TabStop = false;
            // 
            // pctCadastro
            // 
            this.pctCadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pctCadastro.Image = ((System.Drawing.Image)(resources.GetObject("pctCadastro.Image")));
            this.pctCadastro.Location = new System.Drawing.Point(65, 150);
            this.pctCadastro.Name = "pctCadastro";
            this.pctCadastro.Size = new System.Drawing.Size(125, 110);
            this.pctCadastro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctCadastro.TabIndex = 0;
            this.pctCadastro.TabStop = false;
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
            this.btnVoltar.Location = new System.Drawing.Point(437, 280);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(125, 23);
            this.btnVoltar.TabIndex = 6;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(437, 150);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // frmInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 397);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grpTitulo);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.pctMenuDeclaracao);
            this.Controls.Add(this.pctCadastro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInicial";
            this.Text = "Inicio";
            this.grpTitulo.ResumeLayout(false);
            this.grpTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctMenuDeclaracao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCadastro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pctCadastro;
        private System.Windows.Forms.PictureBox pctMenuDeclaracao;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.GroupBox grpTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

