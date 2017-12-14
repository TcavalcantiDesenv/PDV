using MGMPDV.Formularios;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MGMPDV
{
    public partial class FContaReceber : Form
    {

        DataTable dtparcelas = new DataTable();
        MGM mgm = new MGM();

        public int idcaixa { get; set; }
        public int idvenda { get; set; }

        int botaoidcliente = 0;

        public FContaReceber(int idcaixa)
        {
            InitializeComponent();

            this.idcaixa = idcaixa;
            gridparcela.AutoGenerateColumns = false;

      
        }

        private void colorirGrid()
        {
            try
            {
                for (int i = 0; i < dtparcelas.Rows.Count; i++)
                {
                    DataGridViewRow r = gridparcela.Rows[i];


                   /* if (dtparcelas.Rows[i]["ven_status"].ToString() == "0")
                    {
                        r.DefaultCellStyle.BackColor = Color.Silver;

                    }*/

                    if (dtparcelas.Rows[i]["par_status"].ToString() == "0")
                    {
                        r.DefaultCellStyle.BackColor = Color.LightBlue;

                        DataGridViewButtonCell b = (DataGridViewButtonCell)gridparcela.Rows[i].Cells[1];
                        b.Style.BackColor = Color.Silver;

                        b = (DataGridViewButtonCell)gridparcela.Rows[i].Cells[5];
                        b.Style.BackColor = Color.Silver;
                    }
                    else
                    {
                        if (Convert.ToDateTime(dtparcelas.Rows[i]["par_dtvencimento"].ToString()) < DateTime.Now.Date)
                        {
                            r.DefaultCellStyle.BackColor = Color.Red;
                            DataGridViewButtonCell b = (DataGridViewButtonCell)gridparcela.Rows[i].Cells[1];
                            b.Style.BackColor = Color.Lime;

                            b = (DataGridViewButtonCell)gridparcela.Rows[i].Cells[5];
                            b.Style.BackColor = Color.Lime;
                        }
                        else
                        {
                            DataGridViewButtonCell b = (DataGridViewButtonCell)gridparcela.Rows[i].Cells[1];
                            b.Style.BackColor = Color.Lime;

                            b = (DataGridViewButtonCell)gridparcela.Rows[i].Cells[5];
                            b.Style.BackColor = Color.Lime;
                        }

                    }

                    if (dtparcelas.Rows[i]["par_estornar"].ToString() == "0")
                    {

                        DataGridViewButtonCell b = (DataGridViewButtonCell)gridparcela.Rows[i].Cells[2];
                        b.Style.BackColor = Color.Silver;

                    }
                    else
                    {
                        DataGridViewButtonCell b = (DataGridViewButtonCell)gridparcela.Rows[i].Cells[2];
                        b.Style.BackColor = Color.Red;
                    }

                }
            }
            catch { }


            /*
                       foreach (DataGridViewRow row in gridparcela.Rows)
                       {
                           row.Cells[1].Style.BackColor = System.Drawing.Color.Blue;
                       }*/
        }
        private void carregarparcelas()
        {
            try
            {
                dtparcelas = new DataTable();
                CContaReceber cp = new CContaReceber();
                dtparcelas = cp.carregarParcelas();
                gridparcela.DataSource = dtparcelas;
            }
            catch { }
        }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                Close();
                return true;    // indicate that you handled this keystroke
            }

            return base.ProcessCmdKey(ref msg, keyData);

        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void imprimirPromissoria(int idparcela)
        {
            //FImprimirPromissoria fi = new FImprimirPromissoria(idparcela);
           // fi.ShowDialog();
            return;
            DataTable dt;
            CContaReceber creceber = new CContaReceber();
            CVenda cvenda = new CVenda();
            cvenda.pesquisarvendaIdVenda(idvenda);

            int i = 0;
            string texto = @"
            <html xmlns='http://www.w3.org/1999/xhtml' xml:lang='pt-br'>
            <head>
            <meta charset='UTF-8'>
            <title>Promissória</title>

            </head>
            <body>
            <div style='width:1024px;margin:0 auto'>
                
                <h1 style='border:1px solid black;background-color:highlight;text-align:center'>Relatório de Clientes</h1><br>
                <div style='width:100%;text-align:center'>" + DateTime.Today.ToLongDateString() + " - " + DateTime.Now.ToLongTimeString(); texto += @"</div>
                <br>
                <table>
                <tr style='font-size:20px;font-weight:bolder'><td width='230px'>Nome</td><td width='230px'>Endereço</td><td width='80px'>Número</td><td width='200px'>Bairro</td><td width='110px'>Telefone</td><td width='110px'>Telefone</td><td width='110px'>Telefone</td></tr>
                </table>
                <hr />
                " +
                "<table>";
            //for (i = 0; i < dt.Rows.Count; i++)
          //  {
               // texto += "<tr "; if (i % 2 == 0) texto += "style='background-color:silver'"; texto += "><td  style='border-bottom:1px solid black'  style='border-bottom:1px solid black' width='230px'>" + dt.Rows[i]["cli_nome"].ToString() + "</td  style='border-bottom:1px solid black'  style='border-bottom:1px solid black'><td  style='border-bottom:1px solid black' width='230px'>" + dt.Rows[i]["cli_endereco"].ToString() + "</td  style='border-bottom:1px solid black'><td  style='border-bottom:1px solid black' width='80px'>" + dt.Rows[i]["cli_numero"].ToString() + "</td  style='border-bottom:1px solid black'><td  style='border-bottom:1px solid black' width='200px'>" + dt.Rows[i]["cli_bairro"].ToString() + "</td  style='border-bottom:1px solid black'><td  style='border-bottom:1px solid black' width='110px'>" + dt.Rows[i]["cli_ddd1"].ToString() + ' ' + dt.Rows[i]["cli_telefone1"].ToString() + "</td  style='border-bottom:1px solid black'><td  style='border-bottom:1px solid black' width='110px'>" + dt.Rows[i]["cli_ddd2"].ToString() + ' ' + dt.Rows[i]["cli_telefone2"].ToString() + "</td  style='border-bottom:1px solid black'><td  style='border-bottom:1px solid black' width='110px'>" + dt.Rows[i]["cli_ddd3"].ToString() + ' ' + dt.Rows[i]["cli_telefone3"].ToString() + "</td></tr>";
         //   }
            texto += "</table>"
            + @"
                
            </div>
            </body>
            </html>";

            File.Create(Application.StartupPath + "\\RelPromissoria.html").Close();
            TextWriter f = File.AppendText(Application.StartupPath + "\\RelPromissoria.html");
            f.Write(texto);
            f.Close();
            System.Diagnostics.Process.Start(Application.StartupPath + "\\RelPromissoria.html"); 



        }
        private void gridparcela_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            int col = e.ColumnIndex;

            if (row < 0)
            {
                return;
            }
  
            decimal valorpago = 0;
            int estornar = int.Parse(dtparcelas.Rows[row]["par_estornar"].ToString());
            string par_descricao = dtparcelas.Rows[row]["par_descricao"].ToString();
            int idparcela = int.Parse(dtparcelas.Rows[row]["par_id"].ToString());
            int par_controle = int.Parse(dtparcelas.Rows[row]["par_controle"].ToString());
            int par_numero = int.Parse(dtparcelas.Rows[row]["par_numero"].ToString());
            int par_pai = int.Parse(dtparcelas.Rows[row]["par_pai"].ToString()); ;
            int idvenda = int.Parse(dtparcelas.Rows[row]["ven_id"].ToString());
            this.idvenda = idvenda;
            decimal par_valor = decimal.Parse(dtparcelas.Rows[row]["par_valor"].ToString());
            DateTime par_dtvencimento = Convert.ToDateTime(dtparcelas.Rows[row]["par_dtvencimento"].ToString());
            DateTime par_dtpagamento;

            CContaReceber cp = new CContaReceber();

            //DESCRICAO
                /*if (e.ColumnIndex == 0 && e.RowIndex >= 0)
                {
                    try
                    {
                        RelVendaImprimir r = new RelVendaImprimir(int.Parse(dtparcelas.Rows[e.RowIndex]["ven_id"].ToString()), 0);
                        r.ShowDialog();
                        
                    }
                    catch { }
                }*/
            

            if (col == 8)
            {
                if (par_descricao.ToUpper() == "CHEQUE")
                {
                  //  CCheque cheque = new CCheque();
                   // cheque.pesquisarIDParcela(idparcela);
                   // FCheque f = new FCheque();
                   // f.che_banco = cheque.che_banco;
                  //  f.che_agencia = cheque.che_agencia;
                  //  f.che_conta = cheque.che_conta;
                  //  f.che_chequen = cheque.che_chequen;
                 // f.che_valor = cheque.che_valor;
                 // f.che_titular = cheque.che_titular;
                 // f.che_cpf = cheque.che_cpf;
                 // f.che_contato = cheque.che_contato;
                 // f.che_data = cheque.che_data;
                 // f.ShowDialog();
                }
                else
                    if (par_descricao.ToUpper() == "MARCAR")
                    {
                        int[] vetidparcela = new int[50];
                        vetidparcela[0] = idparcela;
                        //FImprimirPromissoria f = new FImprimirPromissoria(vetidparcela);
                        //f.ShowDialog();
                    }
            }
            //PAGAR
            if (col == 1)
            {
                if (gridparcela.Rows[row].Cells[col].Style.BackColor == Color.Lime)
                {
                    /*
            FPagamento fp = new FPagamento();
            fp.valortotal = cvenda.ven_total - cvenda.ven_desconto;
            fp.idvenda = cvenda.ven_id;
            fp.titulo = "Fechar Venda R$:"+fp.valortotal.ToString("00.00");
            fp.ShowDialog();
                     */


                        FInputDataPicker f = new FInputDataPicker("Informe a data de pagamento R$", DateTime.Now, "Valor de Pagamento", par_valor.ToString("00.00"),true);
                       // f.ttbreadonly = true;
                        //if (par_descricao == "Cheque" || par_descricao == "Marcar")
                          //  f.ttbreadonly = false;
                        f.ShowDialog();
                        valorpago = par_valor;
                        if (f.ok)
                        {
                            if (mgm.isDecimal(f.valor, false, out valorpago))
                            {
                                CCaixa caixa = new CCaixa();
                                DataTable dt = caixa.pegaaberto();

                                if (dt.Rows.Count > 0)
                                {
                                    par_dtpagamento = f.data;
                                    estornar = 1;
                                    cp.pagar(idvenda, idcaixa, idparcela,
                                    par_controle, par_numero, par_pai, par_valor, valorpago, par_dtvencimento, par_dtpagamento, par_descricao);
                                    dtparcelas = new DataTable();
                                    gridparcela.DataSource = dtparcelas;
                                    if (botaoidcliente > 0)
                                        pesquisarclienteid(botaoidcliente);
                                    else
                                        btndata.PerformClick();
                                    //cp.alterarValor(idparcela, valorpago, status, int.Parse(dt.Rows[0]["cai_id"].ToString()), estornar);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Valor inválido");
                            }

                        }
                    
 
                   /* FInputBoxData f = new FInputBoxData("Pagamento", "Informe o valor de pagamento R$");
                    f.ShowDialog();
                    if (f.ok)
                    {
                        if (mgm.isDecimal(f.texto, false, out valorpago))
                        {

                            //SE PAGAR TUDO STATUS DA PARCELA VAI PARA 0
                            int status = 1;

                            if (par_valor == valorpago)
                                status = 0;
                            // FIM SE PAGAR TUDO

                            CCaixa caixa = new CCaixa();
                            DataTable dt = caixa.pegaaberto();

                            if (dt.Rows.Count > 0)
                            {
                                par_dtpagamento = f.data;
                                estornar = 1;
                                cp.pagar(idcompra, idcaixa, idparcela,
                                par_controle, par_numero, par_pai, par_valor, valorpago, par_dtvencimento, par_dtpagamento, par_descricao);
                                //cp.alterarValor(idparcela, valorpago, status, int.Parse(dt.Rows[0]["cai_id"].ToString()), estornar);
                            }

                            btntodo.PerformClick();
                        }
                        else
                        {
                            MessageBox.Show("Valor inválido");
                        }

                    }*/
                }
            }
            //FIM PAGAR


            //ESTORNAR
            if (col == 2)
            {
                if (estornar == 1)
                {
                    if (MessageBox.Show("Deseja estornar?", "Estornar!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        cp.estornar(idparcela, par_controle, par_numero, par_pai);
                        dtparcelas = new DataTable();
                        gridparcela.DataSource = dtparcelas;
                        //btntodo.PerformClick();
                        if (botaoidcliente > 0)
                            pesquisarclienteid(botaoidcliente);
                        else
                            btndata.PerformClick();
                    }
                }
            }
            //FIM ESTORNAR

            //ALTERAR VALOR DA PARCELA
            /*if (col == 3)
            {
                if (gridparcela.Rows[row].Cells[col].Style.BackColor == Color.Lime)
                {

                    FInputBox f = new FInputBox("Novo Valor", "Informe o novo valor da Parcela R$");
                    f.ShowDialog();
                    if (f.ok)
                    {
                        if (mgm.isDecimal(f.texto, false, out valorpago))
                        {
                            CCaixa caixa = new CCaixa();
                            DataTable dt = caixa.pegaaberto();

                            if (dt.Rows.Count > 0)
                            {
                                cp.alterarValor(idparcela, valorpago);
                            }

                            carregar();
                            carregarparcelas();
                        }
                        else
                        {
                            MessageBox.Show("Valor inválido");
                        }

                    }
                }
            }*/
            //FIM ESTORNAR

            //CLICAR NA DATA DE VENCIMENTO
            if (col == 5)
            {
                if (gridparcela.Rows[row].Cells[col].Style.BackColor == Color.Lime)
                {
                    DateTime data = Convert.ToDateTime(dtparcelas.Rows[row]["par_dtvencimento"].ToString()); ;
                    FDataPicker f = new FDataPicker("Informe a data de vencimento!",DateTime.Now);
                    f.ShowDialog();
                    if (f.ok)
                    {

                        data = f.data;
                        cp.alterarData(idparcela, data);
                        if (par_descricao.ToUpper() == "CHEQUE")
                        {
                           // CCheque cheque = new CCheque();
                          //  cheque.alterarData(idparcela, data);
                        }
                        dtparcelas = new DataTable();
                        gridparcela.DataSource = dtparcelas;
                        if (botaoidcliente > 0)
                            pesquisarclienteid(botaoidcliente);
                        else
                            btndata.PerformClick();
                    }
                }
            }
            //FIM CLICAR NO VALOR PAGO
        }

        private void gridparcela_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            /*
            if (dtparcelas.Rows.Count>0)
            {
               
                    DataGridViewRow r = gridparcela.Rows[e.RowIndex];

                    if (dtparcelas.Rows[e.RowIndex]["par_status"].ToString() == "0")
                    {
                        r.DefaultCellStyle.BackColor = Color.Silver;

                        if (e.ColumnIndex == 1)
                        {
                            DataGridViewButtonCell b = (DataGridViewButtonCell)gridparcela.Rows[e.RowIndex].Cells[e.ColumnIndex];

                            b.FlatStyle = FlatStyle.Popup;
                            b.Style.BackColor = Color.Silver;
                        }

                        if (e.ColumnIndex == 5)
                        {
                            DataGridViewButtonCell b = (DataGridViewButtonCell)gridparcela.Rows[e.RowIndex].Cells[e.ColumnIndex];

                            b.FlatStyle = FlatStyle.Popup;
                            b.Style.BackColor = Color.Silver;

                        }

                        if (e.ColumnIndex == 8)
                        {
                            DataGridViewButtonCell b = (DataGridViewButtonCell)gridparcela.Rows[e.RowIndex].Cells[e.ColumnIndex];

                            b.FlatStyle = FlatStyle.Popup;
                            b.Style.BackColor = Color.Silver;
                        }

                    }
                    else
                    {
                        if (e.ColumnIndex == 1)
                        {
                            DataGridViewButtonCell b = (DataGridViewButtonCell)gridparcela.Rows[e.RowIndex].Cells[e.ColumnIndex];

                            b.FlatStyle = FlatStyle.Popup;
                            b.Style.BackColor = Color.Lime;
                        }

                        if (e.ColumnIndex == 5)
                        {
                            DataGridViewButtonCell b = (DataGridViewButtonCell)gridparcela.Rows[e.RowIndex].Cells[e.ColumnIndex];

                            b.FlatStyle = FlatStyle.Popup;
                            b.Style.BackColor = Color.Lime;
                        }

                        if (e.ColumnIndex == 8)
                        {
                            DataGridViewButtonCell b = (DataGridViewButtonCell)gridparcela.Rows[e.RowIndex].Cells[e.ColumnIndex];

                            b.FlatStyle = FlatStyle.Popup;
                            b.Style.BackColor = Color.Lime;
                        }
                    }



                    if (dtparcelas.Rows[e.RowIndex]["par_estornar"].ToString() == "0")
                    {
                        if (e.ColumnIndex == 2)
                        {
                            DataGridViewButtonCell b = (DataGridViewButtonCell)gridparcela.Rows[e.RowIndex].Cells[e.ColumnIndex];

                            b.FlatStyle = FlatStyle.Popup;
                            b.Style.BackColor = Color.Silver;
                        }

                    }
                    else
                    {
                        if (e.ColumnIndex == 2)
                        {
                            DataGridViewButtonCell b = (DataGridViewButtonCell)gridparcela.Rows[e.RowIndex].Cells[e.ColumnIndex];

                            b.FlatStyle = FlatStyle.Popup;
                            b.Style.BackColor = Color.Red;
                        }
                    }

            }*/

        }

        private void btntodo_Click(object sender, EventArgs e)
        {
       
            carregarparcelas();
            gerarTotal();
            //colorirGrid();
        }

       /* private void colorirGrid()
        {

            foreach (DataGridViewRow row in gridparcela.Rows)
            {
                    row.Cells[1].Style.BackColor = System.Drawing.Color.Blue;
;
            }
        }*/

        private void btndata_Click(object sender, EventArgs e)
        {
            CContaReceber cp = new CContaReceber();
            dtparcelas = cp.carregarParcelasData(dtpi.Value.Date, dtpf.Value.Date);
            gridparcela.DataSource = dtparcelas;
            botaoidcliente = 0;
            gerarTotal();
            colorirGrid();
        }
        private void gerarTotal() {
            decimal valor = 0;
            decimal valorpago = 0;
            for (int i = 0; i < dtparcelas.Rows.Count; i++)
            {
                try { valor+= decimal.Parse(dtparcelas.Rows[i]["par_valor"].ToString()); }
                catch { }
                try { valorpago += decimal.Parse(dtparcelas.Rows[i]["par_valorpago"].ToString()); }
                catch { }
            }

            lbltotal.Text = "Valor Total..: " + valor.ToString("00.00") + "   Valor Total Pago..: " + valorpago.ToString("00.00") + "   Valor Restante..: " + (valor - valorpago).ToString("00.00");
        }

        private void pesquisarcliente()
        {
            string cliente="";
            try
            {
                cliente = ttbcliente.Text;
                dtparcelas = new DataTable();
                CContaReceber cp = new CContaReceber();
                dtparcelas = cp.carregarParcelasCliente(cliente);
                gridparcela.DataSource = dtparcelas;
            }
            catch { }
        }

        private void ttbcliente_TextChanged(object sender, EventArgs e)
        {
            if (ttbcliente.Text=="")
                btntodo.PerformClick();
            else
                pesquisarcliente();
            gerarTotal();
        }

        private void btnimprimir_Click(object sender, EventArgs e)
        {
            string dtvencimentostring, dtpagamentostring;
            string texto = "";
            string valoristring, valorfstring;
            texto = @"
            <html xmlns='http://www.w3.org/1999/xhtml' xmlns:fb='http://ogp.me/ns/fb#' xml:lang='pt-br'>
            <head>
            <meta charset='UTF-8'>
            <title>Relatório de Contas à Receber</title>

            </head>
            <body>";
            texto += "<div style='width:102a4px;margin:0 auto'>";
            texto += @"<div style='width:100%;margin:0 auto;text-align:center;border-top:1px solid black'><h3>CONTAS À RECEBER</h3></div>
                <div style='width:100%;text-align:right'>
                    <div style='float:right'>
                <table>
                <tr><td><b>" + lbltotal.Text+@"<b></td></tr>
                </table></div></div>
<br />
                <hr />";
            texto += @"
                <table>
                <tr style='font-size:18px;font-weight:bolder'>
                    <td width='250px'>Cliente</td>
                    <td width='150px'>Descrição</td>
                    <td width='150px'>Valor R$</td>
                    <td width='150px'>Data Venc.</td>
                    <td width='150px'>Valor Pago R$</td>
                    <td width='150px'>Data Pag.</td>
                </tr>
                </table>
                <hr />
                ";

            if (dtparcelas.Rows.Count > 0)
            {
                texto +=
                    "<table>";

                for (int i = 0; i < dtparcelas.Rows.Count; i++)
                {
                    dtvencimentostring = "";
                    dtpagamentostring = "";
                    try
                    {
                        dtvencimentostring = Convert.ToDateTime(dtparcelas.Rows[i]["par_dtvencimento"].ToString()).ToShortDateString();
                    }
                    catch { }
                    try
                    {
                        dtpagamentostring = Convert.ToDateTime(dtparcelas.Rows[i]["par_dtpagamento"].ToString()).ToShortDateString();
                    }
                    catch { }
                    valoristring = "";
                    valorfstring = "";
                    try
                    {
                        valoristring = decimal.Parse(dtparcelas.Rows[i]["par_valor"].ToString()).ToString("00.00");
                    }
                    catch { }
                    try
                    {
                        valorfstring = decimal.Parse(dtparcelas.Rows[i]["par_valorpago"].ToString()).ToString("00.00");
                    }
                    catch { }
                    texto += "<tr "; if (i % 2 == 0) texto += "style='background-color:lime'";
                    texto += ">";
                    texto +=
                    "<td style='border-bottom:1px solid black' width='250px'>" + dtparcelas.Rows[i]["cli_nome"].ToString() +
                    "<td style='border-bottom:1px solid black' width='150px'>" + dtparcelas.Rows[i]["par_descricao"].ToString() +
                    "</td><td style='border-bottom:1px solid black;text-align:right' width='150px'>" + valoristring +
                    "</td><td style='border-bottom:1px solid black;text-align:center' width='150px'>" + dtvencimentostring +
                    "</td><td style='border-bottom:1px solid black;text-align:right' width='150px'>" + valorfstring +
                    "</td><td style='border-bottom:1px solid black;text-align:center' width='150px'>" + dtpagamentostring +
                    "</tr>";
                }

                texto +=
                    "</table>";
            }

            texto += @"
            </div>
</div>
            </body>
            </html>";
            File.Create(Application.StartupPath + "\\RelContaReceber.html").Close();
            TextWriter f = File.AppendText(Application.StartupPath + "\\RelContaReceber.html");
            f.Write(texto);
            f.Close();
            System.Diagnostics.Process.Start(Application.StartupPath + "\\RelContaReceber.html");
        }

        private void btncliente_Click(object sender, EventArgs e)
        {
            int idcliente = 0;
            FConsultaCliente f = new FConsultaCliente();
            f.ShowDialog();

            if (f.ok)
            {
                try
                {
                    idcliente = int.Parse(f.dt.Rows[f.index]["cli_id"].ToString());
                }
                catch { }
            }
            botaoidcliente = idcliente;
            pesquisarclienteid(idcliente);
        }

        private void FContaReceber_Load(object sender, EventArgs e)
        {
            btndata.PerformClick();
        }
        
        private void pesquisarclienteid(int idcliente)
        {
            CContaReceber c = new CContaReceber();
            dtparcelas = c.carregarParcelasIDCliente(idcliente, dtpi.Value, dtpf.Value);
            gridparcela.DataSource = dtparcelas;


            gerarTotal();

            colorirGrid();
        }

    }
}
