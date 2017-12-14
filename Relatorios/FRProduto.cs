using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using FirebirdSql.Data;

namespace MGMPDV
{
    public partial class FRProduto : Form
    {
        int X = 0;
        int Y = 0;
        string tipo;
        DateTime datai;
        DateTime dataf;
        public FRProduto(string tipo)
        {
            InitializeComponent();
            lbltitulo.MouseDown += new MouseEventHandler(Form3_MouseDown);
            lbltitulo.MouseMove += new MouseEventHandler(Form3_MouseMove);
            this.tipo = tipo;
        }
        public FRProduto(string tipo, DateTime datai, DateTime dataf)
        {
            InitializeComponent();
            lbltitulo.MouseDown += new MouseEventHandler(Form3_MouseDown);
            lbltitulo.MouseMove += new MouseEventHandler(Form3_MouseMove);
            this.tipo = tipo;
            this.datai = datai;
            this.dataf = dataf;
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


        private void btnfechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FRProduto_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsproduto.dtproduto' table. You can move, or remove it, as needed.

            reportViewer1.LocalReport.DataSources.Clear();

            CCliente ccliente = new CCliente();
            CProduto cproduto = new CProduto();
            CItemVenda c = new CItemVenda();
            DataTable dt = new DataTable();
            ReportDataSource MyReportDataSource = new ReportDataSource("dsproduto", dt);
            if (tipo.ToUpper() == "")
            {
                dt = cproduto.pesquisar("","nome");
                MyReportDataSource = new ReportDataSource("dsproduto", dt);
                //reportViewer1.LocalReport.DataSources.Add(MyReportDataSource);
            }
            if(tipo.ToUpper()=="ESTOQUE")
            {
                dt = cproduto.pesquisarOrderQuantidade("", "nome");
                MyReportDataSource = new ReportDataSource("dsproduto", dt);
                //reportViewer1.LocalReport.DataSources.Add(MyReportDataSource);
            }
               
            if (tipo.ToUpper() == "ITEMVENDA")
            {
              
                 c = new CItemVenda();
                 dt = c.pesquisarquantidadeItensVendidosData(datai, dataf);
                 MyReportDataSource = new ReportDataSource("dsproduto", dt);
                
            }
            reportViewer1.LocalReport.DataSources.Add(MyReportDataSource);
            reportViewer1.RefreshReport();
        }

        private void lbltitulo_DoubleClick(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            reportViewer1.Left = (this.Width - reportViewer1.Width) / 2;
            reportViewer1.Height = this.Height - pnltitulo.Height;
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
    }
}
