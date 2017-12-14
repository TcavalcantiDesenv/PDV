using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Windows.Forms;


namespace MGMPDV
{
    public partial class FRCliente : Form
    {

        int X = 0;
        int Y = 0;
        public FRCliente()
        {
            InitializeComponent();
            lbltitulo.MouseDown += new MouseEventHandler(Form3_MouseDown);
            lbltitulo.MouseMove += new MouseEventHandler(Form3_MouseMove);

        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {


            if (keyData == Keys.Escape)
            {
                btnsair.PerformClick();
                return true;   // indicate that you handled this keystroke
            }




            // Call the base class
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void Form3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void Form3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void FRelatorio_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dscliente.DataTable1' table. You can move, or remove it, as needed.
           // this.DataTable1TableAdapter.Fill(this.dscliente.DataTable1);
            // TODO: This line of code loads data into the 'dscliente.DataTable1' table. You can move, or remove it, as needed.
            // this.DataTable1TableAdapter.Fill(this.dscliente.DataTable1);
            // TODO: This line of code loads data into the 'dsproduto.dtproduto' table. You can move, or remove it, as needed.
            //  ReportDataSource MyReportDataSource = new ReportDataSource("dscaixa", dt);
            //reportViewer1.LocalReport.DataSources.Add(MyReportDataSource);
            reportViewer1.LocalReport.DataSources.Clear();

            CCliente ccliente = new CCliente();
            DataTable dtcliente = ccliente.pesquisar("","nome");
            ReportDataSource MyReportDataSource = new ReportDataSource("DataSet1", dtcliente);
            reportViewer1.LocalReport.DataSources.Add(MyReportDataSource);

            reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void btnfechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lbltitulo_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            decimal total = this.Width;
            decimal sobra = total - reportViewer1.Width;
            reportViewer1.Left = (this.Width - reportViewer1.Width) / 2;
            reportViewer1.Height = this.Height - pnltitulo.Height;
        }

        private void lbltitulo_Click(object sender, EventArgs e)
        {

        }
    }
}
