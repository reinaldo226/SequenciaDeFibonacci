namespace SequenciaDeFibonacci
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlCabecalho;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblLimite;
        private System.Windows.Forms.TextBox txtLimite;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtSequencia;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.GroupBox grpComoFunciona;
        private System.Windows.Forms.Label lblFormula;
        private System.Windows.Forms.Label lblExemplo;

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
            this.components = new System.ComponentModel.Container();
            this.pnlCabecalho = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblLimite = new System.Windows.Forms.Label();
            this.txtLimite = new System.Windows.Forms.TextBox();
            this.btnGerar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtSequencia = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.grpComoFunciona = new System.Windows.Forms.GroupBox();
            this.lblFormula = new System.Windows.Forms.Label();
            this.lblExemplo = new System.Windows.Forms.Label();
            this.pnlCabecalho.SuspendLayout();
            this.grpComoFunciona.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCabecalho
            // 
            this.pnlCabecalho.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.pnlCabecalho.Controls.Add(this.lblSubtitulo);
            this.pnlCabecalho.Controls.Add(this.lblTitulo);
            this.pnlCabecalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCabecalho.Location = new System.Drawing.Point(0, 0);
            this.pnlCabecalho.Name = "pnlCabecalho";
            this.pnlCabecalho.Size = new System.Drawing.Size(760, 112);
            this.pnlCabecalho.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(28, 17);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(365, 37);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Sequência de Fibonacci";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(219, 234, 254);
            this.lblSubtitulo.Location = new System.Drawing.Point(31, 67);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(432, 19);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Gere os termos até o número máximo informado";
            // 
            // lblLimite
            // 
            this.lblLimite.AutoSize = true;
            this.lblLimite.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblLimite.Location = new System.Drawing.Point(32, 145);
            this.lblLimite.Name = "lblLimite";
            this.lblLimite.Size = new System.Drawing.Size(122, 19);
            this.lblLimite.TabIndex = 1;
            this.lblLimite.Text = "Número máximo:";
            // 
            // txtLimite
            // 
            this.txtLimite.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtLimite.Location = new System.Drawing.Point(35, 170);
            this.txtLimite.MaxLength = 19;
            this.txtLimite.Name = "txtLimite";
            this.txtLimite.Size = new System.Drawing.Size(300, 27);
            this.txtLimite.TabIndex = 2;
            this.txtLimite.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLimite_KeyPress);
            // 
            // btnGerar
            // 
            this.btnGerar.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnGerar.FlatAppearance.BorderSize = 0;
            this.btnGerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnGerar.ForeColor = System.Drawing.Color.White;
            this.btnGerar.Location = new System.Drawing.Point(355, 168);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(174, 32);
            this.btnGerar.TabIndex = 3;
            this.btnGerar.Text = "Gerar sequência";
            this.btnGerar.UseVisualStyleBackColor = false;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnLimpar.Location = new System.Drawing.Point(539, 168);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(105, 32);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblResultado.Location = new System.Drawing.Point(32, 226);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(83, 19);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Text = "Sequência:";
            // 
            // txtSequencia
            // 
            this.txtSequencia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSequencia.BackColor = System.Drawing.Color.White;
            this.txtSequencia.Font = new System.Drawing.Font("Consolas", 11F);
            this.txtSequencia.Location = new System.Drawing.Point(35, 251);
            this.txtSequencia.Multiline = true;
            this.txtSequencia.Name = "txtSequencia";
            this.txtSequencia.ReadOnly = true;
            this.txtSequencia.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSequencia.Size = new System.Drawing.Size(690, 94);
            this.txtSequencia.TabIndex = 6;
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblStatus.Location = new System.Drawing.Point(35, 361);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(690, 22);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "Digite um limite e clique em Gerar sequência.";
            // 
            // grpComoFunciona
            // 
            this.grpComoFunciona.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.grpComoFunciona.Controls.Add(this.lblExemplo);
            this.grpComoFunciona.Controls.Add(this.lblFormula);
            this.grpComoFunciona.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpComoFunciona.Location = new System.Drawing.Point(35, 397);
            this.grpComoFunciona.Name = "grpComoFunciona";
            this.grpComoFunciona.Size = new System.Drawing.Size(690, 91);
            this.grpComoFunciona.TabIndex = 8;
            this.grpComoFunciona.TabStop = false;
            this.grpComoFunciona.Text = "Como funciona";
            // 
            // lblFormula
            // 
            this.lblFormula.AutoSize = true;
            this.lblFormula.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblFormula.Location = new System.Drawing.Point(16, 28);
            this.lblFormula.Name = "lblFormula";
            this.lblFormula.Size = new System.Drawing.Size(337, 19);
            this.lblFormula.TabIndex = 0;
            this.lblFormula.Text = "F(0) = 0, F(1) = 1 e F(n) = F(n-1) + F(n-2)";
            // 
            // lblExemplo
            // 
            this.lblExemplo.AutoSize = true;
            this.lblExemplo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblExemplo.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblExemplo.Location = new System.Drawing.Point(17, 56);
            this.lblExemplo.Name = "lblExemplo";
            this.lblExemplo.Size = new System.Drawing.Size(458, 15);
            this.lblExemplo.TabIndex = 1;
            this.lblExemplo.Text = "Cada termo é a soma dos dois anteriores: 0, 1, 1, 2, 3, 5, 8, 13...";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnGerar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.ClientSize = new System.Drawing.Size(760, 520);
            this.Controls.Add(this.grpComoFunciona);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtSequencia);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.txtLimite);
            this.Controls.Add(this.lblLimite);
            this.Controls.Add(this.pnlCabecalho);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(650, 500);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sequência de Fibonacci";
            this.pnlCabecalho.ResumeLayout(false);
            this.pnlCabecalho.PerformLayout();
            this.grpComoFunciona.ResumeLayout(false);
            this.grpComoFunciona.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}

