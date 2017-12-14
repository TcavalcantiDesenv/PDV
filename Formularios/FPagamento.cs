using MGMPDV.Classes;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Speech.Synthesis;
using System.Windows.Forms;

namespace MGMPDV.Formularios
{
    public partial class FPagamento : Form
    {
        public bool ok { get; set; }
        public string titulo { get; set; }
        public decimal valortotal { get; set; }
        public decimal valorpago { get; set; }
        public int quantidadeparcela { get; set; }
        public int idcompra { get; set; }
        public int idvenda { get; set; }
        public int idcliente { get; set; }
        public int idcaixa { get; set; }
        public DateTime dtvencimento { get; set; }
        public bool avista { get; set; }

        public decimal desconto { get; set; }
        public decimal troco { get; set; }
        decimal valordepagamento { get; set; }

        private DateTime datahora { get; set; }

        private CContaReceber contareceber = new CContaReceber();

        private CContaPagar contapagar = new CContaPagar();

        private CVenda venda = new CVenda();

        private int[] vetidparcela;

        public string Parcelas = "0";
        int X = 0;
        int Y = 0;
        DataTable dtmeiopagamento = new DataTable();
        int idmeiopagamento = -1;
        string INTPOS = "";

        SpeechSynthesizer reader;
        void reader_SpeakCompleted(object sender, SpeakCompletedEventArgs e)
        {
           string modelo = "IDLE";
        }
        public void falar(string texto)
        {
            ttbtroco.Text = texto;
            //     reader.Dispose();
            if (ttbtroco.Text != "")
            {

                reader = new SpeechSynthesizer();
                label2.Text = "FALANDO";
                reader.SpeakCompleted += new EventHandler<SpeakCompletedEventArgs>(reader_SpeakCompleted);
            }
            else
            {
                MessageBox.Show("Digite alguma frase", "Message", MessageBoxButtons.OK);
            }
        }

        string Caminhoreq = "";
        DataTable dt = new DataTable();

        FMessageOk fmok = new FMessageOk();

        public FPagamento(int idvenda, int idcompra, decimal valortotal, decimal desconto)
        {
            InitializeComponent();
            lbltitulo.MouseDown += new MouseEventHandler(Form3_MouseDown);
            lbltitulo.MouseMove += new MouseEventHandler(Form3_MouseMove);
            gridmeiopagamento.AutoGenerateColumns = false;
            grid.AutoGenerateColumns = false;
            gridproduto.AutoGenerateColumns = false;
            pnltitulo.BackColor = Color.FromArgb(50, Color.Black);
            ok = false;
            this.idvenda = idvenda;
            this.idcompra = idcompra;
            this.idcaixa = idcaixa;
            this.valortotal = valortotal;
            this.desconto = desconto;



            if (idvenda <= 0)
            {
                ttbdesconto.ReadOnly = true;
            }


            vetidparcela = new int[1000];
            datahora = DateTime.Now;

            Carregar();

            falar("Insira o seu cartão de crédito ou débito.");
        }

        public void RequisitaTEF(string vendaID, string numCupom, string valor, string parcela)
        {
            INTPOS = "000-000 = CRT" + " " + @"
001-000 = " + vendaID + @"
002-000 = " + numCupom + @"
003-000 = " + valor + @"
017-000 = 1" + " " + @"
018-000 = " + parcela + @" 
999-999 = 0" + "" + @"";
           Caminhoreq = @"C:\Client\Req\INTPOS.001A";
            System.IO.File.WriteAllText(Caminhoreq, INTPOS);
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


            decimal valor = 0;
            try
            {
                valor = decimal.Parse(ttbtotal.Text);
            }
            catch { }
            if (valor > 0)
            {
                if (keyData == Keys.F1)
                {
                    // abrirmeiopagamento();
                    btndinheiro.PerformClick();
                    return true;
                }


                if (keyData == Keys.F2)
                {
                    // abrirmeiopagamento();
                    btndebito.PerformClick();
                    return true;
                }


                if (keyData == Keys.F3)
                {
                    // abrirmeiopagamento();
                    btncartao.PerformClick();
                    return true;
                }


                if (keyData == Keys.F4)
                {
                    // abrirmeiopagamento();
                    btncheque.PerformClick();
                    return true;
                }


                if (keyData == Keys.F5)
                {
                    // abrirmeiopagamento();
                    btnconvenio.PerformClick();
                    return true;
                }


                if (keyData == Keys.F6)
                {
                    // abrirmeiopagamento();
                    btndesconto.PerformClick();
                    return true;
                }
            }
            //if (keyData == Keys.Enter)
            // {
            //btnconfirmar.PerformClick();
            //   return true;
            // }



            if (keyData == Keys.Escape)
            {
                try
                {
                    int index = grid.Rows.Count - 1;
                    if(index >= 0) contareceber.removerParcela(int.Parse(dt.Rows[index]["par_id"].ToString()));
                    Carregar();
                }
                catch { }

                Close();

                if (pnlmeiopagamento.Visible)
                {
                    pnlmeiopagamento.Visible = false;
                }
                else
                    btncancelar.PerformClick();
                return true;
            }
            if (keyData == Keys.Delete)
            {
                try {
                    int index = grid.Rows.Count - 1;
                    contareceber.removerParcela(int.Parse(dt.Rows[index]["par_id"].ToString()));
                    Carregar();
                }
                catch { }
                return true;
            }



            // Call the base class
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void abrirmeiopagamento()
        {
            pnlmeiopagamento.Visible = !pnlmeiopagamento.Visible;
            pnlmeiopagamento.Left = 0;
            pnlmeiopagamento.Top = 36;

            if (pnlmeiopagamento.Visible)
            {
                gridmeiopagamento.Focus();
                CMeioPagamento c = new CMeioPagamento();
                dtmeiopagamento = c.carregar();
                gridmeiopagamento.DataSource = dtmeiopagamento;
            }
        }
        private void btnfechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnmeiopagamento_Click(object sender, EventArgs e)
        {
            abrirmeiopagamento();
        }

        private void selecionarMeioPagamento()
        {

        }

        private void gridmeiopagamento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if(dtmeiopagamento.Rows.Count>0)
                if (dtmeiopagamento.Rows[gridmeiopagamento.SelectedRows[0].Index][0].ToString() != "")
                {
                    selecionarMeioPagamento();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            decimal valor = 0;
            try
            {
                valor = decimal.Parse(ttbtotal.Text);
            }
            catch { }
            if(valor<=0)
            {
                btndinheiro.Enabled = false;
                btncheque.Enabled = false;
                btndebito.Enabled = false;
                btncartao.Enabled = false;
                btnconvenio.Enabled = false;
                btndesconto.Enabled = false;
            }
            else
            {
                btndinheiro.Enabled = true;
                btncheque.Enabled = true;
                btndebito.Enabled = true;
                btncartao.Enabled = true;
                btnconvenio.Enabled = true;
                btndesconto.Enabled = true;
            }
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            ok = true;
            Close();
        }



        private void Carregar()
        {

            if (idvenda > 0)
            {
                CCaixa caixa = new CCaixa();
                idcaixa = caixa.pegaIdAberto();
                valorpago = 0;
                dt = contareceber.carregarParcelas(idvenda);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    valorpago += decimal.Parse(dt.Rows[i]["par_valor"].ToString());
                }

                venda = new CVenda();
                venda.pesquisarvendaIdVenda(idvenda);
                desconto = venda.ven_desconto;
                grid.DataSource = dt;

                CItemVenda c = new CItemVenda();
                DataTable dtitemvenda = c.pesquisar(idvenda);
                gridproduto.DataSource = dtitemvenda;

            }
            else
            {

                CCaixa caixa = new CCaixa();
                idcaixa = caixa.pegaIdAberto();

            }

            mostrar();
        }

        private void limparvetor()
        {
            for (int i = 0; i < vetidparcela.Length; i++)
            {
                vetidparcela[i] = 0;
            }
        }

        private void mostrar()
        {
            try
            {
                ttbsubtotal.Text = valortotal.ToString("00.00");
                ttbdesconto.Text = desconto.ToString("00.00");
                ttbtotalpago.Text = valorpago.ToString("00.00");
                calcular();
            }
            catch { }
        }

        private void calcular()
        {
            ttbtotalpago.Text = valorpago.ToString("00.00");

            decimal totalapagar = (valortotal - valorpago - desconto);
            if (totalapagar < 0)
                totalapagar = 0;
            ttbtotal.Text = totalapagar.ToString("00.00");

            if (valorpago > valortotal - desconto)
                troco = valorpago - (valortotal - desconto);
            else
                troco = 0;

            ttbtroco.Text = troco.ToString("00.00");
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            removerVetor();
            Carregar();
            if (decimal.Parse(ttbtotal.Text) <= 0)
            {
                ok = true;
               
            }
            else
                ok = false;
            Close();
        }

        public void FechaVenda()
        {
            removerVetor();
            Carregar();
            if (decimal.Parse(ttbtotal.Text) <= 0)
            {
                ok = true;

            }
            else
                ok = false;
            Close();
        }
        private void btnconfirmar_Click(object sender, EventArgs e)
        {
            if (idvenda <= 0)
            {
                if (troco < 0)
                {
                    return;
                }
            }
       

            if (idvenda > 0)
            {
                CVenda c = new CVenda();
                c.atualizarDesconto(idvenda, desconto);
            }

            if (troco >= 0)
            {
                ok = true;
            }
            else
                ok = false;

            if (idvenda > 0)
            {

                Close();
            }
            else
            {
                if (ok)
                    Close();
                else
                    Carregar();
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void inserirVetor(int[] vetor)
        {
            bool ok = true;
            for (int i = 0; i < vetor.Length; i++)
            {
                ok = true;
                for (int j = 0; j < vetidparcela.Length; j++)
                {
                    if (ok)
                        if (vetidparcela[j] == 0)
                        {
                            ok = false;
                            vetidparcela[j] = vetor[i];

                        }
                }
            }
        }

        private void removerVetor()
        {
            for (int i = 0; i < vetidparcela.Length; i++)
            {
                if (vetidparcela[i] != 0)
                {
                    if (idvenda > 0)
                        contareceber.removerParcela(vetidparcela[i]);
                    else
                        contapagar.removerParcela(vetidparcela[i]);
                }
            }
        }


        private void ttbvalor_TextChanged(object sender, EventArgs e)
        {
            calcular();
        }


        private void FPagamento_Load(object sender, EventArgs e)
        {
            datahora = DateTime.Now;
        }

        private void btnenter_Click(object sender, EventArgs e)
        {



        }

        private void gridmeiopagamento_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dtmeiopagamento.Rows.Count > 0)
                selecionarMeioPagamento();

        }

        private void ttbvalor_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void lbltitulo_Click(object sender, EventArgs e)
        {

        }


        private void gridproduto_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.gridproduto.Rows[e.RowIndex].Cells[0].Value
= (e.RowIndex + 1).ToString();
        }

        private void btndesconto_Click(object sender, EventArgs e)
        {
            FInput f = new FInput();
            if(f.Mostrar("Aplicar Desconto", "Informe a porcentagem de desconto"))
            {
                try
                {
                    //ttbdesconto.Text = (decimal.Parse(ttbdesconto.Text) + decimal.Parse(f.valor)).ToString("00.00");
                    CVenda c = new CVenda();
                    decimal desconto = decimal.Parse(ttbsubtotal.Text) * (decimal.Parse(f.valor) / 100);
                    c.aplicardesconto(idvenda, desconto);
                    Carregar();
                }
                catch {  }
            }
        }

        private void btndinheiro_Click(object sender, EventArgs e)
        {
            FInput f = new FInput();
            if (f.Mostrar("Dinheiro", "Informe o valor de pagamento",ttbtotal.Text))
            {
                try
                {
                    decimal valor = decimal.Parse(f.valor);
                    if(valor<=0)
                    {
                        fmok.Mostrar("Valor de pagamento inválido!");
                        return;
                    }
                    idmeiopagamento = 1;
                    if (valor > decimal.Parse(ttbtotal.Text))
                    {
                        decimal troco = valor - decimal.Parse(ttbtotal.Text); ;
                        valor = decimal.Parse(ttbtotal.Text);

                        contareceber.insereContaReceber(idvenda, 1, valor, DateTime.Now.Date, true, idcaixa, 0, "Dinheiro", idmeiopagamento);

                        idmeiopagamento = 0;
                        Carregar();
                        ttbtroco.Text = troco.ToString("00.00");
                    }
                    else
                    {
                        contareceber.insereContaReceber(idvenda, 1, valor, DateTime.Now.Date, true, idcaixa, 0, "Dinheiro", idmeiopagamento);

                        idmeiopagamento = 0;
                        Carregar();
                    }


                }
                catch { fmok.Mostrar("Valor de pagamento inválido!"); }
            }
        }

        private void grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
          /*  try
            {
                int id = int.Parse(dt.Rows[e.RowIndex]["par_id"].ToString());
                CContaReceber c = new CContaReceber();
                c.removerParcela(id);
                Carregar();
            }
            catch { }*/

        }

        private void btncartao_Click(object sender, EventArgs e)
        {
            FInput f = new FInput();
            if (f.Mostrar("Crédito", "Informe o valor de pagamento", ttbtotal.Text))
            {
                try
                {
                    decimal valorpagamento = decimal.Parse(f.valor);
                    if (valorpagamento <= 0)
                    {
                        fmok.Mostrar("Valor de pagamento inválido!");
                        return;
                    }
                    try
                    {                       
                        if (f.Mostrar("Crédito", "Informe a quantidade de Parcelas","1"))
                        {
                            int quantidade = int.Parse(f.valor);
                            if (quantidade <= 0)
                            {
                                fmok.Mostrar("Quantidade de Parcelas inválido!");
                                return;
                            }
                            idmeiopagamento = 1;
                            decimal restante = decimal.Parse(ttbtotal.Text);

                            MGM mgm = new MGM();
                            decimal[] vetparcela = mgm.gerarParcelamento(quantidade, valorpagamento);
                            Parcelas = quantidade.ToString();
                            for (int i = 0; i < vetparcela.Length; i++)
                            {
                                CContaReceber c = new CContaReceber();
                                avista = false;
                                c.insereContaReceber(idvenda, i + 1, vetparcela[i], DateTime.Now.AddMonths(i), avista, idcaixa, idcliente, "Cartão de Crédito", 3);                               
                            }
                           
                            Carregar(); // apresenta apenas a forma de pagamento no grid
                            troco.ToString("00.00");

                            string cupom = acBrECF1.NumCupom;
                            RequisitaTEF(idvenda.ToString(), cupom, valorpagamento.ToString(), quantidade.ToString());
                            TimerSts.Enabled = true;

                          //  FechaVenda();
                        }


                    }
                    catch { fmok.Mostrar("Quantidade de Parcelas inválido!"); }
                }
                catch
                {
                    fmok.Mostrar("Valor de pagamento inválido!");
                }


            }
        }

        private void btndebito_Click(object sender, EventArgs e)
        {
            FInput f = new FInput();
            if (f.Mostrar("Débito", "Informe o valor de pagamento", ttbtotal.Text))
            {
                try
                {
                    decimal valorpagamento = decimal.Parse(f.valor);
                    if (valorpagamento <= 0)
                    {
                        fmok.Mostrar("Valor de pagamento inválido!");
                        return;
                    }

                    idmeiopagamento = 1;
                    decimal restante = decimal.Parse(ttbtotal.Text);
                    /*if (valorpagamento > restante)
                    {
                        decimal troco = valorpagamento - restante;
                        valordepagamento = restante;
                    }*/
                    MGM mgm = new MGM();

                    CContaReceber c = new CContaReceber();
                    avista = true;
                    c.insereContaReceber(idvenda, 1, valorpagamento, DateTime.Now, avista, idcaixa, idcliente, "Cartão de Débito", 4);

                    Carregar();
                    troco.ToString("00.00");
                       
                }
                catch
                {
                    fmok.Mostrar("Valor de pagamento inválido!");
                }


            }
        }

        private void btncheque_Click(object sender, EventArgs e)
        {
            FInput f = new FInput();
            FInputDataPicker fdata = new FInputDataPicker("Primeiro vencimento", DateTime.Now.AddMonths(1), "Quantidade de Parcelas","1");

            if (f.Mostrar("Cheque", "Informe o valor de pagamento", ttbtotal.Text))
            {
                try
                {
                    decimal valorpagamento = decimal.Parse(f.valor);
                    if (valorpagamento <= 0)
                    {
                        fmok.Mostrar("Valor de pagamento inválido!");
                        return;
                    }
                    try
                    {
                        fdata.ShowDialog();

                        if (fdata.ok)
                        {
                            int quantidade = int.Parse(fdata.valor);
                            if (quantidade <= 0)
                            {
                                fmok.Mostrar("Quantidade de Parcelas inválido!");
                                return;
                            }


                            DateTime data = fdata.data;
                            idmeiopagamento = 1;
                            decimal restante = decimal.Parse(ttbtotal.Text);
                            /*if (valorpagamento > restante)
                            {
                                decimal troco = valorpagamento - restante;
                                valordepagamento = restante;
                            }*/
                            MGM mgm = new MGM();
                            decimal[] vetparcela = mgm.gerarParcelamento(quantidade, valorpagamento);
                            for (int i = 0; i < vetparcela.Length; i++)
                            {
                                CContaReceber c = new CContaReceber();
                                avista = false;
                                c.insereContaReceber(idvenda, i + 1, vetparcela[i], data.AddMonths(i), avista, idcaixa, idcliente, "Cheque", 2);
                            }


                            Carregar();
                            troco.ToString("00.00");
                            /* if (valorpagamento > restante)
                             {
                                 ttbtroco.Text = troco.ToString("00.00");

                                 idmeiopagamento = 0;
                                 Carregar();
                             }*/
                        }


                    }
                    catch { fmok.Mostrar("Quantidade de Parcelas inválido!"); }
                }
                catch
                {
                    fmok.Mostrar("Valor de pagamento inválido!");
                }


            }
        }

        private void btnconvenio_Click(object sender, EventArgs e)
        {
            FInput f = new FInput();
            FInputDataPicker fdata = new FInputDataPicker("Primeiro vencimento!", DateTime.Now.AddMonths(1),"Quantidade de parcelas","1");

            if (f.Mostrar("Convenio", "Informe o valor de pagamento", ttbtotal.Text))
            {
                try
                {
                    decimal valorpagamento = decimal.Parse(f.valor);
                    if (valorpagamento <= 0)
                    {
                        fmok.Mostrar("Valor de pagamento inválido!");
                        return;
                    }
                    try
                    {
                        fdata.ShowDialog();
                        
                        if (fdata.ok)
                        {
                            int quantidade = int.Parse(fdata.valor);
                            if (quantidade <= 0)
                            {
                                fmok.Mostrar("Quantidade de Parcelas inválido!");
                                return;
                            }

                           
                            DateTime data = fdata.data;

                            if (venda.cli_id <= 0)
                            {
                                FConsultaCliente fcli = new FConsultaCliente();
                                fcli.ShowDialog();
                                if (!fcli.ok)
                                {
                                    fmok.Mostrar("Cliente inválido!");
                                    return;

                                }
                                idcliente = int.Parse(fcli.dt.Rows[fcli.index]["cli_id"].ToString());
                                venda.atualizarClienteFuncionario(venda.ven_id, idcliente, venda.fun_id);
                                
                            }
                            idmeiopagamento = 1;
                            decimal restante = decimal.Parse(ttbtotal.Text);
                            /*if (valorpagamento > restante)
                            {
                                decimal troco = valorpagamento - restante;
                                valordepagamento = restante;
                            }*/
                            MGM mgm = new MGM();
                            decimal[] vetparcela = mgm.gerarParcelamento(quantidade, valorpagamento);
                            for (int i = 0; i < vetparcela.Length; i++)
                            {
                                CContaReceber c = new CContaReceber();
                                avista = false;
                                c.insereContaReceber(idvenda, i + 1, vetparcela[i], data.AddMonths(i), avista, idcaixa, idcliente, "Marcar", 5);
                            }


                            Carregar();
                            troco.ToString("00.00");
                            /* if (valorpagamento > restante)
                             {
                                 ttbtroco.Text = troco.ToString("00.00");

                                 idmeiopagamento = 0;
                                 Carregar();
                             }*/
                        }


                    }
                    catch { fmok.Mostrar("Quantidade de Parcelas inválido!"); }
                }
                catch
                {
                    fmok.Mostrar("Valor de pagamento inválido!");
                }


            }
        }

        private void btncancelardesconto_Click(object sender, EventArgs e)
        {
            CVenda venda = new CVenda();
            venda.pesquisarvendaIdVenda(idvenda);
            decimal desconto = -1 * venda.ven_desconto;
            venda.aplicardesconto(idvenda, desconto);
            Carregar();
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dt.Rows.Count >0)
            {
                if(e.RowIndex>=0)
                {
                    if(e.ColumnIndex==0)
                    {
                        try
                        {
                            int id = int.Parse(dt.Rows[e.RowIndex]["par_id"].ToString());
                            CContaReceber c = new CContaReceber();
                            c.removerParcela(id);
                            Carregar();
                        }
                        catch { }
                    }
                }

            }
        }

        private void TimerSts_Tick(object sender, EventArgs e)
        {
            string fileName = @"C:\Client\Resp\IntPos.Sts"; ;
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }

            string fileName2 = @"C:\Client\Resp\IntPos.001";
            if (File.Exists(fileName2))
            {
               // File.Delete(fileName2);
                TimerSts.Enabled = false;
                FechaVenda();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int index = grid.Rows.Count - 1;
                if (index >= 0) contareceber.removerParcela(int.Parse(dt.Rows[index]["par_id"].ToString()));
                Carregar();
            }
            catch { }

            Close();

            if (pnlmeiopagamento.Visible)
            {
                pnlmeiopagamento.Visible = false;
            }
            else
                btncancelar.PerformClick();
           
        }
    }
}
