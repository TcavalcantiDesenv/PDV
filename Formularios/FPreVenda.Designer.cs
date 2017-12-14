namespace MGMPDV.Formularios
{
    partial class FPreVenda
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btncliente = new System.Windows.Forms.Button();
            this.btntodos = new System.Windows.Forms.Button();
            this.grid = new System.Windows.Forms.DataGridView();
            this.gcli_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gven_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gven_desconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gven_data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gven_hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnadicionar = new System.Windows.Forms.Button();
            this.pnltitulo = new System.Windows.Forms.Panel();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.btnsair = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.listvenda = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnltitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btncliente
            // 
            this.btncliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btncliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncliente.Font = new System.Drawing.Font("Courier New", 15F, System.Drawing.FontStyle.Bold);
            this.btncliente.ForeColor = System.Drawing.Color.White;
            this.btncliente.Location = new System.Drawing.Point(149, 19);
            this.btncliente.Name = "btncliente";
            this.btncliente.Size = new System.Drawing.Size(584, 45);
            this.btncliente.TabIndex = 1;
            this.btncliente.Text = "Cliente";
            this.btncliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncliente.UseVisualStyleBackColor = false;
            this.btncliente.Click += new System.EventHandler(this.btncliente_Click);
            // 
            // btntodos
            // 
            this.btntodos.BackColor = System.Drawing.Color.Transparent;
            this.btntodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntodos.Font = new System.Drawing.Font("Courier New", 15F, System.Drawing.FontStyle.Bold);
            this.btntodos.ForeColor = System.Drawing.Color.White;
            this.btntodos.Location = new System.Drawing.Point(13, 19);
            this.btntodos.Name = "btntodos";
            this.btntodos.Size = new System.Drawing.Size(130, 45);
            this.btntodos.TabIndex = 1;
            this.btntodos.Text = "Todos";
            this.btntodos.UseVisualStyleBackColor = false;
            this.btntodos.Click += new System.EventHandler(this.btntodos_Click);
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.BackgroundColor = System.Drawing.Color.White;
            this.grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Courier New", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid.ColumnHeadersHeight = 50;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gcli_nome,
            this.gven_total,
            this.gven_desconto,
            this.gven_data,
            this.gven_hora});
            this.grid.EnableHeadersVisualStyles = false;
            this.grid.Location = new System.Drawing.Point(-1, 187);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowHeadersVisible = false;
            this.grid.RowTemplate.Height = 40;
            this.grid.Size = new System.Drawing.Size(803, 340);
            this.grid.TabIndex = 83;
            this.grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellContentClick);
            this.grid.DoubleClick += new System.EventHandler(this.grid_DoubleClick);
            // 
            // gcli_nome
            // 
            this.gcli_nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gcli_nome.DataPropertyName = "cli_nome";
            this.gcli_nome.HeaderText = "Cliente";
            this.gcli_nome.Name = "gcli_nome";
            this.gcli_nome.ReadOnly = true;
            // 
            // gven_total
            // 
            this.gven_total.DataPropertyName = "ven_total";
            dataGridViewCellStyle2.Format = "00.00";
            this.gven_total.DefaultCellStyle = dataGridViewCellStyle2;
            this.gven_total.HeaderText = "Total";
            this.gven_total.Name = "gven_total";
            this.gven_total.ReadOnly = true;
            this.gven_total.Width = 130;
            // 
            // gven_desconto
            // 
            this.gven_desconto.DataPropertyName = "ven_desconto";
            dataGridViewCellStyle3.Format = "00.00";
            this.gven_desconto.DefaultCellStyle = dataGridViewCellStyle3;
            this.gven_desconto.HeaderText = "Desconto";
            this.gven_desconto.Name = "gven_desconto";
            this.gven_desconto.ReadOnly = true;
            this.gven_desconto.Width = 130;
            // 
            // gven_data
            // 
            this.gven_data.DataPropertyName = "ven_data";
            this.gven_data.HeaderText = "Data";
            this.gven_data.Name = "gven_data";
            this.gven_data.ReadOnly = true;
            // 
            // gven_hora
            // 
            this.gven_hora.DataPropertyName = "ven_hora";
            dataGridViewCellStyle4.Format = "T";
            dataGridViewCellStyle4.NullValue = null;
            this.gven_hora.DefaultCellStyle = dataGridViewCellStyle4;
            this.gven_hora.HeaderText = "Hora";
            this.gven_hora.Name = "gven_hora";
            this.gven_hora.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.btntodos);
            this.panel1.Controls.Add(this.btnadicionar);
            this.panel1.Controls.Add(this.btncliente);
            this.panel1.Location = new System.Drawing.Point(0, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 81);
            this.panel1.TabIndex = 84;
            // 
            // btnadicionar
            // 
            this.btnadicionar.BackColor = System.Drawing.Color.Transparent;
            this.btnadicionar.BackgroundImage = global::MGMPDV.Properties.Resources.adicionar_fw;
            this.btnadicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnadicionar.FlatAppearance.BorderSize = 0;
            this.btnadicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadicionar.Font = new System.Drawing.Font("Courier New", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnadicionar.ForeColor = System.Drawing.Color.White;
            this.btnadicionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnadicionar.Location = new System.Drawing.Point(739, 19);
            this.btnadicionar.Name = "btnadicionar";
            this.btnadicionar.Size = new System.Drawing.Size(53, 45);
            this.btnadicionar.TabIndex = 82;
            this.btnadicionar.UseVisualStyleBackColor = false;
            this.btnadicionar.Click += new System.EventHandler(this.btnadicionar_Click);
            // 
            // pnltitulo
            // 
            this.pnltitulo.BackColor = System.Drawing.Color.Transparent;
            this.pnltitulo.Controls.Add(this.lbltitulo);
            this.pnltitulo.Controls.Add(this.btnsair);
            this.pnltitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnltitulo.Location = new System.Drawing.Point(0, 0);
            this.pnltitulo.Name = "pnltitulo";
            this.pnltitulo.Padding = new System.Windows.Forms.Padding(2);
            this.pnltitulo.Size = new System.Drawing.Size(800, 22);
            this.pnltitulo.TabIndex = 162;
            // 
            // lbltitulo
            // 
            this.lbltitulo.BackColor = System.Drawing.Color.Transparent;
            this.lbltitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbltitulo.Font = new System.Drawing.Font("Courier New", 13F, System.Drawing.FontStyle.Bold);
            this.lbltitulo.ForeColor = System.Drawing.Color.White;
            this.lbltitulo.Location = new System.Drawing.Point(2, 2);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(780, 18);
            this.lbltitulo.TabIndex = 76;
            this.lbltitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnsair
            // 
            this.btnsair.BackColor = System.Drawing.Color.Transparent;
            this.btnsair.BackgroundImage = global::MGMPDV.Properties.Resources.fexar;
            this.btnsair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsair.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnsair.FlatAppearance.BorderSize = 0;
            this.btnsair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnsair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnsair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsair.Font = new System.Drawing.Font("Courier New", 13F);
            this.btnsair.ForeColor = System.Drawing.Color.White;
            this.btnsair.Location = new System.Drawing.Point(782, 2);
            this.btnsair.Margin = new System.Windows.Forms.Padding(0);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(16, 18);
            this.btnsair.TabIndex = 0;
            this.btnsair.UseVisualStyleBackColor = false;
            this.btnsair.Click += new System.EventHandler(this.btnfechar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 20F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(319, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 32);
            this.label2.TabIndex = 163;
            this.label2.Text = "Pré Venda";
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
            this.btnvoltar.Location = new System.Drawing.Point(739, 543);
            this.btnvoltar.Margin = new System.Windows.Forms.Padding(0);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(46, 48);
            this.btnvoltar.TabIndex = 164;
            this.btnvoltar.TabStop = false;
            this.btnvoltar.UseVisualStyleBackColor = false;
            this.btnvoltar.Click += new System.EventHandler(this.btnfechar_Click);
            // 
            // listvenda
            // 
            this.listvenda.BackColor = System.Drawing.SystemColors.Info;
            this.listvenda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listvenda.Font = new System.Drawing.Font("Courier New", 10.8F);
            this.listvenda.FormattingEnabled = true;
            this.listvenda.ItemHeight = 17;
            this.listvenda.Location = new System.Drawing.Point(801, 96);
            this.listvenda.Name = "listvenda";
            this.listvenda.Size = new System.Drawing.Size(398, 408);
            this.listvenda.TabIndex = 166;
            // 
            // FPreVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.ControlBox = false;
            this.Controls.Add(this.listvenda);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnltitulo);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FPreVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pré Venda";
            this.Load += new System.EventHandler(this.FPreVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pnltitulo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btncliente;
        private System.Windows.Forms.Button btntodos;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcli_nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn gven_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn gven_desconto;
        private System.Windows.Forms.DataGridViewTextBoxColumn gven_data;
        private System.Windows.Forms.DataGridViewTextBoxColumn gven_hora;
        private System.Windows.Forms.Button btnadicionar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnltitulo;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.ListBox listvenda;
    }
}