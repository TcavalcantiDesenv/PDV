using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace MGMPDV.Formularios
{
    public partial class FPreVenda : Form
    {
        int X = 0;
        int Y = 0;

        public int idvenda { get; set; }
        CCliente cliente = new CCliente();
        DataTable dt = new DataTable();
        FMessageOk fmok = new FMessageOk();

        CVenda venda = new CVenda();
        CEmpresa empresa = new CEmpresa();
        DataTable dtitemvenda = new DataTable();

        //PARAMETROS MOSTRAR ITENS DA VENDA
        string[] vetitemvenda = new string[1000];
        int veti = 0;
        string separador = "------------------------------------------------";
        //FIM ITENS DA VENDA

        decimal desconto = 0;
        decimal pagamentos = 0;

        public FPreVenda(int ven_id, int idcliente)
        {
            InitializeComponent();
            grid.AutoGenerateColumns = false;
            lbltitulo.MouseDown += new MouseEventHandler(Form3_MouseDown);
            lbltitulo.MouseMove += new MouseEventHandler(Form3_MouseMove);
            pnltitulo.BackColor = Color.FromArgb(50, Color.Black);

            this.idvenda = ven_id;
            CVenda venda = new CVenda();
            venda.pesquisarvendaIdVenda(idvenda);
            if(venda.ven_status==1 && ven_id>0)
            {
                cliente.pesquisarID(idcliente);
                btncliente.Text = cliente.nome;
                venda = new CVenda();
                dt = venda.pesquisarPreVendaIDCliente(idcliente);
                grid.DataSource = dt;
                btntodos.Enabled = false;
                grid.Enabled = false;
              
            }
            else
                {
                    btnadicionar.Enabled = false;
                }
      

      
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {




            if (keyData == Keys.Escape)
            {
                btnsair.PerformClick();
                return true;
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

        private void btnfechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btncliente_Click(object sender, EventArgs e)
        {
            FConsultaCliente f = new FConsultaCliente();
            f.ShowDialog();
            if(f.ok)
            {
                int idcliente = 0;
                int.TryParse(f.dt.Rows[f.index]["cli_id"].ToString(), out idcliente);
                cliente.pesquisarID(idcliente);
                btncliente.Text = cliente.nome;
                CVenda venda = new CVenda();
                dt = venda.pesquisarPreVendaIDCliente(idcliente);
                grid.DataSource = dt;
            }
        }

        private void btnadicionar_Click(object sender, EventArgs e)
        {
            if(cliente.id<1)
            {
                fmok.Mostrar("Selecione um cliente!"); return;
            }
            CVenda venda = new CVenda();
            venda.inserirPreVenda(idvenda,cliente.id);
            fmok.Mostrar("Adicionado com Sucesso!");
            FMessageSimNao f = new FMessageSimNao();
            if (f.Mostrar("Imprimir?", "Deseja imprimir demonstrativo da Pré Venda?"))
            {
                PrintDialog pd = new PrintDialog();
                if (pd.ShowDialog() == DialogResult.OK)
                {
                    carregarvenda(idvenda);
                    carregarcliente();
                    carregaritemvenda();

                    empresa.carregar();
                    mostraritemvenda(dtitemvenda);

                    PrintDocument printDocument = new PrintDocument();
                    printDocument.PrintPage += PrintDocumentOnPrintPage;
                    printDocument.PrinterSettings = pd.PrinterSettings;
                    printDocument.Print();
                }
            }
            idvenda = 0;
            Close();

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


        private void PrintDocumentOnPrintPage(object sender, PrintPageEventArgs e)
        {
            Font f = new Font(listvenda.Font.FontFamily, 7, FontStyle.Bold);
            //Font f = ttbitemvenda.Font;
            // e.Graphics.DrawString(this.ttbitemvenda.Text, f, Brushes.Black, 10, 25 );
            // e.Graphics.DrawString(listvenda.Text, f, Brushes.Black, 0, 0);

            TextBox t = new TextBox();
            for (int i = 0; i < listvenda.Items.Count; i++)
            {
                t.AppendText(listvenda.Items[i].ToString());
            }
            //t.Text = listvenda.Item;
            e.Graphics.DrawString(t.Text, f, Brushes.Black, 0, 0);

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

        private void btntodos_Click(object sender, EventArgs e)
        {
            CVenda venda = new CVenda();
            dt = venda.pesquisarPreVenda();
            grid.DataSource = dt;
        }

        private void grid_DoubleClick(object sender, EventArgs e)
        {
            if (dt.Rows.Count < 1)
                return;

            if (!grid.Enabled)
                return;

            idvenda = int.Parse(dt.Rows[grid.SelectedCells[0].RowIndex]["ven_id"].ToString());
            Close();
        }

        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FPreVenda_Load(object sender, EventArgs e)
        {

        }
    }
}
