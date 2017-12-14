using System;
using System.Data;
using System.Windows.Forms;


namespace MGMPDV
{
    public partial class FCliente : Form
    {
        int status;
        int id;
        DataTable dtcidade = new DataTable();
        public string cpfcnpj { get; set; }


        public FCliente()
        {
            InitializeComponent();
            inicializar();
            cpfcnpj = "";
        }

        private void inicializar()
        {
            limpar();
            leitura();
        }
        private void carregacidade()
        {
            CCidade cc = new CCidade();
            dtcidade = cc.pesquisar("", "nome");
            cbbcidade.DataSource = dtcidade;
        }

        private void limpar()
        {
            ttbnome.Clear();
            ttbrg.Clear();
            ttbcpf.Clear();
            dtpdtnascimento.Value = DateTime.Now;
            ttbendereco.Clear();
            ttbnumero.Clear();
            ttbbairro.Clear();
            carregacidade();
            cbbcidade.SelectedIndex = -1;
            ttbuf.Clear();
            ttbcep.Clear();
            ttbddd1.Clear();
            ttbddd2.Clear();
            ttbddd3.Clear();
            ttbtelefone1.Clear();
            ttbtelefone2.Clear();
            ttbtelefone3.Clear();
            ttbinformacao.Clear();
            ttbemail.Clear();
            cbbsexo.SelectedIndex = -1;
            id = 0;
        }

        private void leitura()
        {
            btnnovo.Enabled = true;
            btnsalvar.Enabled = false;
            btncancelar.Enabled = false;
            btnexcluir.Enabled = false;
           
            btnpesquisar.Enabled = true;
            pnlcampos.Enabled = false;
        }

        private void gravacao()
        {
            btnnovo.Enabled = false;
            btnsalvar.Enabled = true;
            btncancelar.Enabled = true;
            btnexcluir.Enabled = true;
           
            btnpesquisar.Enabled = false;
            pnlcampos.Enabled = true;
        }

        private void mostrar(FConsultaCliente f)
        {
            int index = f.index;
            id = int.Parse(f.dt.Rows[index]["cli_id"].ToString());
            ttbnome.Text = f.dt.Rows[index]["cli_nome"].ToString();
            cbbsexo.SelectedItem = f.dt.Rows[index]["cli_sexo"].ToString();
            ttbrg.Text = f.dt.Rows[index]["cli_rg"].ToString();
            ttbcpf.Text = f.dt.Rows[index]["cli_cpf"].ToString();
            dtpdtnascimento.Value = Convert.ToDateTime(f.dt.Rows[index]["cli_dtnascimento"].ToString());
            ttbendereco.Text = f.dt.Rows[index]["cli_endereco"].ToString();
            ttbnumero.Text = f.dt.Rows[index]["cli_numero"].ToString();
            ttbbairro.Text = f.dt.Rows[index]["cli_bairro"].ToString();
           /* try
            { cbbcidade.SelectedValue = f.dt.Rows[index]["cid_id"].ToString(); }
            catch { cbbcidade.SelectedIndex = -1; }
            CCidade cc = new CCidade();
            DataTable dt = cc.pesquisar(cbbcidade.SelectedValue.ToString(), "id");

            if (dt.Rows.Count > 0)
                ttbuf.Text = dt.Rows[0]["cid_uf"].ToString();*/
            cbbcidade.SelectedValue = f.dt.Rows[index]["cid_id"].ToString();
            ttbuf.Text = f.dt.Rows[index]["cid_uf"].ToString();
           
            ttbcep.Text = f.dt.Rows[index]["cli_cep"].ToString();
            ttbddd1.Text = f.dt.Rows[index]["cli_ddd1"].ToString();
            ttbddd2.Text = f.dt.Rows[index]["cli_ddd2"].ToString();
            ttbddd3.Text = f.dt.Rows[index]["cli_ddd3"].ToString();
            ttbtelefone1.Text = f.dt.Rows[index]["cli_telefone1"].ToString();
            ttbtelefone2.Text = f.dt.Rows[index]["cli_telefone2"].ToString();
            ttbtelefone3.Text = f.dt.Rows[index]["cli_telefone3"].ToString();
            ttbinformacao.Text = f.dt.Rows[index]["cli_informacao"].ToString();
            ttbemail.Text = f.dt.Rows[index]["cli_email"].ToString();
            
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            if (ttbnome.Text.Trim()=="")
            {
                MessageBox.Show("Campo nome deve ser preenchido!");
                return;
            }

            if (cbbsexo.SelectedIndex <0)
            {
                MessageBox.Show("Selecione o sexo do cliente!");
                return;
            }

            if (cbbcidade.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione uma cidade!");
                return;
            }

            CCliente c = new CCliente();
            c.nome = ttbnome.Text;
            c.sexo = cbbsexo.Text;
            c.rg = ttbrg.Text;
            c.cpf = ttbcpf.Text;
            c.dtnascimento = dtpdtnascimento.Value.Date;
            c.endereco = ttbendereco.Text;
            c.numero = ttbnumero.Text;
            c.bairro = ttbbairro.Text;
            c.cid_id = int.Parse(cbbcidade.SelectedValue.ToString());
            c.cep =ttbcep.Text;
            c.ddd1 = ttbddd1.Text;
            c.ddd2 = ttbddd2.Text;
            c.ddd3 = ttbddd3.Text;
            c.telefone1 = ttbtelefone1.Text;
            c.telefone2 = ttbtelefone2.Text;
            c.telefone3 = ttbtelefone3.Text;
            c.informacao = ttbinformacao.Text;
            c.email = ttbemail.Text;
            cpfcnpj = c.cpf;

            if (status == 0)
            {
                c.inserircliente();
            }

            if (status == 1)
            {
                c.atualizarcliente(id);
            }

            limpar();
            leitura();
            MessageBox.Show("Salvo com sucesso!");
        }

        private void btnsair_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnnovo_Click(object sender, EventArgs e)
        {
            limpar();
            gravacao();
            btnexcluir.Enabled = false;
            status = 0;
            ttbnome.Focus();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            limpar();
            leitura();
        }

        private void btnalterar_Click(object sender, EventArgs e)
        {
            gravacao();
            status = 1;
        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            FConsultaCliente f = new FConsultaCliente();
            f.ShowDialog();
            if (f.ok)
            {
                mostrar(f);
                gravacao();
                ttbnome.Focus();
                status = 1;
            }
            else
                id = 0;
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            if (id > 0)
            {
                if (MessageBox.Show("Deseja Excluir?", "Excluir!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    CCliente c = new CCliente();
                    CVenda venda = new CVenda();
                    DataTable dt = new DataTable();
                    dt = venda.pesquisarIDCliente(id);
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Não foi possivel efetuar a exclusão!");
                        return;
                    }
                    CVenda creceber = new CVenda();
                    dt = new DataTable();
                    dt = creceber.pesquisarIDCliente(id);
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Não foi possivel efetuar a exclusão!");
                        return;
                    }

                    if (c.excluircliente(id))
                    {

                        limpar();
                        leitura();
                        MessageBox.Show("Excluído com sucesso!");
                    }
                    else MessageBox.Show("Não foi possivel efetuar a exclusão!");
                }
            }
            else
                MessageBox.Show("Selecione um cliente para excluir!");


            
        }

        private void cbbcidade_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CCidade cc = new CCidade();
            DataTable dt = cc.pesquisar(cbbcidade.SelectedValue.ToString(), "id");

            if (dt.Rows.Count > 0)
                ttbuf.Text = dt.Rows[0]["cid_uf"].ToString();
        }

        private void btncidade_Click(object sender, EventArgs e)
        {
            FCidade f = new FCidade();
            f.ShowDialog();
            carregacidade();
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

        private void FCliente_Load(object sender, EventArgs e)
        {
            if (cpfcnpj != "")
            {
                btnnovo.PerformClick();
                ttbcpf.Text = cpfcnpj;
            }
        }
    }
}
