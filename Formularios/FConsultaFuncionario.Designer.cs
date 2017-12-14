namespace MGMPDV
{
    partial class FConsultaFuncionario
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbbfiltro = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnpesquisar = new System.Windows.Forms.Button();
            this.ttbpesquisar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fun_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fun_rg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fun_cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fun_telefone1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fun_telefone2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fun_telefone3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.fun_nome,
            this.fun_rg,
            this.fun_cpf,
            this.fun_telefone1,
            this.fun_telefone2,
            this.fun_telefone3});
            this.grid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grid.Location = new System.Drawing.Point(12, 87);
            this.grid.MultiSelect = false;
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowHeadersVisible = false;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(906, 402);
            this.grid.TabIndex = 38;
            this.grid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbbfiltro);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnpesquisar);
            this.panel1.Controls.Add(this.ttbpesquisar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(906, 68);
            this.panel1.TabIndex = 37;
            // 
            // cbbfiltro
            // 
            this.cbbfiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbfiltro.FormattingEnabled = true;
            this.cbbfiltro.Items.AddRange(new object[] {
            "Nome",
            "RG",
            "CPF"});
            this.cbbfiltro.Location = new System.Drawing.Point(628, 28);
            this.cbbfiltro.Name = "cbbfiltro";
            this.cbbfiltro.Size = new System.Drawing.Size(258, 22);
            this.cbbfiltro.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(623, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 14);
            this.label2.TabIndex = 7;
            this.label2.Text = "Filtro";
            // 
            // btnpesquisar
            // 
            this.btnpesquisar.Image = global::MGMPDV.Properties.Resources.view;
            this.btnpesquisar.Location = new System.Drawing.Point(547, 23);
            this.btnpesquisar.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.btnpesquisar.Name = "btnpesquisar";
            this.btnpesquisar.Size = new System.Drawing.Size(35, 29);
            this.btnpesquisar.TabIndex = 1;
            this.btnpesquisar.UseVisualStyleBackColor = true;
            this.btnpesquisar.Click += new System.EventHandler(this.button2_Click);
            // 
            // ttbpesquisar
            // 
            this.ttbpesquisar.Location = new System.Drawing.Point(7, 28);
            this.ttbpesquisar.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.ttbpesquisar.Name = "ttbpesquisar";
            this.ttbpesquisar.Size = new System.Drawing.Size(525, 20);
            this.ttbpesquisar.TabIndex = 0;
            this.ttbpesquisar.TextChanged += new System.EventHandler(this.button2_Click);
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
            // fun_nome
            // 
            this.fun_nome.DataPropertyName = "fun_nome";
            this.fun_nome.HeaderText = "Nome";
            this.fun_nome.Name = "fun_nome";
            this.fun_nome.ReadOnly = true;
            this.fun_nome.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.fun_nome.Width = 300;
            // 
            // fun_rg
            // 
            this.fun_rg.DataPropertyName = "fun_rg";
            this.fun_rg.HeaderText = "RG";
            this.fun_rg.Name = "fun_rg";
            this.fun_rg.ReadOnly = true;
            this.fun_rg.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.fun_rg.Width = 150;
            // 
            // fun_cpf
            // 
            this.fun_cpf.DataPropertyName = "fun_cpf";
            this.fun_cpf.HeaderText = "CPF";
            this.fun_cpf.Name = "fun_cpf";
            this.fun_cpf.ReadOnly = true;
            this.fun_cpf.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.fun_cpf.Width = 150;
            // 
            // fun_telefone1
            // 
            this.fun_telefone1.DataPropertyName = "fun_telefone1";
            this.fun_telefone1.HeaderText = "Telefone";
            this.fun_telefone1.Name = "fun_telefone1";
            this.fun_telefone1.ReadOnly = true;
            this.fun_telefone1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.fun_telefone1.Width = 150;
            // 
            // fun_telefone2
            // 
            this.fun_telefone2.DataPropertyName = "fun_telefone2";
            this.fun_telefone2.HeaderText = "Telefone";
            this.fun_telefone2.Name = "fun_telefone2";
            this.fun_telefone2.ReadOnly = true;
            this.fun_telefone2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.fun_telefone2.Width = 150;
            // 
            // fun_telefone3
            // 
            this.fun_telefone3.DataPropertyName = "fun_telefone3";
            this.fun_telefone3.HeaderText = "Telefone";
            this.fun_telefone3.Name = "fun_telefone3";
            this.fun_telefone3.ReadOnly = true;
            this.fun_telefone3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.fun_telefone3.Width = 150;
            // 
            // FConsultaFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 503);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FConsultaFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Funcionário";
            this.Load += new System.EventHandler(this.FConsultaCliente_Load);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn fun_nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn fun_rg;
        private System.Windows.Forms.DataGridViewTextBoxColumn fun_cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn fun_telefone1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fun_telefone2;
        private System.Windows.Forms.DataGridViewTextBoxColumn fun_telefone3;

    }
}