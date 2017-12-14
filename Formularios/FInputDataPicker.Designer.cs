namespace MGMPDV.Formularios
{
    partial class FInputDataPicker
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
            this.lbldata = new System.Windows.Forms.Label();
            this.lblvalor = new System.Windows.Forms.Label();
            this.ttbvalor = new System.Windows.Forms.TextBox();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnconfirmar = new System.Windows.Forms.Button();
            this.pnltitulo = new System.Windows.Forms.Panel();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.btnsair = new System.Windows.Forms.Button();
            this.pnltitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbldata
            // 
            this.lbldata.Font = new System.Drawing.Font("Consolas", 12.25F);
            this.lbldata.ForeColor = System.Drawing.Color.White;
            this.lbldata.Location = new System.Drawing.Point(72, 124);
            this.lbldata.Name = "lbldata";
            this.lbldata.Size = new System.Drawing.Size(334, 26);
            this.lbldata.TabIndex = 182;
            this.lbldata.Text = "Data do primeiro vencimento";
            this.lbldata.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblvalor
            // 
            this.lblvalor.Font = new System.Drawing.Font("Consolas", 12.25F);
            this.lblvalor.ForeColor = System.Drawing.Color.White;
            this.lblvalor.Location = new System.Drawing.Point(70, 52);
            this.lblvalor.Name = "lblvalor";
            this.lblvalor.Size = new System.Drawing.Size(334, 26);
            this.lblvalor.TabIndex = 181;
            this.lblvalor.Text = "Valor";
            this.lblvalor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ttbvalor
            // 
            this.ttbvalor.Font = new System.Drawing.Font("Consolas", 12.75F);
            this.ttbvalor.Location = new System.Drawing.Point(74, 81);
            this.ttbvalor.Name = "ttbvalor";
            this.ttbvalor.Size = new System.Drawing.Size(233, 27);
            this.ttbvalor.TabIndex = 0;
            // 
            // dtp
            // 
            this.dtp.Font = new System.Drawing.Font("Courier New", 13.75F);
            this.dtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp.Location = new System.Drawing.Point(76, 153);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(233, 28);
            this.dtp.TabIndex = 1;
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.Color.Transparent;
            this.btncancelar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btncancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btncancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.Font = new System.Drawing.Font("Consolas", 9F);
            this.btncancelar.ForeColor = System.Drawing.Color.White;
            this.btncancelar.Location = new System.Drawing.Point(266, 216);
            this.btncancelar.Margin = new System.Windows.Forms.Padding(0);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(140, 36);
            this.btncancelar.TabIndex = 3;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
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
            this.btnconfirmar.Location = new System.Drawing.Point(114, 216);
            this.btnconfirmar.Margin = new System.Windows.Forms.Padding(0);
            this.btnconfirmar.Name = "btnconfirmar";
            this.btnconfirmar.Size = new System.Drawing.Size(140, 36);
            this.btnconfirmar.TabIndex = 2;
            this.btnconfirmar.Text = "Confirmar";
            this.btnconfirmar.UseVisualStyleBackColor = false;
            this.btnconfirmar.Click += new System.EventHandler(this.btnconfirmar_Click);
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
            this.pnltitulo.Size = new System.Drawing.Size(463, 20);
            this.pnltitulo.TabIndex = 177;
            // 
            // lbltitulo
            // 
            this.lbltitulo.BackColor = System.Drawing.Color.Transparent;
            this.lbltitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbltitulo.Font = new System.Drawing.Font("Courier New", 11F, System.Drawing.FontStyle.Bold);
            this.lbltitulo.ForeColor = System.Drawing.Color.White;
            this.lbltitulo.Location = new System.Drawing.Point(2, 2);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(444, 16);
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
            this.btnsair.Location = new System.Drawing.Point(446, 2);
            this.btnsair.Margin = new System.Windows.Forms.Padding(0);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(15, 16);
            this.btnsair.TabIndex = 0;
            this.btnsair.UseVisualStyleBackColor = false;
            this.btnsair.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // FInputDataPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(463, 277);
            this.Controls.Add(this.lbldata);
            this.Controls.Add(this.lblvalor);
            this.Controls.Add(this.ttbvalor);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnconfirmar);
            this.Controls.Add(this.pnltitulo);
            this.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FInputDataPicker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FInputDataPicker";
            this.pnltitulo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbldata;
        private System.Windows.Forms.Label lblvalor;
        private System.Windows.Forms.TextBox ttbvalor;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnconfirmar;
        private System.Windows.Forms.Panel pnltitulo;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Button btnsair;
    }
}