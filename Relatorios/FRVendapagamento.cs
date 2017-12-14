using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace MGMPDV.Relatorios
{
    public partial class FRVendaPagamento : Form
    {

        int X = 0;
        int Y = 0;
        public FRVendaPagamento(DateTime datai, DateTime dataf)
        {
            InitializeComponent();
            lbltitulo.MouseDown += new MouseEventHandler(Form3_MouseDown);
            lbltitulo.MouseMove += new MouseEventHandler(Form3_MouseMove);

            pnltitulo.BackColor = Color.FromArgb(50, Color.Black);
            gerar(datai, dataf);
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



        private void timer1_Tick(object sender, EventArgs e)
        {
            decimal total = this.Width;
            decimal sobra = total - web.Width;
            web.Left = (this.Width - web.Width) / 2;
            web.Height = this.Height - pnltitulo.Height;
        }


        private void gerar(DateTime datai, DateTime dataf)
        {
            string texto = @"<html>
                            <head><title>Relatório de Pagamentos</title></head>
                            <body><div style='border:1px solid green'>
                           <h1 style='text-align:center;background-color:#CCCCCC'>Relatório de Pagamentos</h1> </div>
                            <div style='width:100%;text-align:right'>" + datai.ToShortDateString() + " - " + dataf.ToShortDateString()+"</div><br>";
            CContaReceber creceber = new CContaReceber();
            CCaixa caixa = new CCaixa();
            DataTable dtcaixa = caixa.carregarcaixa(datai, dataf);

            DataTable dttotal = creceber.carregarParcelasTotalPagamento(datai, dataf);
            texto += @"<br><br>";
            texto += @"
                        <div style='width:100%;background-color:#CCCCCC'>
                         <h1 style='text-align:center'>Total Geral
</h1>
                            <table>";

            for (int i = 0; i < dttotal.Rows.Count; i++)
            {
                texto += "<tr><td style='border: 1px solid black'>" + dttotal.Rows[i]["par_descricao"].ToString() + ":</td><td style='border: 1px solid black'> " + dttotal.Rows[i]["par_total"].ToString() + "</td></tr>";
            }


            texto += @"   </table>
                           </div><hr><hr> 
                            ";





            for (int i = 0; i < dtcaixa.Rows.Count; i++)
            {
                CFuncionario fun = new CFuncionario();
                CFuncionario funfech = new CFuncionario();

                fun.pesquisarID(int.Parse(dtcaixa.Rows[i]["fun_id"].ToString()));
                try {
                    funfech.pesquisarID(int.Parse(dtcaixa.Rows[i]["fun_idfechamento"].ToString()));
                }
                catch { funfech.fun_nome = ""; }

                string datafinal = "";
                string horafinal = "";
                try
                {
                    datafinal = DateTime.Parse(dtcaixa.Rows[i]["cai_datafinal"].ToString()).ToShortDateString();
                    horafinal = DateTime.Parse(dtcaixa.Rows[i]["cai_horafinal"].ToString()).ToShortTimeString();
                }
                catch{}
                texto += @"
                           <Br> 
                           <div> " + dtcaixa.Rows[i]["cai_id"].ToString() + @"
                                <div>Abertura: " + fun.fun_nome + " - " + DateTime.Parse(dtcaixa.Rows[i]["cai_datainicial"].ToString()).ToShortDateString() + " - "+ DateTime.Parse(dtcaixa.Rows[i]["cai_horainicial"].ToString()).ToShortTimeString() + @" 
                                <br>
                                     Fechamento: " + funfech.fun_nome + " - " + datafinal + " - " + horafinal+ @" 
                                </div>
                               
                                <div>";

                texto += @"</div>
                           </div>
                           <div>
                                <table>";

                DataTable dtreceber = creceber.carregarParcelasCaixaRelatorio(int.Parse(dtcaixa.Rows[i]["cai_id"].ToString()));
                for (int j = 0; j < dtreceber.Rows.Count; j++)
                {
                    texto += "<tr><td style='border: 1px solid black'>" + dtreceber.Rows[j]["par_descricao"].ToString() + ":</td><td style='border: 1px solid black'> " + dtreceber.Rows[j]["par_total"].ToString()+"</td></tr>";
                }

                         
                             texto += @"   </table>
                           </div> <hr>
                            ";
            }
            texto += "</body></html>";
            web.DocumentText = texto;
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lbltitulo_DoubleClick(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;
        }

        private void btnimprimir_Click(object sender, EventArgs e)
        {
            web.ShowPrintPreviewDialog();
        }
    }
}
