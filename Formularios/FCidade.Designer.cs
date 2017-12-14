namespace MGMPDV
{
    partial class FCidade
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
            this.label1 = new System.Windows.Forms.Label();
            this.ttbnome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ttbuf = new System.Windows.Forms.TextBox();
            this.pnlcampos = new System.Windows.Forms.GroupBox();
            this.btnnovo = new System.Windows.Forms.Button();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.btnpesquisar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pnlcampos.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome *";
            // 
            // ttbnome
            // 
            this.ttbnome.Location = new System.Drawing.Point(13, 41);
            this.ttbnome.MaxLength = 100;
            this.ttbnome.Name = "ttbnome";
            this.ttbnome.Size = new System.Drawing.Size(320, 23);
            this.ttbnome.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(351, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "UF *";
            // 
            // ttbuf
            // 
            this.ttbuf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ttbuf.Location = new System.Drawing.Point(355, 41);
            this.ttbuf.MaxLength = 2;
            this.ttbuf.Name = "ttbuf";
            this.ttbuf.Size = new System.Drawing.Size(67, 23);
            this.ttbuf.TabIndex = 11;
            // 
            // pnlcampos
            // 
            this.pnlcampos.Controls.Add(this.ttbuf);
            this.pnlcampos.Controls.Add(this.label2);
            this.pnlcampos.Controls.Add(this.ttbnome);
            this.pnlcampos.Controls.Add(this.label1);
            this.pnlcampos.Location = new System.Drawing.Point(12, 84);
            this.pnlcampos.Name = "pnlcampos";
            this.pnlcampos.Size = new System.Drawing.Size(790, 78);
            this.pnlcampos.TabIndex = 33;
            this.pnlcampos.TabStop = false;
            this.pnlcampos.Text = "Cidade";
            // 
            // btnnovo
            // 
            this.btnnovo.Image = global::MGMPDV.Properties.Resources.add21;
            this.btnnovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnnovo.Location = new System.Drawing.Point(12, 22);
            this.btnnovo.Name = "btnnovo";
            this.btnnovo.Size = new System.Drawing.Size(100, 29);
            this.btnnovo.TabIndex = 8;
            this.btnnovo.Text = "Novo";
            this.btnnovo.UseVisualStyleBackColor = true;
            this.btnnovo.Click += new System.EventHandler(this.btnnovo_Click);
            // 
            // btnsalvar
            // 
            this.btnsalvar.Image = global::MGMPDV.Properties.Resources.check2;
            this.btnsalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsalvar.Location = new System.Drawing.Point(113, 22);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(100, 29);
            this.btnsalvar.TabIndex = 9;
            this.btnsalvar.Text = "Salvar";
            this.btnsalvar.UseVisualStyleBackColor = true;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Image = global::MGMPDV.Properties.Resources.delete2;
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncancelar.Location = new System.Drawing.Point(215, 22);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(114, 29);
            this.btncancelar.TabIndex = 10;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnexcluir
            // 
            this.btnexcluir.Image = global::MGMPDV.Properties.Resources.forbidden;
            this.btnexcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnexcluir.Location = new System.Drawing.Point(330, 22);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(108, 29);
            this.btnexcluir.TabIndex = 11;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // btnsair
            // 
            this.btnsair.Image = global::MGMPDV.Properties.Resources.exit;
            this.btnsair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsair.Location = new System.Drawing.Point(668, 22);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(113, 29);
            this.btnsair.TabIndex = 13;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // btnpesquisar
            // 
            this.btnpesquisar.Image = global::MGMPDV.Properties.Resources.view;
            this.btnpesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnpesquisar.Location = new System.Drawing.Point(440, 22);
            this.btnpesquisar.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnpesquisar.Name = "btnpesquisar";
            this.btnpesquisar.Size = new System.Drawing.Size(114, 29);
            this.btnpesquisar.TabIndex = 33;
            this.btnpesquisar.Text = " Pesquisar";
            this.btnpesquisar.UseVisualStyleBackColor = true;
            this.btnpesquisar.Click += new System.EventHandler(this.btnpesquisar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnpesquisar);
            this.groupBox3.Controls.Add(this.btnsair);
            this.groupBox3.Controls.Add(this.btnexcluir);
            this.groupBox3.Controls.Add(this.btncancelar);
            this.groupBox3.Controls.Add(this.btnsalvar);
            this.groupBox3.Controls.Add(this.btnnovo);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(790, 66);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            // 
            // FCidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 180);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.pnlcampos);
            this.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FCidade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cidades";
            this.pnlcampos.ResumeLayout(false);
            this.pnlcampos.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ttbnome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ttbuf;
        private System.Windows.Forms.GroupBox pnlcampos;
        private System.Windows.Forms.Button btnnovo;
        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Button btnpesquisar;
        private System.Windows.Forms.GroupBox groupBox3;


    }
}