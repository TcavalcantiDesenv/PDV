using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Windows.Forms;

namespace MGMPDV
{
    public partial class FRCaixa : Form
    {
        int X = 0;
        int Y = 0;
        int idcaixa = 0;
        public FRCaixa(int idcaixa)
        {
            InitializeComponent();
            lbltitulo.MouseDown += new MouseEventHandler(Form3_MouseDown);
            lbltitulo.MouseMove += new MouseEventHandler(Form3_MouseMove);
            this.idcaixa = idcaixa;

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

        private void FRCaixa_Load(object sender, EventArgs e)
        {


            reportViewer1.LocalReport.DataSources.Clear();

            CCaixa c = new CCaixa();
            DataTable dt = c.relatorioCaixa(idcaixa);
            ReportDataSource MyReportDataSource = new ReportDataSource("dscaixa", dt);
            reportViewer1.LocalReport.DataSources.Add(MyReportDataSource);

            CTransacao tran = new CTransacao();
            DataTable dttran = tran.pegaTransacao(idcaixa);
            MyReportDataSource = new ReportDataSource("dstransacao", dttran);
            reportViewer1.LocalReport.DataSources.Add(MyReportDataSource);

            CContaReceber creceber = new CContaReceber();
            DataTable dtreceber = creceber.carregarParcelasCaixaRelatorio(idcaixa);
            MyReportDataSource = new ReportDataSource("dsreceber", dtreceber);
            reportViewer1.LocalReport.DataSources.Add(MyReportDataSource);

            decimal saldofinal = c.totalCaixa(idcaixa);
            ReportParameter parametro = new ReportParameter("saldofinal", saldofinal.ToString("00.00"));
            reportViewer1.LocalReport.SetParameters(parametro);

            decimal sangria = tran.totalSangriaIdCaixa(idcaixa);
            parametro = new ReportParameter("sangria", sangria.ToString("00.00"));
            reportViewer1.LocalReport.SetParameters(parametro);

            decimal suprimento = tran.totalSuprimentoIdCaixa(idcaixa);
            parametro = new ReportParameter("suprimento", suprimento.ToString("00.00"));
            reportViewer1.LocalReport.SetParameters(parametro);

            decimal totalreceber = creceber.totalPacelaContaReceber(idcaixa);
            parametro = new ReportParameter("totalreceber", totalreceber.ToString("00.00"));
            reportViewer1.LocalReport.SetParameters(parametro);

            this.reportViewer1.RefreshReport();
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
    }
}
