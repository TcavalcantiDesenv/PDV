namespace MGMPDV
{
    partial class FEmpresa
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
            this.pnlbotao = new System.Windows.Forms.GroupBox();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.btnalterar = new System.Windows.Forms.Button();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.pnlcampos = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.ttbie = new System.Windows.Forms.TextBox();
            this.ttbcep = new System.Windows.Forms.TextBox();
            this.ttbsite = new System.Windows.Forms.TextBox();
            this.lblsite = new System.Windows.Forms.Label();
            this.ttbuf = new System.Windows.Forms.TextBox();
            this.ttbcidade = new System.Windows.Forms.TextBox();
            this.pblogo = new System.Windows.Forms.PictureBox();
            this.btnpesquisar = new System.Windows.Forms.Button();
            this.ttblogo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ttbcnpj = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ttbemail = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.ttbtelefone3 = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.ttbtelefone2 = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.ttbtelefone1 = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ttbbairro = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ttbnumero = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ttbfantasia = new System.Windows.Forms.TextBox();
            this.ttbendereco = new System.Windows.Forms.TextBox();
            this.ttbrazao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dialog = new System.Windows.Forms.OpenFileDialog();
            this.pnlbotao.SuspendLayout();
            this.pnlcampos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlbotao
            // 
            this.pnlbotao.Controls.Add(this.btncancelar);
            this.pnlbotao.Controls.Add(this.btnsair);
            this.pnlbotao.Controls.Add(this.btnalterar);
            this.pnlbotao.Controls.Add(this.btnsalvar);
            this.pnlbotao.Location = new System.Drawing.Point(12, 12);
            this.pnlbotao.Name = "pnlbotao";
            this.pnlbotao.Size = new System.Drawing.Size(677, 61);
            this.pnlbotao.TabIndex = 33;
            this.pnlbotao.TabStop = false;
            // 
            // btncancelar
            // 
            this.btncancelar.Image = global::MGMPDV.Properties.Resources.delete2;
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncancelar.Location = new System.Drawing.Point(109, 19);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(110, 27);
            this.btncancelar.TabIndex = 2;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnsair
            // 
            this.btnsair.Image = global::MGMPDV.Properties.Resources.exit;
            this.btnsair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsair.Location = new System.Drawing.Point(561, 20);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(97, 27);
            this.btnsair.TabIndex = 6;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // btnalterar
            // 
            this.btnalterar.Image = global::MGMPDV.Properties.Resources.refresh;
            this.btnalterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnalterar.Location = new System.Drawing.Point(561, 19);
            this.btnalterar.Name = "btnalterar";
            this.btnalterar.Size = new System.Drawing.Size(97, 27);
            this.btnalterar.TabIndex = 4;
            this.btnalterar.Text = "Alterar";
            this.btnalterar.UseVisualStyleBackColor = true;
            this.btnalterar.Visible = false;
            // 
            // btnsalvar
            // 
            this.btnsalvar.Image = global::MGMPDV.Properties.Resources.check2;
            this.btnsalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsalvar.Location = new System.Drawing.Point(11, 19);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(98, 27);
            this.btnsalvar.TabIndex = 1;
            this.btnsalvar.Text = "Salvar";
            this.btnsalvar.UseVisualStyleBackColor = true;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // pnlcampos
            // 
            this.pnlcampos.Controls.Add(this.label14);
            this.pnlcampos.Controls.Add(this.ttbie);
            this.pnlcampos.Controls.Add(this.ttbcep);
            this.pnlcampos.Controls.Add(this.ttbsite);
            this.pnlcampos.Controls.Add(this.lblsite);
            this.pnlcampos.Controls.Add(this.ttbuf);
            this.pnlcampos.Controls.Add(this.ttbcidade);
            this.pnlcampos.Controls.Add(this.pblogo);
            this.pnlcampos.Controls.Add(this.btnpesquisar);
            this.pnlcampos.Controls.Add(this.ttblogo);
            this.pnlcampos.Controls.Add(this.label4);
            this.pnlcampos.Controls.Add(this.ttbcnpj);
            this.pnlcampos.Controls.Add(this.label3);
            this.pnlcampos.Controls.Add(this.label8);
            this.pnlcampos.Controls.Add(this.label9);
            this.pnlcampos.Controls.Add(this.ttbemail);
            this.pnlcampos.Controls.Add(this.label15);
            this.pnlcampos.Controls.Add(this.ttbtelefone3);
            this.pnlcampos.Controls.Add(this.label13);
            this.pnlcampos.Controls.Add(this.ttbtelefone2);
            this.pnlcampos.Controls.Add(this.label12);
            this.pnlcampos.Controls.Add(this.ttbtelefone1);
            this.pnlcampos.Controls.Add(this.label11);
            this.pnlcampos.Controls.Add(this.label10);
            this.pnlcampos.Controls.Add(this.ttbbairro);
            this.pnlcampos.Controls.Add(this.label7);
            this.pnlcampos.Controls.Add(this.ttbnumero);
            this.pnlcampos.Controls.Add(this.label6);
            this.pnlcampos.Controls.Add(this.ttbfantasia);
            this.pnlcampos.Controls.Add(this.ttbendereco);
            this.pnlcampos.Controls.Add(this.ttbrazao);
            this.pnlcampos.Controls.Add(this.label2);
            this.pnlcampos.Controls.Add(this.label5);
            this.pnlcampos.Controls.Add(this.label1);
            this.pnlcampos.Location = new System.Drawing.Point(12, 76);
            this.pnlcampos.Name = "pnlcampos";
            this.pnlcampos.Size = new System.Drawing.Size(676, 332);
            this.pnlcampos.TabIndex = 32;
            this.pnlcampos.TabStop = false;
            this.pnlcampos.Text = "Empresa";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(533, 18);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 14);
            this.label14.TabIndex = 50;
            this.label14.Text = "Ins. Estadual";
            // 
            // ttbie
            // 
            this.ttbie.Location = new System.Drawing.Point(530, 38);
            this.ttbie.Name = "ttbie";
            this.ttbie.Size = new System.Drawing.Size(128, 19);
            this.ttbie.TabIndex = 49;
            // 
            // ttbcep
            // 
            this.ttbcep.Location = new System.Drawing.Point(571, 81);
            this.ttbcep.MaxLength = 9;
            this.ttbcep.Name = "ttbcep";
            this.ttbcep.Size = new System.Drawing.Size(87, 19);
            this.ttbcep.TabIndex = 6;
            // 
            // ttbsite
            // 
            this.ttbsite.Location = new System.Drawing.Point(11, 284);
            this.ttbsite.MaxLength = 50;
            this.ttbsite.Name = "ttbsite";
            this.ttbsite.Size = new System.Drawing.Size(396, 19);
            this.ttbsite.TabIndex = 14;
            this.ttbsite.Visible = false;
            // 
            // lblsite
            // 
            this.lblsite.AutoSize = true;
            this.lblsite.Location = new System.Drawing.Point(8, 263);
            this.lblsite.Name = "lblsite";
            this.lblsite.Size = new System.Drawing.Size(35, 14);
            this.lblsite.TabIndex = 48;
            this.lblsite.Text = "Site";
            this.lblsite.Visible = false;
            // 
            // ttbuf
            // 
            this.ttbuf.Location = new System.Drawing.Point(292, 130);
            this.ttbuf.MaxLength = 2;
            this.ttbuf.Name = "ttbuf";
            this.ttbuf.Size = new System.Drawing.Size(53, 19);
            this.ttbuf.TabIndex = 8;
            // 
            // ttbcidade
            // 
            this.ttbcidade.Location = new System.Drawing.Point(11, 130);
            this.ttbcidade.MaxLength = 50;
            this.ttbcidade.Name = "ttbcidade";
            this.ttbcidade.Size = new System.Drawing.Size(275, 19);
            this.ttbcidade.TabIndex = 7;
            // 
            // pblogo
            // 
            this.pblogo.Location = new System.Drawing.Point(481, 192);
            this.pblogo.Name = "pblogo";
            this.pblogo.Size = new System.Drawing.Size(171, 107);
            this.pblogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pblogo.TabIndex = 41;
            this.pblogo.TabStop = false;
            this.pblogo.Visible = false;
            // 
            // btnpesquisar
            // 
            this.btnpesquisar.Image = global::MGMPDV.Properties.Resources.view;
            this.btnpesquisar.Location = new System.Drawing.Point(413, 219);
            this.btnpesquisar.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.btnpesquisar.Name = "btnpesquisar";
            this.btnpesquisar.Size = new System.Drawing.Size(36, 33);
            this.btnpesquisar.TabIndex = 13;
            this.btnpesquisar.UseVisualStyleBackColor = true;
            this.btnpesquisar.Visible = false;
            this.btnpesquisar.Click += new System.EventHandler(this.btnpesquisar_Click);
            // 
            // ttblogo
            // 
            this.ttblogo.Location = new System.Drawing.Point(11, 230);
            this.ttblogo.MaxLength = 50;
            this.ttblogo.Name = "ttblogo";
            this.ttblogo.Size = new System.Drawing.Size(396, 19);
            this.ttblogo.TabIndex = 38;
            this.ttblogo.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 14);
            this.label4.TabIndex = 39;
            this.label4.Text = "Logo";
            this.label4.Visible = false;
            // 
            // ttbcnpj
            // 
            this.ttbcnpj.Location = new System.Drawing.Point(368, 38);
            this.ttbcnpj.MaxLength = 30;
            this.ttbcnpj.Name = "ttbcnpj";
            this.ttbcnpj.Size = new System.Drawing.Size(158, 19);
            this.ttbcnpj.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(365, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 14);
            this.label3.TabIndex = 37;
            this.label3.Text = "CNPJ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(289, 109);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 14);
            this.label8.TabIndex = 35;
            this.label8.Text = "UF";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 109);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 14);
            this.label9.TabIndex = 34;
            this.label9.Text = "Cidade";
            // 
            // ttbemail
            // 
            this.ttbemail.Location = new System.Drawing.Point(351, 130);
            this.ttbemail.MaxLength = 50;
            this.ttbemail.Name = "ttbemail";
            this.ttbemail.Size = new System.Drawing.Size(307, 19);
            this.ttbemail.TabIndex = 9;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(351, 109);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 14);
            this.label15.TabIndex = 27;
            this.label15.Text = "E-mail";
            // 
            // ttbtelefone3
            // 
            this.ttbtelefone3.Location = new System.Drawing.Point(253, 181);
            this.ttbtelefone3.Mask = "(99) 00000-0000";
            this.ttbtelefone3.Name = "ttbtelefone3";
            this.ttbtelefone3.Size = new System.Drawing.Size(115, 19);
            this.ttbtelefone3.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(250, 161);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 14);
            this.label13.TabIndex = 23;
            this.label13.Text = "Telefone";
            // 
            // ttbtelefone2
            // 
            this.ttbtelefone2.Location = new System.Drawing.Point(132, 181);
            this.ttbtelefone2.Mask = "(99) 00000-0000";
            this.ttbtelefone2.Name = "ttbtelefone2";
            this.ttbtelefone2.Size = new System.Drawing.Size(115, 19);
            this.ttbtelefone2.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(129, 161);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 14);
            this.label12.TabIndex = 23;
            this.label12.Text = "Telefone";
            // 
            // ttbtelefone1
            // 
            this.ttbtelefone1.Location = new System.Drawing.Point(11, 181);
            this.ttbtelefone1.Mask = "(99) 00000-0000";
            this.ttbtelefone1.Name = "ttbtelefone1";
            this.ttbtelefone1.Size = new System.Drawing.Size(115, 19);
            this.ttbtelefone1.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 161);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 14);
            this.label11.TabIndex = 23;
            this.label11.Text = "Telefone";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(570, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 14);
            this.label10.TabIndex = 21;
            this.label10.Text = "CEP";
            // 
            // ttbbairro
            // 
            this.ttbbairro.Location = new System.Drawing.Point(373, 81);
            this.ttbbairro.MaxLength = 50;
            this.ttbbairro.Name = "ttbbairro";
            this.ttbbairro.Size = new System.Drawing.Size(194, 19);
            this.ttbbairro.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(370, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 14);
            this.label7.TabIndex = 15;
            this.label7.Text = "Bairro";
            // 
            // ttbnumero
            // 
            this.ttbnumero.Location = new System.Drawing.Point(292, 81);
            this.ttbnumero.MaxLength = 10;
            this.ttbnumero.Name = "ttbnumero";
            this.ttbnumero.Size = new System.Drawing.Size(76, 19);
            this.ttbnumero.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(289, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 14);
            this.label6.TabIndex = 13;
            this.label6.Text = "Número";
            // 
            // ttbfantasia
            // 
            this.ttbfantasia.Location = new System.Drawing.Point(197, 38);
            this.ttbfantasia.MaxLength = 30;
            this.ttbfantasia.Name = "ttbfantasia";
            this.ttbfantasia.Size = new System.Drawing.Size(167, 19);
            this.ttbfantasia.TabIndex = 1;
            // 
            // ttbendereco
            // 
            this.ttbendereco.Location = new System.Drawing.Point(11, 81);
            this.ttbendereco.MaxLength = 100;
            this.ttbendereco.Name = "ttbendereco";
            this.ttbendereco.Size = new System.Drawing.Size(275, 19);
            this.ttbendereco.TabIndex = 3;
            // 
            // ttbrazao
            // 
            this.ttbrazao.Location = new System.Drawing.Point(11, 38);
            this.ttbrazao.MaxLength = 100;
            this.ttbrazao.Name = "ttbrazao";
            this.ttbrazao.Size = new System.Drawing.Size(181, 19);
            this.ttbrazao.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fantasia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 14);
            this.label5.TabIndex = 4;
            this.label5.Text = "Endereço";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 14);
            this.label1.TabIndex = 4;
            this.label1.Text = "Razão Social";
            // 
            // dialog
            // 
            this.dialog.FileName = "openFileDialog1";
            // 
            // FEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 423);
            this.ControlBox = false;
            this.Controls.Add(this.pnlbotao);
            this.Controls.Add(this.pnlcampos);
            this.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empresa";
            this.pnlbotao.ResumeLayout(false);
            this.pnlcampos.ResumeLayout(false);
            this.pnlcampos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox pnlbotao;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Button btnalterar;
        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.GroupBox pnlcampos;
        private System.Windows.Forms.TextBox ttbcnpj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ttbemail;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.MaskedTextBox ttbtelefone3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox ttbtelefone2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox ttbtelefone1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox ttbbairro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ttbnumero;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ttbfantasia;
        private System.Windows.Forms.TextBox ttbendereco;
        private System.Windows.Forms.TextBox ttbrazao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ttblogo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog dialog;
        private System.Windows.Forms.PictureBox pblogo;
        private System.Windows.Forms.Button btnpesquisar;
        private System.Windows.Forms.TextBox ttbuf;
        private System.Windows.Forms.TextBox ttbcidade;
        private System.Windows.Forms.TextBox ttbsite;
        private System.Windows.Forms.Label lblsite;
        private System.Windows.Forms.TextBox ttbcep;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox ttbie;
    }
}