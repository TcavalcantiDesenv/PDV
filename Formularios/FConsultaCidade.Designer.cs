namespace MGMPDV
{
    partial class FConsultaCidade
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
            this.grid = new System.Windows.Forms.DataGridView();
            this.cid_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cid_uf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbbfiltro = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnpesquisar = new System.Windows.Forms.Button();
            this.ttbpesquisar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cid_nome,
            this.cid_uf});
            this.grid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grid.Location = new System.Drawing.Point(12, 82);
            this.grid.MultiSelect = false;
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowHeadersVisible = false;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(704, 378);
            this.grid.TabIndex = 38;
            this.grid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellDoubleClick);
            // 
            // cid_nome
            // 
            this.cid_nome.DataPropertyName = "cid_nome";
            this.cid_nome.HeaderText = "Nome";
            this.cid_nome.Name = "cid_nome";
            this.cid_nome.ReadOnly = true;
            this.cid_nome.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.cid_nome.Width = 300;
            // 
            // cid_uf
            // 
            this.cid_uf.DataPropertyName = "cid_uf";
            this.cid_uf.HeaderText = "UF";
            this.cid_uf.Name = "cid_uf";
            this.cid_uf.ReadOnly = true;
            this.cid_uf.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbbfiltro);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnpesquisar);
            this.panel1.Controls.Add(this.ttbpesquisar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(704, 64);
            this.panel1.TabIndex = 37;
            // 
            // cbbfiltro
            // 
            this.cbbfiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbfiltro.FormattingEnabled = true;
            this.cbbfiltro.Items.AddRange(new object[] {
            "Nome"});
            this.cbbfiltro.Location = new System.Drawing.Point(423, 26);
            this.cbbfiltro.Name = "cbbfiltro";
            this.cbbfiltro.Size = new System.Drawing.Size(258, 20);
            this.cbbfiltro.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(418, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 14);
            this.label2.TabIndex = 7;
            this.label2.Text = "Filtro";
            // 
            // btnpesquisar
            // 
            this.btnpesquisar.Image = global::MGMPDV.Properties.Resources.view;
            this.btnpesquisar.Location = new System.Drawing.Point(366, 23);
            this.btnpesquisar.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.btnpesquisar.Name = "btnpesquisar";
            this.btnpesquisar.Size = new System.Drawing.Size(35, 27);
            this.btnpesquisar.TabIndex = 1;
            this.btnpesquisar.UseVisualStyleBackColor = true;
            this.btnpesquisar.Click += new System.EventHandler(this.btnpesquisar_Click);
            // 
            // ttbpesquisar
            // 
            this.ttbpesquisar.Location = new System.Drawing.Point(7, 26);
            this.ttbpesquisar.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.ttbpesquisar.Name = "ttbpesquisar";
            this.ttbpesquisar.Size = new System.Drawing.Size(356, 19);
            this.ttbpesquisar.TabIndex = 0;
            this.ttbpesquisar.TextChanged += new System.EventHandler(this.btnpesquisar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 14);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pesquisar";
            // 
            // FConsultaCidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 472);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FConsultaCidade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Cidade";
            this.Load += new System.EventHandler(this.btnpesquisar_Click);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbbfiltro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnpesquisar;
        private System.Windows.Forms.TextBox ttbpesquisar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cid_nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn cid_uf;
    }
}