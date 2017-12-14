namespace MGMPDV
{
    partial class FCaixa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtpdata = new System.Windows.Forms.DateTimePicker();
            this.btncancelar = new System.Windows.Forms.Button();
            this.grid = new System.Windows.Forms.DataGridView();
            this.selecionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cai_numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cai_datainicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cai_horainicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cai_valorinicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fun_abertura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cai_datafinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cai_horafinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cai_valorfinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fun_fechamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cai_informacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnltitulo = new System.Windows.Forms.Panel();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.btnfechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.pnltitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpdata
            // 
            this.dtpdata.CalendarFont = new System.Drawing.Font("Courier New", 11.25F);
            this.dtpdata.Font = new System.Drawing.Font("Courier New", 11.25F);
            this.dtpdata.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdata.Location = new System.Drawing.Point(844, 56);
            this.dtpdata.Name = "dtpdata";
            this.dtpdata.Size = new System.Drawing.Size(172, 24);
            this.dtpdata.TabIndex = 138;
            this.dtpdata.ValueChanged += new System.EventHandler(this.dtpdata_ValueChanged);
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(112)))));
            this.btncancelar.BackgroundImage = global::MGMPDV.Properties.Resources.voltar2;
            this.btncancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncancelar.FlatAppearance.BorderSize = 0;
            this.btncancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btncancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.ForeColor = System.Drawing.Color.White;
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncancelar.Location = new System.Drawing.Point(1212, 536);
            this.btncancelar.Margin = new System.Windows.Forms.Padding(0);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(45, 45);
            this.btncancelar.TabIndex = 139;
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btnfechar_Click);
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.AllowUserToResizeColumns = false;
            this.grid.AllowUserToResizeRows = false;
            this.grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(169)))));
            this.grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(169)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid.ColumnHeadersHeight = 33;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selecionar,
            this.cai_numero,
            this.cai_datainicial,
            this.cai_horainicial,
            this.cai_valorinicial,
            this.fun_abertura,
            this.cai_datafinal,
            this.cai_horafinal,
            this.cai_valorfinal,
            this.fun_fechamento,
            this.cai_informacao});
            this.grid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grid.EnableHeadersVisualStyles = false;
            this.grid.Location = new System.Drawing.Point(1, 83);
            this.grid.MultiSelect = false;
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowHeadersVisible = false;
            this.grid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(169)))));
            this.grid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.grid.RowTemplate.Height = 34;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.grid.Size = new System.Drawing.Size(1024, 448);
            this.grid.TabIndex = 140;
            this.grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellClick);
            this.grid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellDoubleClick);
            // 
            // selecionar
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle2.NullValue = "Selecionar";
            this.selecionar.DefaultCellStyle = dataGridViewCellStyle2;
            this.selecionar.HeaderText = "Selecionar";
            this.selecionar.Name = "selecionar";
            this.selecionar.ReadOnly = true;
            this.selecionar.Width = 70;
            // 
            // cai_numero
            // 
            this.cai_numero.DataPropertyName = "cai_numero";
            this.cai_numero.HeaderText = "Cx. Número";
            this.cai_numero.Name = "cai_numero";
            this.cai_numero.ReadOnly = true;
            this.cai_numero.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cai_numero.Width = 50;
            // 
            // cai_datainicial
            // 
            this.cai_datainicial.DataPropertyName = "cai_datainicial";
            this.cai_datainicial.HeaderText = "Dt. Abertura";
            this.cai_datainicial.Name = "cai_datainicial";
            this.cai_datainicial.ReadOnly = true;
            this.cai_datainicial.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cai_datainicial.Width = 70;
            // 
            // cai_horainicial
            // 
            this.cai_horainicial.DataPropertyName = "cai_horainicial";
            dataGridViewCellStyle3.Format = "T";
            dataGridViewCellStyle3.NullValue = null;
            this.cai_horainicial.DefaultCellStyle = dataGridViewCellStyle3;
            this.cai_horainicial.HeaderText = "Hr. Abertura";
            this.cai_horainicial.Name = "cai_horainicial";
            this.cai_horainicial.ReadOnly = true;
            this.cai_horainicial.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cai_horainicial.Width = 70;
            // 
            // cai_valorinicial
            // 
            this.cai_valorinicial.DataPropertyName = "cai_valorinicial";
            dataGridViewCellStyle4.Format = "00.00";
            this.cai_valorinicial.DefaultCellStyle = dataGridViewCellStyle4;
            this.cai_valorinicial.HeaderText = "Vlr. Abertura";
            this.cai_valorinicial.Name = "cai_valorinicial";
            this.cai_valorinicial.ReadOnly = true;
            this.cai_valorinicial.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cai_valorinicial.Width = 80;
            // 
            // fun_abertura
            // 
            this.fun_abertura.DataPropertyName = "fun_abertura";
            this.fun_abertura.HeaderText = "Funcionário de Abertura";
            this.fun_abertura.Name = "fun_abertura";
            this.fun_abertura.ReadOnly = true;
            this.fun_abertura.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.fun_abertura.Width = 150;
            // 
            // cai_datafinal
            // 
            this.cai_datafinal.DataPropertyName = "cai_datafinal";
            this.cai_datafinal.HeaderText = "Dt. Fechamento";
            this.cai_datafinal.Name = "cai_datafinal";
            this.cai_datafinal.ReadOnly = true;
            this.cai_datafinal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cai_datafinal.Width = 70;
            // 
            // cai_horafinal
            // 
            this.cai_horafinal.DataPropertyName = "cai_horafinal";
            dataGridViewCellStyle5.Format = "T";
            dataGridViewCellStyle5.NullValue = null;
            this.cai_horafinal.DefaultCellStyle = dataGridViewCellStyle5;
            this.cai_horafinal.HeaderText = "Hr. Fechamento";
            this.cai_horafinal.Name = "cai_horafinal";
            this.cai_horafinal.ReadOnly = true;
            this.cai_horafinal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cai_horafinal.Width = 70;
            // 
            // cai_valorfinal
            // 
            this.cai_valorfinal.DataPropertyName = "cai_valorfinal";
            dataGridViewCellStyle6.Format = "00.00";
            dataGridViewCellStyle6.NullValue = "0";
            this.cai_valorfinal.DefaultCellStyle = dataGridViewCellStyle6;
            this.cai_valorfinal.HeaderText = "Vlr. Fechamento";
            this.cai_valorfinal.Name = "cai_valorfinal";
            this.cai_valorfinal.ReadOnly = true;
            this.cai_valorfinal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cai_valorfinal.Width = 90;
            // 
            // fun_fechamento
            // 
            this.fun_fechamento.DataPropertyName = "fun_fechamento";
            this.fun_fechamento.HeaderText = "Funcionário de Fechamento";
            this.fun_fechamento.Name = "fun_fechamento";
            this.fun_fechamento.ReadOnly = true;
            this.fun_fechamento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.fun_fechamento.Width = 150;
            // 
            // cai_informacao
            // 
            this.cai_informacao.DataPropertyName = "cai_informacao";
            this.cai_informacao.HeaderText = "Informações";
            this.cai_informacao.Name = "cai_informacao";
            this.cai_informacao.ReadOnly = true;
            this.cai_informacao.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cai_informacao.Width = 350;
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
            this.pnltitulo.Size = new System.Drawing.Size(1024, 24);
            this.pnltitulo.TabIndex = 141;
            // 
            // lbltitulo
            // 
            this.lbltitulo.BackColor = System.Drawing.Color.Transparent;
            this.lbltitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbltitulo.Font = new System.Drawing.Font("Courier New", 13F, System.Drawing.FontStyle.Bold);
            this.lbltitulo.ForeColor = System.Drawing.Color.White;
            this.lbltitulo.Location = new System.Drawing.Point(2, 2);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(1001, 20);
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
            this.btnfechar.Location = new System.Drawing.Point(1003, 2);
            this.btnfechar.Margin = new System.Windows.Forms.Padding(0);
            this.btnfechar.Name = "btnfechar";
            this.btnfechar.Size = new System.Drawing.Size(19, 20);
            this.btnfechar.TabIndex = 0;
            this.btnfechar.UseVisualStyleBackColor = false;
            this.btnfechar.Click += new System.EventHandler(this.btnfechar_Click);
            // 
            // FCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(112)))));
            this.ClientSize = new System.Drawing.Size(1024, 587);
            this.Controls.Add(this.pnltitulo);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.dtpdata);
            this.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caixa";
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.pnltitulo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpdata;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Panel pnltitulo;
        private System.Windows.Forms.Button btnfechar;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.DataGridViewButtonColumn selecionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cai_numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn cai_datainicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn cai_horainicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn cai_valorinicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn fun_abertura;
        private System.Windows.Forms.DataGridViewTextBoxColumn cai_datafinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn cai_horafinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn cai_valorfinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn fun_fechamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn cai_informacao;
    }
}