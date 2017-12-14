using System;
using System.Windows.Forms;

namespace MGMPDV
{
    public partial class FCidade : Form
    {
        int status;
        int id;
        public FCidade()
        {
            InitializeComponent();
            inicializar();
        }

        private void inicializar()
        {
            limpar();
            leitura();
        }

        private void limpar()
        {
            ttbnome.Clear();
            ttbuf.Clear();
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

        private void mostrar(FConsultaCidade f)
        {
            int index = f.index;
            id = int.Parse(f.dt.Rows[index]["cid_id"].ToString());
            ttbnome.Text = f.dt.Rows[index]["cid_nome"].ToString();
            ttbuf.Text = f.dt.Rows[index]["cid_uf"].ToString();

            
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

            CCidade c = new CCidade();
            c.nome = ttbnome.Text;
            c.uf = ttbuf.Text;


            if (status == 0)
            {
                c.inserir();
            }

            if (status == 1)
            {
                c.atualizar(id);
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
            FConsultaCidade f = new FConsultaCidade();
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
                    CCidade c = new CCidade();
                    if (c.excluir(id))
                    {
                        limpar();
                        leitura();
                        MessageBox.Show("Excluído com sucesso!");
                    }
                    else
                        MessageBox.Show("Não foi possivel efetuar a exclusão!");

                }
            }
            else
                MessageBox.Show("Selecione um Categoria para excluir!");


            
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

    }
}
