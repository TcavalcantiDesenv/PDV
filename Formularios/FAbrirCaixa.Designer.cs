namespace MGMPDV.Formularios
{
    partial class FAbrirCaixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FAbrirCaixa));
            this.lbltitulo1 = new System.Windows.Forms.Label();
            this.ttbcaixanumero = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ttbvalor = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblstatus = new System.Windows.Forms.Label();
            this.pnltitulo = new System.Windows.Forms.Panel();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.btnfechar = new System.Windows.Forms.Button();
            this.ttbusuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlbot = new System.Windows.Forms.Panel();
            this.lblhora = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.pnltitulo.SuspendLayout();
            this.pnlbot.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbltitulo1
            // 
            this.lbltitulo1.BackColor = System.Drawing.Color.Transparent;
            this.lbltitulo1.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold);
            this.lbltitulo1.ForeColor = System.Drawing.Color.White;
            this.lbltitulo1.Location = new System.Drawing.Point(23, 32);
            this.lbltitulo1.Name = "lbltitulo1";
            this.lbltitulo1.Size = new System.Drawing.Size(472, 27);
            this.lbltitulo1.TabIndex = 78;
            this.lbltitulo1.Text = "Abertura de Caixa";
            this.lbltitulo1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ttbcaixanumero
            // 
            this.ttbcaixanumero.BackColor = System.Drawing.Color.Transparent;
            this.ttbcaixanumero.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold);
            this.ttbcaixanumero.ForeColor = System.Drawing.Color.White;
            this.ttbcaixanumero.Location = new System.Drawing.Point(92, 5);
            this.ttbcaixanumero.Name = "ttbcaixanumero";
            this.ttbcaixanumero.Size = new System.Drawing.Size(57, 21);
            this.ttbcaixanumero.TabIndex = 78;
            this.ttbcaixanumero.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(18, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 21);
            this.label2.TabIndex = 104;
            this.label2.Text = "Fundo de Caixa ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ttbvalor
            // 
            this.ttbvalor.BackColor = System.Drawing.Color.Silver;
            this.ttbvalor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ttbvalor.Font = new System.Drawing.Font("Consolas", 35F, System.Drawing.FontStyle.Bold);
            this.ttbvalor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ttbvalor.Location = new System.Drawing.Point(21, 239);
            this.ttbvalor.Name = "ttbvalor";
            this.ttbvalor.ReadOnly = true;
            this.ttbvalor.Size = new System.Drawing.Size(280, 55);
            this.ttbvalor.TabIndex = 1;
            this.ttbvalor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ttbvalor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ttbvalor_KeyPress);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 600;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblstatus
            // 
            this.lblstatus.BackColor = System.Drawing.Color.Transparent;
            this.lblstatus.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Bold);
            this.lblstatus.ForeColor = System.Drawing.Color.Red;
            this.lblstatus.Location = new System.Drawing.Point(165, 310);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(229, 21);
            this.lblstatus.TabIndex = 125;
            this.lblstatus.Text = "Caixa Aberto!";
            this.lblstatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblstatus.Visible = false;
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
            this.pnltitulo.Size = new System.Drawing.Size(467, 24);
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
            this.lbltitulo.Size = new System.Drawing.Size(444, 20);
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
            this.btnfechar.Location = new System.Drawing.Point(446, 2);
            this.btnfechar.Margin = new System.Windows.Forms.Padding(0);
            this.btnfechar.Name = "btnfechar";
            this.btnfechar.Size = new System.Drawing.Size(19, 20);
            this.btnfechar.TabIndex = 0;
            this.btnfechar.UseVisualStyleBackColor = false;
            this.btnfechar.Click += new System.EventHandler(this.btnfechar_Click);
            // 
            // ttbusuario
            // 
            this.ttbusuario.BackColor = System.Drawing.Color.Silver;
            this.ttbusuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ttbusuario.Font = new System.Drawing.Font("Consolas", 35F, System.Drawing.FontStyle.Bold);
            this.ttbusuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ttbusuario.Location = new System.Drawing.Point(21, 120);
            this.ttbusuario.Name = "ttbusuario";
            this.ttbusuario.ReadOnly = true;
            this.ttbusuario.Size = new System.Drawing.Size(280, 55);
            this.ttbusuario.TabIndex = 30;
            this.ttbusuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ttbusuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ttbvalor_KeyPress);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 21);
            this.label1.TabIndex = 104;
            this.label1.Text = "Usuário";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlbot
            // 
            this.pnlbot.Controls.Add(this.lblhora);
            this.pnlbot.Controls.Add(this.label5);
            this.pnlbot.Controls.Add(this.ttbcaixanumero);
            this.pnlbot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlbot.Location = new System.Drawing.Point(0, 334);
            this.pnlbot.Name = "pnlbot";
            this.pnlbot.Size = new System.Drawing.Size(467, 33);
            this.pnlbot.TabIndex = 134;
            // 
            // lblhora
            // 
            this.lblhora.BackColor = System.Drawing.Color.Transparent;
            this.lblhora.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold);
            this.lblhora.ForeColor = System.Drawing.Color.White;
            this.lblhora.Location = new System.Drawing.Point(252, 5);
            this.lblhora.Name = "lblhora";
            this.lblhora.Size = new System.Drawing.Size(211, 21);
            this.lblhora.TabIndex = 127;
            this.lblhora.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(18, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 21);
            this.label5.TabIndex = 126;
            this.label5.Text = "Caixa";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(2, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(545, 1);
            this.panel2.TabIndex = 135;
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
            this.btncancelar.Location = new System.Drawing.Point(375, 239);
            this.btncancelar.Margin = new System.Windows.Forms.Padding(0);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(69, 55);
            this.btncancelar.TabIndex = 3;
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnsair
            // 
            this.btnsair.BackColor = System.Drawing.Color.Transparent;
            this.btnsair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsair.BackgroundImage")));
            this.btnsair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsair.FlatAppearance.BorderSize = 0;
            this.btnsair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnsair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnsair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsair.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsair.ForeColor = System.Drawing.Color.White;
            this.btnsair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsair.Location = new System.Drawing.Point(375, 120);
            this.btnsair.Margin = new System.Windows.Forms.Padding(0);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(69, 64);
            this.btnsair.TabIndex = 0;
            this.btnsair.UseVisualStyleBackColor = false;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // FAbrirCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(467, 367);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlbot);
            this.Controls.Add(this.pnltitulo);
            this.Controls.Add(this.lblstatus);
            this.Controls.Add(this.ttbusuario);
            this.Controls.Add(this.ttbvalor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.lbltitulo1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FAbrirCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Abrir Caixa";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FAbrirCaixa_KeyUp);
            this.pnltitulo.ResumeLayout(false);
            this.pnlbot.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitulo1;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Label ttbcaixanumero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ttbvalor;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.Panel pnltitulo;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Button btnfechar;
        private System.Windows.Forms.TextBox ttbusuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlbot;
        private System.Windows.Forms.Label lblhora;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
    }
}