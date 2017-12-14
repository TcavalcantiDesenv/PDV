namespace MGMPDV
{
    partial class FRCliente
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnltitulo = new System.Windows.Forms.Panel();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.btnsair = new System.Windows.Forms.Button();
            this.pnltitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Font = new System.Drawing.Font("Courier New", 8.25F);
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = null;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "MGMPDV.Relatorios.RCliente.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(103, 32);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Padding = new System.Windows.Forms.Padding(10);
            this.reportViewer1.Size = new System.Drawing.Size(819, 566);
            this.reportViewer1.TabIndex = 1;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnltitulo
            // 
            this.pnltitulo.BackColor = System.Drawing.Color.Transparent;
            this.pnltitulo.Controls.Add(this.lbltitulo);
            this.pnltitulo.Controls.Add(this.btnsair);
            this.pnltitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnltitulo.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.pnltitulo.Location = new System.Drawing.Point(0, 0);
            this.pnltitulo.Name = "pnltitulo";
            this.pnltitulo.Padding = new System.Windows.Forms.Padding(2);
            this.pnltitulo.Size = new System.Drawing.Size(1010, 20);
            this.pnltitulo.TabIndex = 168;
            // 
            // lbltitulo
            // 
            this.lbltitulo.BackColor = System.Drawing.Color.Transparent;
            this.lbltitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbltitulo.Font = new System.Drawing.Font("Courier New", 13F, System.Drawing.FontStyle.Bold);
            this.lbltitulo.ForeColor = System.Drawing.Color.White;
            this.lbltitulo.Location = new System.Drawing.Point(2, 2);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(988, 16);
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
            this.btnsair.Location = new System.Drawing.Point(990, 2);
            this.btnsair.Margin = new System.Windows.Forms.Padding(0);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(18, 16);
            this.btnsair.TabIndex = 0;
            this.btnsair.UseVisualStyleBackColor = false;
            this.btnsair.Click += new System.EventHandler(this.btnfechar_Click);
            // 
            // FRCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(113)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(1010, 610);
            this.Controls.Add(this.pnltitulo);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRCliente";
            this.Text = "FRelatorio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FRelatorio_Load);
            this.pnltitulo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pnltitulo;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Label lbltitulo;
    }
}