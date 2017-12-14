using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace MGMPDV.Formularios
{
    public partial class FVendaDetalhe : Form
    {
        int X = 0;
        int Y = 0;

        //PARAMETROS MOSTRAR ITENS DA VENDA
        string[] vetitemvenda = new string[1000];
        int veti = 0;
        string separador = "------------------------------------------------";
        //FIM ITENS DA VENDA

        decimal desconto = 0;
        decimal pagamentos = 0;

        CVenda venda = new CVenda();
        CEmpresa empresa = new CEmpresa();
        CCliente cliente = new CCliente();
        DataTable dtitemvenda = new DataTable();

        public FVendaDetalhe(int idfuncionario, int idvenda)
        {
            InitializeComponent();
            lbltitulo.MouseDown += new MouseEventHandler(Form3_MouseDown);
            lbltitulo.MouseMove += new MouseEventHandler(Form3_MouseMove);
            pnltitulo.BackColor = Color.FromArgb(50, Color.Black);
            carregarvenda(idvenda);
            carregarcliente();
            carregaritemvenda();
            empresa.carregar();
            mostraritemvenda(dtitemvenda);


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

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            if (keyData == Keys.Escape)
            {

                Close();
                return true;    // indicate that you handled this keystroke
            }

            if (keyData == Keys.F9)
            {
                btncancelar.PerformClick();
                return true;
            }

            if (keyData == Keys.F1)
            {
                btnimprimir.PerformClick();
                return true;
            }



            // Call the base class
            return base.ProcessCmdKey(ref msg, keyData);
        }

        public void carregarvenda(int idvenda)
        {
            venda.pesquisarvendaIdVenda(idvenda);
            desconto = venda.ven_desconto;
            CContaReceber cc = new CContaReceber();
            pagamentos = cc.totalPacelaContaReceberVenda(venda.ven_id);
        }

        public void carregarcliente()
        {
            cliente.pesquisarID(venda.cli_id);
        }

        public void carregaritemvenda()
        {
            CItemVenda c = new CItemVenda();
            dtitemvenda = c.pesquisar(venda.ven_id);
        }


        public void mostraritemvenda(DataTable dtitemvenda)
        {
            vetitemvenda = new string[1000];
            listvenda.Items.Clear();
            veti = 0;
            if (venda.ven_id <= 0)
            {
                return;
            }
            int tam = 48;
            int tamn = -48;
            MGM mgm = new MGM();

            listvenda.Items.Add(mgm.justificartexto(empresa.emp_fantasia, tam) + "\r\n");
            listvenda.Items.Add(mgm.justificartexto(empresa.emp_endereco + " " + empresa.emp_numero, tam) + "\r\n");
            listvenda.Items.Add(mgm.justificartexto(empresa.emp_cnpj, tam) + "\r\n");
            listvenda.Items.Add(mgm.justificartexto(empresa.emp_telefone1 + "/" + empresa.emp_telefone2, tam) + "\r\n");
            listvenda.Items.Add(string.Format("{0," + tamn + "}", separador) + "\r\n");

            listvenda.Items.Add(mgm.justificartexto(venda.ven_data.ToShortDateString() + " " + venda.ven_hora.ToString("T") + " cod:" + venda.ven_id, tam) + "\r\n");
            //listvenda.Items.Add(mgm.justificartexto(Text + "\r\n", tam));
            // listvenda.Items.Add("\r\n");
            //listvenda.Items.Add(mgm.justificartexto("CUPOM NÃO FISCAL", tam) + "\r\n");


            if (venda.cli_id > 0)
            {
                listvenda.Items.Add("\r\n");
                listvenda.Items.Add(mgm.formatartamanho("Cliente", 9) + ":" + mgm.formatartamanho(cliente.nome, 40) + "\r\n");
                listvenda.Items.Add(mgm.formatartamanho("Endereço", 9) + ":" + cliente.endereco + " N:" + cliente.numero + "\r\n");
                string telefones = "";
                telefones = cliente.ddd1 + "-" + cliente.telefone1;
                if (cliente.telefone2.Trim() != "")
                    telefones += "/" + cliente.ddd2 + "-" + cliente.telefone2;
                if (cliente.telefone3.Trim() != "")
                    telefones += "/" + cliente.ddd3 + "-" + cliente.telefone3;
                listvenda.Items.Add(mgm.formatartamanho("Telefone", 9) + ":" + telefones + "\r\n");
                listvenda.Items.Add(string.Format("{0," + tamn + "}", separador) + "\r\n");
            }

            listvenda.Items.Add("\r\n");
            //INICIO PRODUTO

            listvenda.Items.Add(string.Format("{0,-5}{1,-22}{2,7}{3,7}{4,7}", "ITEM", "PRODUTO", "VL. R$", "QTD.", "TOTAL") + "\r\n");
            listvenda.Items.Add(string.Format("{0," + tamn + "}", separador) + "\r\n");
            for (int i = 0; i < listvenda.Items.Count; i++)
            {
                vetitemvenda[i] = listvenda.Items[i].ToString();
            }
            veti = listvenda.Items.Count;
            for (int i = 0; i < dtitemvenda.Rows.Count; i++)
            {
                string produto = dtitemvenda.Rows[i]["pro_nome"].ToString();
                if (produto.Length > 22)
                {
                    produto = produto.Substring(0, 22);
                }
                string id = int.Parse(dtitemvenda.Rows[i]["ite_id"].ToString()).ToString();
                string valor = decimal.Parse(dtitemvenda.Rows[i]["ite_valor"].ToString()).ToString("00.00");
                string quantidade = decimal.Parse(dtitemvenda.Rows[i]["ite_quantidade"].ToString()).ToString();
                string total = (decimal.Parse(dtitemvenda.Rows[i]["ite_valor"].ToString()) * decimal.Parse(dtitemvenda.Rows[i]["ite_quantidade"].ToString())).ToString("00.00");
                string idcomplemento = "0";
                listvenda.Items.Add(string.Format("{0,-5}{1,-22}{2,7}{3,7}{4,7}", i + 1, produto, valor, quantidade, total) + "\r\n");
                vetitemvenda[veti++] = "@cod" + id;

            }

            listvenda.Items.Add(string.Format("{0," + tamn + "}", separador) + "\r\n");


            listvenda.Items.Add(string.Format("{0,-32}{1,16}", "SUBTOTAL      R$", venda.ven_total.ToString("00.00")) + "\r\n");

            listvenda.Items.Add(string.Format("{0,-32}{1,16}", "DESCONTO      R$", venda.ven_desconto.ToString("00.00")) + "\r\n");
            listvenda.Items.Add(string.Format("{0,-32}{1,16}", "PAGAMENTOS    R$", pagamentos.ToString("00.00")) + "\r\n");

            listvenda.Items.Add(string.Format("{0,-32}{1,16}", "TOTAL A PAGAR R$", (venda.ven_total - pagamentos - venda.ven_desconto).ToString("00.00")) + "\r\n");

            listvenda.Items.Add(string.Format("{0," + tamn + "}", separador) + "\r\n");

            CConfiguracao configuracao = new CConfiguracao();

            // if (configuracao.senha > 0)
            //   if (venda.ven_senha.Trim() != "")
            // {
            //   listvenda.Items.Add(mgm.justificartexto("SENHA ==> " + venda.ven_senha, tam) + "\r\n");
            // listvenda.Items.Add(string.Format("{0," + tamn + "}", separador) + "\r\n");
            //}



            listvenda.Items.Add(string.Format("{0," + tam + "}", configuracao.mensagem) + "\r\n");
            int visibleItems = listvenda.ClientSize.Height / listvenda.ItemHeight;
            listvenda.TopIndex = Math.Max(listvenda.Items.Count - visibleItems + 1, 0);

        }

        private void btnfechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listvenda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnimprimir_Click(object sender, EventArgs e)
        {
            CSat sat = new CSat();
            sat.imprimirIDVenda(venda.ven_id);
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            FMessageOk fmok = new FMessageOk();
            FMessageSimNao f = new FMessageSimNao();
            if (f.Mostrar("Cancelar Venda!", "Deseja cancelar a venda?"))
            {

                CSat sat = new CSat();
                if (!sat.cancelarIDVenda(venda.ven_id))
                {
                    fmok.Mostrar("Erro ao efetuar cancelamento!, obs: O Cupom só pode ser cancelado até 30 minutos após a emissão!");
                }
                else
                {
                    venda.excluir(venda.ven_id);
                    fmok.Mostrar("Cancelado com sucesso!");
                    Close();
                }
            }


        }

        private void FVendaDetalhe_Load(object sender, EventArgs e)
        {
            CSat sat = new CSat();
            sat.carregarXMLIDVenda(venda.ven_id);
            string data = sat.data;
            string hora = sat.hora;

            DateTime datavenda = DateTime.Parse(data);
            DateTime horavenda = DateTime.Parse(hora);

            horavenda = horavenda.AddMinutes(31);

            if (DateTime.Now.Date == datavenda)
                if (horavenda.TimeOfDay > DateTime.Now.TimeOfDay)
                {
                    btncancelar.Enabled = true;
                }
                else
                    btncancelar.Enabled = false;
            else
                btncancelar.Enabled = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
