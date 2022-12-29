namespace GeradorDeDeclaracao
{
    partial class frmMenuDeclaracao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuDeclaracao));
            this.btnGerarJustificativaPonto = new System.Windows.Forms.Button();
            this.pctMenuDeclaracao = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctMenuDeclaracao)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGerarJustificativaPonto
            // 
            this.btnGerarJustificativaPonto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGerarJustificativaPonto.BackColor = System.Drawing.Color.Navy;
            this.btnGerarJustificativaPonto.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGerarJustificativaPonto.FlatAppearance.BorderSize = 2;
            this.btnGerarJustificativaPonto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGerarJustificativaPonto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarJustificativaPonto.ForeColor = System.Drawing.Color.White;
            this.btnGerarJustificativaPonto.Location = new System.Drawing.Point(50, 266);
            this.btnGerarJustificativaPonto.Name = "btnGerarJustificativaPonto";
            this.btnGerarJustificativaPonto.Size = new System.Drawing.Size(125, 23);
            this.btnGerarJustificativaPonto.TabIndex = 5;
            this.btnGerarJustificativaPonto.Text = "Justificativa Ponto";
            this.btnGerarJustificativaPonto.UseVisualStyleBackColor = false;
            this.btnGerarJustificativaPonto.Click += new System.EventHandler(this.btnGerarJustificativaPonto_Click);
            // 
            // pctMenuDeclaracao
            // 
            this.pctMenuDeclaracao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pctMenuDeclaracao.Image = ((System.Drawing.Image)(resources.GetObject("pctMenuDeclaracao.Image")));
            this.pctMenuDeclaracao.Location = new System.Drawing.Point(50, 136);
            this.pctMenuDeclaracao.Name = "pctMenuDeclaracao";
            this.pctMenuDeclaracao.Size = new System.Drawing.Size(125, 110);
            this.pctMenuDeclaracao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctMenuDeclaracao.TabIndex = 4;
            this.pctMenuDeclaracao.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTitulo);
            this.groupBox1.Location = new System.Drawing.Point(50, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(708, 79);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Navy;
            this.lblTitulo.Location = new System.Drawing.Point(254, 28);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(180, 32);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Declarações";
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
            this.btnVoltar.Location = new System.Drawing.Point(341, 351);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(125, 23);
            this.btnVoltar.TabIndex = 7;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // frmMenuDeclaracao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 436);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGerarJustificativaPonto);
            this.Controls.Add(this.pctMenuDeclaracao);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMenuDeclaracao";
            this.Text = "Menu Declaracao";
            ((System.ComponentModel.ISupportInitialize)(this.pctMenuDeclaracao)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGerarJustificativaPonto;
        private System.Windows.Forms.PictureBox pctMenuDeclaracao;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnVoltar;
    }
}