using System;
using System.Windows.Forms;

namespace MGMPDV
{
    public partial class FCategoria : Form
    {
        int status;
        CCategoria c;
        int id;
        public FCategoria()
        {
            InitializeComponent();
            inicializar();
        }

        private void inicializar()
        {
            limpar();
            leitura();
        }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {

                Close();
                return true;
            }

            // Call the base class
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void limpar()
        {
            ttbnome.Clear();
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

        private void mostrar(FConsultaCategoria f)
        {
            int index = f.index;
            id = int.Parse(f.dt.Rows[index]["cat_id"].ToString());
            ttbnome.Text = f.dt.Rows[index]["cat_nome"].ToString();


        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            if (ttbnome.Text.Trim() == "")
            {
                MessageBox.Show("Campo nome deve ser preenchido!");
                return;
            }

            CCategoria c = new CCategoria();
            c.nome = ttbnome.Text;


            if (status == 0)
            {
                c.inserirCategoria();
            }

            if (status == 1)
            {
                c.atualizarCategoria(id);
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
            FConsultaCategoria f = new FConsultaCategoria();
            f.ShowDialog();
            if (f.ok)
            {
                mostrar(f);
                gravacao();
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
                    CCategoria c = new CCategoria();
                    if (c.excluirCategoria(id))
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

    }
}
