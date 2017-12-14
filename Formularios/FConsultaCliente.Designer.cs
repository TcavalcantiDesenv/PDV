namespace MGMPDV
{
    partial class FConsultaCliente
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grid = new System.Windows.Forms.DataGridView();
            this.cli_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_telefone1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_telefone2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ttbcliente = new System.Windows.Forms.TextBox();
            this.btnpesquisar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnltitulo = new System.Windows.Forms.Panel();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.btnfechar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnconfirmar = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnltitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid.ColumnHeadersHeight = 50;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cli_nome,
            this.cli_endereco,
            this.cli_numero,
            this.cli_bairro,
            this.cli_telefone1,
            this.cli_telefone2});
            this.grid.EnableHeadersVisualStyles = false;
            this.grid.Location = new System.Drawing.Point(41, 228);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowHeadersVisible = false;
            this.grid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.grid.RowTemplate.Height = 40;
            this.grid.Size = new System.Drawing.Size(942, 382);
            this.grid.TabIndex = 80;
            this.grid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellDoubleClick);
            // 
            // cli_nome
            // 
            this.cli_nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cli_nome.DataPropertyName = "cli_nome";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.cli_nome.DefaultCellStyle = dataGridViewCellStyle2;
            this.cli_nome.HeaderText = "Cliente";
            this.cli_nome.Name = "cli_nome";
            this.cli_nome.ReadOnly = true;
            this.cli_nome.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // cli_endereco
            // 
            this.cli_endereco.DataPropertyName = "cli_endereco";
            this.cli_endereco.HeaderText = "Endereço";
            this.cli_endereco.Name = "cli_endereco";
            this.cli_endereco.ReadOnly = true;
            this.cli_endereco.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.cli_endereco.Width = 200;
            // 
            // cli_numero
            // 
            this.cli_numero.DataPropertyName = "cli_numero";
            this.cli_numero.HeaderText = "Número";
            this.cli_numero.Name = "cli_numero";
            this.cli_numero.ReadOnly = true;
            this.cli_numero.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // cli_bairro
            // 
            this.cli_bairro.DataPropertyName = "cli_bairro";
            this.cli_bairro.HeaderText = "Bairro";
            this.cli_bairro.Name = "cli_bairro";
            this.cli_bairro.ReadOnly = true;
            this.cli_bairro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // cli_telefone1
            // 
            this.cli_telefone1.DataPropertyName = "cli_telefone1";
            this.cli_telefone1.HeaderText = "Telefone";
            this.cli_telefone1.Name = "cli_telefone1";
            this.cli_telefone1.ReadOnly = true;
            this.cli_telefone1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.cli_telefone1.Width = 120;
            // 
            // cli_telefone2
            // 
            this.cli_telefone2.DataPropertyName = "cli_telefone2";
            this.cli_telefone2.HeaderText = "Telefone";
            this.cli_telefone2.Name = "cli_telefone2";
            this.cli_telefone2.ReadOnly = true;
            this.cli_telefone2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.cli_telefone2.Width = 120;
            // 
            // ttbcliente
            // 
            this.ttbcliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ttbcliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ttbcliente.Font = new System.Drawing.Font("Courier New", 35F, System.Drawing.FontStyle.Bold);
            this.ttbcliente.ForeColor = System.Drawing.Color.Gray;
            this.ttbcliente.Location = new System.Drawing.Point(128, 24);
            this.ttbcliente.Name = "ttbcliente";
            this.ttbcliente.Size = new System.Drawing.Size(949, 53);
            this.ttbcliente.TabIndex = 0;
            this.ttbcliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ttbcliente.Click += new System.EventHandler(this.ttbcliente_Click);
            this.ttbcliente.Enter += new System.EventHandler(this.lblproduto_Enter);
            // 
            // btnpesquisar
            // 
            this.btnpesquisar.BackColor = System.Drawing.Color.Transparent;
            this.btnpesquisar.BackgroundImage = global::MGMPDV.Properties.Resources.Find;
            this.btnpesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnpesquisar.FlatAppearance.BorderSize = 0;
            this.btnpesquisar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnpesquisar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnpesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpesquisar.Font = new System.Drawing.Font("Courier New", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpesquisar.ForeColor = System.Drawing.Color.White;
            this.btnpesquisar.Location = new System.Drawing.Point(1026, 24);
            this.btnpesquisar.Margin = new System.Windows.Forms.Padding(0);
            this.btnpesquisar.Name = "btnpesquisar";
            this.btnpesquisar.Size = new System.Drawing.Size(46, 48);
            this.btnpesquisar.TabIndex = 78;
            this.btnpesquisar.TabStop = false;
            this.btnpesquisar.UseVisualStyleBackColor = false;
            this.btnpesquisar.Visible = false;
            this.btnpesquisar.Click += new System.EventHandler(this.btnpesquisar_Click);
            this.btnpesquisar.Enter += new System.EventHandler(this.lblproduto_Enter);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel1.Controls.Add(this.ttbcliente);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnpesquisar);
            this.panel1.Location = new System.Drawing.Point(0, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1090, 93);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::MGMPDV.Properties.Resources.pesquisar2;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, -9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 112);
            this.pictureBox1.TabIndex = 135;
            this.pictureBox1.TabStop = false;
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
            this.pnltitulo.Size = new System.Drawing.Size(1024, 22);
            this.pnltitulo.TabIndex = 134;
            // 
            // lbltitulo
            // 
            this.lbltitulo.BackColor = System.Drawing.Color.Transparent;
            this.lbltitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbltitulo.Font = new System.Drawing.Font("Courier New", 13F, System.Drawing.FontStyle.Bold);
            this.lbltitulo.ForeColor = System.Drawing.Color.White;
            this.lbltitulo.Location = new System.Drawing.Point(2, 2);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(1004, 18);
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
            this.btnfechar.Location = new System.Drawing.Point(1006, 2);
            this.btnfechar.Margin = new System.Windows.Forms.Padding(0);
            this.btnfechar.Name = "btnfechar";
            this.btnfechar.Size = new System.Drawing.Size(16, 18);
            this.btnfechar.TabIndex = 0;
            this.btnfechar.UseVisualStyleBackColor = false;
            this.btnfechar.Click += new System.EventHandler(this.btnfechar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 20F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(419, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 32);
            this.label2.TabIndex = 163;
            this.label2.Text = "Consultar Clientes";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::MGMPDV.Properties.Resources.pesquisar2;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(12, 89);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(94, 112);
            this.pictureBox2.TabIndex = 164;
            this.pictureBox2.TabStop = false;
            // 
            // btnconfirmar
            // 
            this.btnconfirmar.BackColor = System.Drawing.Color.Transparent;
            this.btnconfirmar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnconfirmar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnconfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnconfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnconfirmar.Font = new System.Drawing.Font("Consolas", 9F);
            this.btnconfirmar.ForeColor = System.Drawing.Color.White;
            this.btnconfirmar.Location = new System.Drawing.Point(41, 626);
            this.btnconfirmar.Margin = new System.Windows.Forms.Padding(0);
            this.btnconfirmar.Name = "btnconfirmar";
            this.btnconfirmar.Size = new System.Drawing.Size(160, 38);
            this.btnconfirmar.TabIndex = 166;
            this.btnconfirmar.Text = "Cadastrar";
            this.btnconfirmar.UseVisualStyleBackColor = false;
            this.btnconfirmar.Click += new System.EventHandler(this.btnconfirmar_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.BackColor = System.Drawing.Color.Transparent;
            this.btnvoltar.BackgroundImage = global::MGMPDV.Properties.Resources.voltar2;
            this.btnvoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnvoltar.FlatAppearance.BorderSize = 0;
            this.btnvoltar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnvoltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnvoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvoltar.Font = new System.Drawing.Font("Courier New", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvoltar.ForeColor = System.Drawing.Color.White;
            this.btnvoltar.Location = new System.Drawing.Point(936, 620);
            this.btnvoltar.Margin = new System.Windows.Forms.Padding(0);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(46, 48);
            this.btnvoltar.TabIndex = 165;
            this.btnvoltar.TabStop = false;
            this.btnvoltar.UseVisualStyleBackColor = false;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // FConsultaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 673);
            this.ControlBox = false;
            this.Controls.Add(this.btnconfirmar);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnltitulo);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FConsultaCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Cliente";
            this.Load += new System.EventHandler(this.FConsultaCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnltitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.TextBox ttbcliente;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnpesquisar;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnltitulo;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Button btnfechar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnconfirmar;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_endereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_bairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_telefone1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_telefone2;
    }
}