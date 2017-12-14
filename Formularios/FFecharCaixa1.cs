using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace MGMPDV.Formularios
{
    public partial class FFecharCaixa1 : Form
    {
        int X = 0;
        int Y = 0;
        int idfuncionario = 0;
        int idcaixa = 0;
        DataTable dtcaixa = new DataTable();
        public bool ok { get; set; }
        FMessageOk fmok = new FMessageOk();
        decimal dinheiro = 0;
        decimal credito = 0;
        decimal debito = 0;
        decimal cheque = 0;
        decimal fiado = 0;

        decimal totaldinheiro = 0;
        decimal totalcheque = 0;
        decimal totalfiado = 0;
        decimal totalcartao = 0;
        decimal totaldesconto = 0;
        decimal total = 0;

        public FFecharCaixa1(int idfuncionario,int idcaixa)
        {
            InitializeComponent();
            pnltitulo.BackColor = Color.FromArgb(50, Color.Black);
            lbltitulo.MouseDown += new MouseEventHandler(Form3_MouseDown);
            lbltitulo.MouseMove += new MouseEventHandler(Form3_MouseMove);

            CFuncionario cf = new CFuncionario();
            DataTable dt = cf.pesquisarID(idfuncionario);
            ttbusuario.Text = dt.Rows[0]["fun_usuario"].ToString();

            ok = false;
            this.idcaixa = idcaixa;
            this.idfuncionario = idfuncionario;

            carregarCaixa(idcaixa);

        }

        private void carregarCaixa(int idcaixa)
        {
            CCaixa c = new CCaixa();
            dtcaixa = c.pegacaixa(idcaixa);
            CContaReceber creceber = new CContaReceber();
            DataTable dtreceber = creceber.carregarParcelasCaixa(idcaixa);
            total= c.totalCaixa(idcaixa);
            totaldinheiro = 0;
            totalcheque = 0;
            totalfiado = 0;
            totalcartao = 0;
            totaldesconto = 0;
            CVenda cvenda = new CVenda();
            DataTable dtvenda = cvenda.pesquisarIDCaixa(idcaixa);

            try
            {
                
                for (int i = 0; i < dtvenda.Rows.Count; i++)
                {
                    totaldesconto += decimal.Parse(dtvenda.Rows[i]["ven_desconto"].ToString());
                }
                for (int i = 0; i < dtreceber.Rows.Count; i++)
                {
                    if(dtreceber.Rows[i]["par_descricao"].ToString().ToUpper() == "DINHEIRO")
                    {
                        totaldinheiro += decimal.Parse(dtreceber.Rows[i]["par_valor"].ToString());
                    }
                    if (dtreceber.Rows[i]["par_descricao"].ToString().ToUpper() == "CHEQUE")
                    {
                        totalcheque += decimal.Parse(dtreceber.Rows[i]["par_valor"].ToString());
                    }
                    if (dtreceber.Rows[i]["par_descricao"].ToString().ToUpper() == "MARCAR")
                    {
                        totalfiado += decimal.Parse(dtreceber.Rows[i]["par_valor"].ToString());
                    }
                    if (dtreceber.Rows[i]["par_descricao"].ToString().ToUpper().Contains("CARTÃO"))
                    {
                        totalcartao += decimal.Parse(dtreceber.Rows[i]["par_valor"].ToString());
                    }
                }
                ttbcaixanumero.Text = dtcaixa.Rows[0]["cai_numero"].ToString();
                try
                {
                    ttbcaixavalorinicial.Text = decimal.Parse(dtcaixa.Rows[0]["cai_valorinicial"].ToString()).ToString("00.00");
                }
                catch { ttbcaixavalorinicial.Text = "00,00"; }
     
                ttbdinheirototal.Text = totaldinheiro.ToString("00.00");
                ttbchequetotal.Text = totalcheque.ToString("00.00");
                ttbfiadototal.Text = totalfiado.ToString("00.00");
                ttbcartaototal.Text = totalcartao.ToString("00.00");
                ttbdescontototal.Text = totaldesconto.ToString("00.00");

                // total = totaldinheiro + totalcheque + totalfiado + totalcartao - totaldesconto;
                total = total - totaldesconto;
                ttbtotal.Text = total.ToString("00.00");


                
                 //ttbcaixavalordinheiro.Text =
                //ttbvalor.Text = c.totalCaixa(idcaixa).ToString("00.00");
                //lblvalor.Text = ttbvalor.Text;
            }
            catch { }

        }

        private void calcular()
        {
            decimal dinheirodif = 0;
            decimal chequedif = 0;
            decimal fiadodif = 0;
            decimal cartaodif = 0;
            decimal.TryParse(ttbdinheirodif.Text, out dinheirodif);
            decimal.TryParse(ttbchequedif.Text, out chequedif);
            decimal.TryParse(ttbfiadodif.Text, out fiadodif);
            decimal.TryParse(ttbcartaodif.Text, out cartaodif);

            decimal total = 0;
            try
            {
                total = decimal.Parse(ttbtotal.Text);
            }
            catch { }

            ttbdiferenca.Text = ((dinheiro + cheque + fiado + credito)- total).ToString("00.00");//(dinheirodif + chequedif + fiadodif + cartaodif).ToString("00.00");
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                //btncancelar.PerformClick();
                btnfechar.PerformClick();
                return true;
            }
            // if (keyData == Keys.Enter)
            //{
            // if (pnlpesquisarcaixa.Visible)
            // {
            //selecionarCaixa();
            //}
            //  return true;   // indicate that you handled this keystroke
            //}

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

        private void btnfechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ttbdinheiro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ttbdinheiroinf.Text = ttbdinheiro.Text;
                dinheiro = decimal.Parse(ttbdinheiro.Text);
                ttbdinheirodif.Text = (decimal.Parse(ttbdinheiroinf.Text) - decimal.Parse(ttbdinheirototal.Text)).ToString("00.00");
                calcular();
            }
            catch { ttbdinheirodif.Text = "00,00"; ttbdinheiroinf.Text = "00.00"; }
        }

        private void ttbcheque_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ttbchequeinf.Text = ttbcheque.Text;
                cheque = decimal.Parse(ttbcheque.Text);
                ttbchequedif.Text = (decimal.Parse(ttbchequeinf.Text) - decimal.Parse(ttbchequetotal.Text)).ToString("00.00");
                calcular();

            }
            catch { ttbchequedif.Text = "00,00"; ttbchequeinf.Text = "00,00"; }
        }

        private void ttbcartao_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ttbcartaoinf.Text = ttbcartao.Text;
                credito = decimal.Parse(ttbcartao.Text);
                ttbcartaodif.Text = (decimal.Parse(ttbcartaoinf.Text) - decimal.Parse(ttbcartaototal.Text)).ToString("00.00");
                calcular();

            }
            catch { ttbcartaodif.Text = "00,00"; ttbcartaoinf.Text = "00,00"; }
        }

        private void ttbfiado_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ttbfiadoinf.Text = ttbfiado.Text;
                fiado = decimal.Parse(ttbfiado.Text);
                ttbfiadodif.Text = (decimal.Parse(ttbfiadoinf.Text) - decimal.Parse(ttbfiadototal.Text)).ToString("00.00");
                calcular();

            }
            catch { ttbfiadodif.Text = "00,00"; ttbfiadoinf.Text = "00.00"; }
        }

        private void btnconfirmar_Click(object sender, EventArgs e)
        {
            CCaixa c = new CCaixa();
            decimal valor = 0;

            CVenda venda = new CVenda();
            venda.pesquisarvendaaberta(idcaixa);
            if (venda.ven_status == 1)
            {
                fmok.Mostrar("Não é possível fechar o caixa com uma venda aberta!");
                return;
            }

            try
            {
                decimal.Parse(ttbdinheiro.Text);
            }
            catch { fmok.Mostrar("Valor em dinheiro inválido!"); return; }
            try
            {
                decimal.Parse(ttbcheque.Text);
            }
            catch { fmok.Mostrar("Valor em cheque inválido!"); return; }
            try
            {
                decimal.Parse(ttbcartao.Text);
            }
            catch { fmok.Mostrar("Valor em cartão inválido!"); return; }
            try
            {
                decimal.Parse(ttbfiado.Text);
            }
            catch { fmok.Mostrar("Valor em Fiado inválido!"); return; }

            try
            {
                valor = dinheiro+cheque+credito+fiado;
            }
            catch { fmok.Mostrar("Valor de Fechamento Inválido!"); return; }
            c.fechar(idfuncionario, valor, DateTime.Now, DateTime.Now, 0, "");
            fmok.Mostrar("Caixa fechado com sucesso!");
            ok = true;
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (decimal.Parse(ttbdiferenca.Text) < 0)
                    ttbdiferenca.ForeColor = Color.Red;
                else
                    ttbdiferenca.ForeColor = Color.Blue;
            }
            catch { }
            try
            {
                if (decimal.Parse(ttbdinheirodif.Text) < 0)
                    ttbdinheirodif.ForeColor = Color.Red;
                else
                    ttbdinheirodif.ForeColor = Color.Blue;

                if (decimal.Parse(ttbchequedif.Text) < 0)
                    ttbchequedif.ForeColor = Color.Red;
                else
                    ttbchequedif.ForeColor = Color.Blue;

                if (decimal.Parse(ttbfiadodif.Text) < 0)
                    ttbfiadodif.ForeColor = Color.Red;
                else
                    ttbfiadodif.ForeColor = Color.Blue;

                if (decimal.Parse(ttbcartaodif.Text) < 0)
                    ttbcartaodif.ForeColor = Color.Red;
                else
                    ttbcartaodif.ForeColor = Color.Blue;
            }
            catch { }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
