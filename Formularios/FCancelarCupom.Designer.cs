namespace MGMPDV.Formularios
{
    partial class FCancelarCupom
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.grid = new System.Windows.Forms.DataGridView();
            this.ven_hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ven_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpdata = new System.Windows.Forms.DateTimePicker();
            this.pnltitulo = new System.Windows.Forms.Panel();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.btnfechar = new System.Windows.Forms.Button();
            this.pnldescricao = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btncancelarvendaaberta = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.pnltitulo.SuspendLayout();
            this.pnldescricao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(114, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 21);
            this.label1.TabIndex = 112;
            this.label1.Text = "Listar Cupom";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(201)))), ((int)(((byte)(202)))));
            this.grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(201)))), ((int)(((byte)(202)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid.ColumnHeadersHeight = 40;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ven_hora,
            this.ven_total,
            this.cli_nome});
            this.grid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grid.EnableHeadersVisualStyles = false;
            this.grid.GridColor = System.Drawing.Color.White;
            this.grid.Location = new System.Drawing.Point(22, 166);
            this.grid.MultiSelect = false;
            this.grid.Name = "grid";
            this.grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Consolas", 8.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grid.RowHeadersVisible = false;
            this.grid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(201)))), ((int)(((byte)(202)))));
            this.grid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.grid.RowTemplate.Height = 24;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.grid.Size = new System.Drawing.Size(813, 362);
            this.grid.TabIndex = 114;
            this.grid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellDoubleClick);
            this.grid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grid_CellFormatting);
            // 
            // ven_hora
            // 
            this.ven_hora.DataPropertyName = "ven_hora";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "T";
            dataGridViewCellStyle2.NullValue = null;
            this.ven_hora.DefaultCellStyle = dataGridViewCellStyle2;
            this.ven_hora.HeaderText = "Hora";
            this.ven_hora.Name = "ven_hora";
            this.ven_hora.ReadOnly = true;
            this.ven_hora.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ven_hora.Width = 150;
            // 
            // ven_total
            // 
            this.ven_total.DataPropertyName = "ven_total";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = "0";
            this.ven_total.DefaultCellStyle = dataGridViewCellStyle3;
            this.ven_total.HeaderText = "Total";
            this.ven_total.Name = "ven_total";
            this.ven_total.ReadOnly = true;
            this.ven_total.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ven_total.Width = 150;
            // 
            // cli_nome
            // 
            this.cli_nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cli_nome.DataPropertyName = "cli_nome";
            this.cli_nome.HeaderText = "Cliente";
            this.cli_nome.Name = "cli_nome";
            this.cli_nome.ReadOnly = true;
            this.cli_nome.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dtpdata
            // 
            this.dtpdata.CalendarFont = new System.Drawing.Font("Courier New", 11.25F);
            this.dtpdata.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.dtpdata.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdata.Location = new System.Drawing.Point(663, 22);
            this.dtpdata.Name = "dtpdata";
            this.dtpdata.Size = new System.Drawing.Size(172, 25);
            this.dtpdata.TabIndex = 115;
            this.dtpdata.ValueChanged += new System.EventHandler(this.dtpdata_ValueChanged);
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
            this.pnltitulo.Size = new System.Drawing.Size(857, 22);
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
            this.lbltitulo.Size = new System.Drawing.Size(837, 18);
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
            this.btnfechar.Location = new System.Drawing.Point(839, 2);
            this.btnfechar.Margin = new System.Windows.Forms.Padding(0);
            this.btnfechar.Name = "btnfechar";
            this.btnfechar.Size = new System.Drawing.Size(16, 18);
            this.btnfechar.TabIndex = 0;
            this.btnfechar.UseVisualStyleBackColor = false;
            this.btnfechar.Click += new System.EventHandler(this.btnfechar_Click);
            // 
            // pnldescricao
            // 
            this.pnldescricao.Controls.Add(this.pictureBox1);
            this.pnldescricao.Controls.Add(this.label4);
            this.pnldescricao.Controls.Add(this.label1);
            this.pnldescricao.Controls.Add(this.dtpdata);
            this.pnldescricao.Location = new System.Drawing.Point(0, 80);
            this.pnldescricao.Name = "pnldescricao";
            this.pnldescricao.Size = new System.Drawing.Size(866, 68);
            this.pnldescricao.TabIndex = 135;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::MGMPDV.Properties.Resources.prévenda_fw;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, -40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 136;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(585, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 21);
            this.label4.TabIndex = 116;
            this.label4.Text = "Data";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(318, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 40);
            this.label3.TabIndex = 112;
            this.label3.Text = "Cupons Emitidos";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.Color.Transparent;
            this.btncancelar.BackgroundImage = global::MGMPDV.Properties.Resources.voltar2;
            this.btncancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncancelar.FlatAppearance.BorderSize = 0;
            this.btncancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btncancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.ForeColor = System.Drawing.Color.White;
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncancelar.Location = new System.Drawing.Point(793, 535);
            this.btncancelar.Margin = new System.Windows.Forms.Padding(0);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(42, 47);
            this.btncancelar.TabIndex = 110;
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btncancelarvendaaberta
            // 
            this.btncancelarvendaaberta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(8)))), ((int)(((byte)(70)))));
            this.btncancelarvendaaberta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncancelarvendaaberta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btncancelarvendaaberta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btncancelarvendaaberta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelarvendaaberta.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelarvendaaberta.ForeColor = System.Drawing.Color.White;
            this.btncancelarvendaaberta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncancelarvendaaberta.Location = new System.Drawing.Point(22, 543);
            this.btncancelarvendaaberta.Margin = new System.Windows.Forms.Padding(0);
            this.btncancelarvendaaberta.Name = "btncancelarvendaaberta";
            this.btncancelarvendaaberta.Size = new System.Drawing.Size(136, 37);
            this.btncancelarvendaaberta.TabIndex = 109;
            this.btncancelarvendaaberta.Text = "Cancelar Cupom";
            this.btncancelarvendaaberta.UseVisualStyleBackColor = false;
            this.btncancelarvendaaberta.Click += new System.EventHandler(this.btncancelarvendaaberta_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::MGMPDV.Properties.Resources.prévenda_fw;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(12, 40);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.TabIndex = 137;
            this.pictureBox2.TabStop = false;
            // 
            // FCancelarCupom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(857, 595);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pnltitulo);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btncancelarvendaaberta);
            this.Controls.Add(this.pnldescricao);
            this.Controls.Add(this.pictureBox2);
            this.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FCancelarCupom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cancelar Cupom";
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.pnltitulo.ResumeLayout(false);
            this.pnldescricao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.DateTimePicker dtpdata;
        private System.Windows.Forms.DataGridViewTextBoxColumn ven_hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn ven_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_nome;
        private System.Windows.Forms.Button btncancelarvendaaberta;
        private System.Windows.Forms.Panel pnltitulo;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Button btnfechar;
        private System.Windows.Forms.Panel pnldescricao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}