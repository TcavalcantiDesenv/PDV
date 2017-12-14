namespace MGMPDV.Formularios
{
    partial class FRelatorio
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
            this.pnltitulo = new System.Windows.Forms.Panel();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.btnfechar = new System.Windows.Forms.Button();
            this.pnlrelatorio = new System.Windows.Forms.Panel();
            this.lblprodutoestoque = new System.Windows.Forms.LinkLabel();
            this.lblprodutosvendidos = new System.Windows.Forms.LinkLabel();
            this.lblproduto = new System.Windows.Forms.LinkLabel();
            this.lblcliente = new System.Windows.Forms.LinkLabel();
            this.lblcaixa = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblcaixapagamento = new System.Windows.Forms.LinkLabel();
            this.pnltitulo.SuspendLayout();
            this.pnlrelatorio.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnltitulo
            // 
            this.pnltitulo.BackColor = System.Drawing.Color.Transparent;
            this.pnltitulo.Controls.Add(this.lbltitulo);
            this.pnltitulo.Controls.Add(this.btnfechar);
            this.pnltitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnltitulo.Location = new System.Drawing.Point(0, 0);
            this.pnltitulo.Name = "pnltitulo";
            this.pnltitulo.Padding = new System.Windows.Forms.Padding(2);
            this.pnltitulo.Size = new System.Drawing.Size(722, 26);
            this.pnltitulo.TabIndex = 133;
            // 
            // lbltitulo
            // 
            this.lbltitulo.BackColor = System.Drawing.Color.Transparent;
            this.lbltitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbltitulo.Font = new System.Drawing.Font("Courier New", 13F, System.Drawing.FontStyle.Bold);
            this.lbltitulo.ForeColor = System.Drawing.Color.White;
            this.lbltitulo.Location = new System.Drawing.Point(2, 2);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(696, 22);
            this.lbltitulo.TabIndex = 76;
            this.lbltitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnfechar
            // 
            this.btnfechar.BackColor = System.Drawing.Color.Transparent;
            this.btnfechar.BackgroundImage = global::MGMPDV.Properties.Resources.fexar;
            this.btnfechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnfechar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnfechar.FlatAppearance.BorderSize = 0;
            this.btnfechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnfechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnfechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfechar.Font = new System.Drawing.Font("Courier New", 13F);
            this.btnfechar.ForeColor = System.Drawing.Color.White;
            this.btnfechar.Location = new System.Drawing.Point(698, 2);
            this.btnfechar.Margin = new System.Windows.Forms.Padding(0);
            this.btnfechar.Name = "btnfechar";
            this.btnfechar.Size = new System.Drawing.Size(22, 22);
            this.btnfechar.TabIndex = 0;
            this.btnfechar.UseVisualStyleBackColor = false;
            this.btnfechar.Click += new System.EventHandler(this.btnfechar_Click);
            // 
            // pnlrelatorio
            // 
            this.pnlrelatorio.BackColor = System.Drawing.Color.Transparent;
            this.pnlrelatorio.Controls.Add(this.lblprodutoestoque);
            this.pnlrelatorio.Controls.Add(this.lblprodutosvendidos);
            this.pnlrelatorio.Controls.Add(this.lblproduto);
            this.pnlrelatorio.Controls.Add(this.lblcliente);
            this.pnlrelatorio.Controls.Add(this.lblcaixapagamento);
            this.pnlrelatorio.Controls.Add(this.lblcaixa);
            this.pnlrelatorio.Location = new System.Drawing.Point(5, 71);
            this.pnlrelatorio.Name = "pnlrelatorio";
            this.pnlrelatorio.Size = new System.Drawing.Size(712, 164);
            this.pnlrelatorio.TabIndex = 166;
            // 
            // lblprodutoestoque
            // 
            this.lblprodutoestoque.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.lblprodutoestoque.ForeColor = System.Drawing.Color.White;
            this.lblprodutoestoque.LinkColor = System.Drawing.Color.White;
            this.lblprodutoestoque.Location = new System.Drawing.Point(9, 89);
            this.lblprodutoestoque.Name = "lblprodutoestoque";
            this.lblprodutoestoque.Size = new System.Drawing.Size(535, 21);
            this.lblprodutoestoque.TabIndex = 2;
            this.lblprodutoestoque.TabStop = true;
            this.lblprodutoestoque.Text = "Produtos por Estoque";
            this.lblprodutoestoque.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblprodutoestoque_LinkClicked);
            // 
            // lblprodutosvendidos
            // 
            this.lblprodutosvendidos.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.lblprodutosvendidos.ForeColor = System.Drawing.Color.White;
            this.lblprodutosvendidos.LinkColor = System.Drawing.Color.White;
            this.lblprodutosvendidos.Location = new System.Drawing.Point(9, 114);
            this.lblprodutosvendidos.Name = "lblprodutosvendidos";
            this.lblprodutosvendidos.Size = new System.Drawing.Size(535, 21);
            this.lblprodutosvendidos.TabIndex = 0;
            this.lblprodutosvendidos.TabStop = true;
            this.lblprodutosvendidos.Text = "Produtos Vendidos";
            this.lblprodutosvendidos.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblprodutosvendidos_LinkClicked);
            // 
            // lblproduto
            // 
            this.lblproduto.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.lblproduto.ForeColor = System.Drawing.Color.White;
            this.lblproduto.LinkColor = System.Drawing.Color.White;
            this.lblproduto.Location = new System.Drawing.Point(9, 63);
            this.lblproduto.Name = "lblproduto";
            this.lblproduto.Size = new System.Drawing.Size(535, 21);
            this.lblproduto.TabIndex = 0;
            this.lblproduto.TabStop = true;
            this.lblproduto.Text = "Produtos";
            this.lblproduto.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblproduto_LinkClicked);
            // 
            // lblcliente
            // 
            this.lblcliente.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.lblcliente.ForeColor = System.Drawing.Color.White;
            this.lblcliente.LinkColor = System.Drawing.Color.White;
            this.lblcliente.Location = new System.Drawing.Point(10, 138);
            this.lblcliente.Name = "lblcliente";
            this.lblcliente.Size = new System.Drawing.Size(535, 21);
            this.lblcliente.TabIndex = 0;
            this.lblcliente.TabStop = true;
            this.lblcliente.Text = "Clientes";
            this.lblcliente.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblcliente_LinkClicked);
            // 
            // lblcaixa
            // 
            this.lblcaixa.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.lblcaixa.ForeColor = System.Drawing.Color.White;
            this.lblcaixa.LinkColor = System.Drawing.Color.White;
            this.lblcaixa.Location = new System.Drawing.Point(9, 11);
            this.lblcaixa.Name = "lblcaixa";
            this.lblcaixa.Size = new System.Drawing.Size(535, 21);
            this.lblcaixa.TabIndex = 0;
            this.lblcaixa.TabStop = true;
            this.lblcaixa.Text = "Caixa";
            this.lblcaixa.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblcaixa_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 15.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(306, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Relatórios";
            // 
            // lblcaixapagamento
            // 
            this.lblcaixapagamento.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.lblcaixapagamento.ForeColor = System.Drawing.Color.White;
            this.lblcaixapagamento.LinkColor = System.Drawing.Color.White;
            this.lblcaixapagamento.Location = new System.Drawing.Point(7, 36);
            this.lblcaixapagamento.Name = "lblcaixapagamento";
            this.lblcaixapagamento.Size = new System.Drawing.Size(535, 21);
            this.lblcaixapagamento.TabIndex = 0;
            this.lblcaixapagamento.TabStop = true;
            this.lblcaixapagamento.Text = "Caixa x Pagamento";
            this.lblcaixapagamento.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblcaixapagamento_LinkClicked);
            // 
            // FRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(722, 263);
            this.Controls.Add(this.pnlrelatorio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnltitulo);
            this.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRelatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRelatorio";
            this.pnltitulo.ResumeLayout(false);
            this.pnlrelatorio.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnltitulo;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Button btnfechar;
        private System.Windows.Forms.Panel pnlrelatorio;
        private System.Windows.Forms.LinkLabel lblprodutoestoque;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lblprodutosvendidos;
        private System.Windows.Forms.LinkLabel lblproduto;
        private System.Windows.Forms.LinkLabel lblcliente;
        private System.Windows.Forms.LinkLabel lblcaixa;
        private System.Windows.Forms.LinkLabel lblcaixapagamento;
    }
}