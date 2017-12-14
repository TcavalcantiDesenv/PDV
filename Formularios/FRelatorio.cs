using System;
using System.Drawing;
using System.Windows.Forms;

namespace MGMPDV.Formularios
{
    public partial class FRelatorio : Form
    {
        int X = 0;
        int Y = 0;
        public FRelatorio()
        {
            InitializeComponent();
            pnltitulo.BackColor = Color.FromArgb(50, Color.Black);
            pnlrelatorio.BackColor = Color.FromArgb(50, Color.Black);
            lbltitulo.MouseDown += new MouseEventHandler(Form3_MouseDown);
            lbltitulo.MouseMove += new MouseEventHandler(Form3_MouseMove);
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

        private void lblcaixa_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FCaixa f = new FCaixa();
            //FRCaixa f = new FRCaixa();
            f.ShowDialog();
            if (f.ok)
            {
                FRCaixa fr = new FRCaixa(f.idcaixa);
                fr.ShowDialog();
            }
        }

        private void lblproduto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FRProduto f = new FRProduto("");
            f.ShowDialog();
        }

        private void lblcliente_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FRCliente f = new FRCliente();
            f.ShowDialog();
        }

        private void lblprodutoestoque_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FRProduto f = new FRProduto("ESTOQUE");
            f.ShowDialog();
        }

        private void lblprodutosvendidos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MGMPDV.Formularios.FDataPicker fd = new MGMPDV.Formularios.FDataPicker("Escolha a Data Inicial!", DateTime.Now.Date);
            fd.ShowDialog();
            DateTime datai = fd.data;
            fd = new MGMPDV.Formularios.FDataPicker("Escolha a Data Final!", DateTime.Now.Date);
            fd.ShowDialog();
            DateTime dataf = fd.data;
            FRProduto f = new FRProduto("ITEMVENDA", datai, dataf);
            f.ShowDialog();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                btnfechar.PerformClick();
                return true;   // indicate that you handled this keystroke
            }

            // Call the base class
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void lblcaixapagamento_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MGMPDV.Formularios.FDataPicker fd = new MGMPDV.Formularios.FDataPicker("Escolha a Data Inicial!", DateTime.Now.Date);
            fd.ShowDialog();
            DateTime datai = fd.data;
            fd = new MGMPDV.Formularios.FDataPicker("Escolha a Data Final!", DateTime.Now.Date);
            fd.ShowDialog();
            DateTime dataf = fd.data;
            Relatorios.FRVendaPagamento f = new Relatorios.FRVendaPagamento(datai, dataf);
            f.ShowDialog();
        }
    }
}
