namespace GeradorDeDeclaracao
{
    partial class frmDeletar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDeletar));
            this.grpConteudo = new System.Windows.Forms.GroupBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.dtGridFuncionario = new System.Windows.Forms.DataGridView();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblRodape = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grpConteudo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridFuncionario)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpConteudo
            // 
            this.grpConteudo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpConteudo.Controls.Add(this.lblNome);
            this.grpConteudo.Controls.Add(this.btnVoltar);
            this.grpConteudo.Controls.Add(this.dtGridFuncionario);
            this.grpConteudo.Controls.Add(this.btnDeletar);
            this.grpConteudo.Controls.Add(this.txtNome);
            this.grpConteudo.Location = new System.Drawing.Point(55, 114);
            this.grpConteudo.Name = "grpConteudo";
            this.grpConteudo.Size = new System.Drawing.Size(716, 481);
            this.grpConteudo.TabIndex = 11;
            this.grpConteudo.TabStop = false;
            // 
            // lblNome
            // 
            this.lblNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.Navy;
            this.lblNome.Location = new System.Drawing.Point(129, 96);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(48, 16);
            this.lblNome.TabIndex = 36;
            this.lblNome.Text = "Nome";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVoltar.BackColor = System.Drawing.Color.Navy;
            this.btnVoltar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnVoltar.FlatAppearance.BorderSize = 2;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVoltar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.White;
            this.btnVoltar.Location = new System.Drawing.Point(251, 365);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(197, 21);
            this.btnVoltar.TabIndex = 27;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // dtGridFuncionario
            // 
            this.dtGridFuncionario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtGridFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridFuncionario.Location = new System.Drawing.Point(33, 134);
            this.dtGridFuncionario.Name = "dtGridFuncionario";
            this.dtGridFuncionario.ReadOnly = true;
            this.dtGridFuncionario.Size = new System.Drawing.Size(652, 210);
            this.dtGridFuncionario.TabIndex = 26;
            this.dtGridFuncionario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridFuncionario_CellContentClick);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeletar.BackColor = System.Drawing.Color.Navy;
            this.btnDeletar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDeletar.FlatAppearance.BorderSize = 2;
            this.btnDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeletar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletar.ForeColor = System.Drawing.Color.White;
            this.btnDeletar.Location = new System.Drawing.Point(440, 95);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(73, 21);
            this.btnDeletar.TabIndex = 25;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = false;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // txtNome
            // 
            this.txtNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(206, 95);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(228, 20);
            this.txtNome.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.lblRodape);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 704);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(848, 45);
            this.panel2.TabIndex = 15;
            // 
            // lblRodape
            // 
            this.lblRodape.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRodape.AutoSize = true;
            this.lblRodape.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRodape.ForeColor = System.Drawing.Color.White;
            this.lblRodape.Location = new System.Drawing.Point(318, 10);
            this.lblRodape.Name = "lblRodape";
            this.lblRodape.Size = new System.Drawing.Size(231, 22);
            this.lblRodape.TabIndex = 1;
            this.lblRodape.Text = "Gerador de declarações";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(848, 76);
            this.panel1.TabIndex = 14;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(300, 23);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(233, 32);
            this.lblTitulo.TabIndex = 13;
            this.lblTitulo.Text = "Tela de exclusão";
            // 
            // frmDeletar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 749);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grpConteudo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDeletar";
            this.Text = "Tela Deletar";
            this.Load += new System.EventHandler(this.frmDeletar_Load);
            this.grpConteudo.ResumeLayout(false);
            this.grpConteudo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridFuncionario)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpConteudo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.DataGridView dtGridFuncionario;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblRodape;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitulo;
    }
}