using System;
using System.Windows.Forms;

namespace MGMPDV
{
    public partial class FConfiguracao : Form
    {
        public FConfiguracao()
        {
            InitializeComponent();

            limpar();
            carregar();
        }

        public FConfiguracao(string bina, string senha)
        {
            InitializeComponent();


            limpar();
            carregar();
        }


        private void limpar()
        {
            ttbmensagem.Clear();

        }

        private void carregar()
        {
            CConfiguracao c = new CConfiguracao();
            ttbmensagem.Text = c.mensagem;
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja cancelar as alterações?", "Cancelar!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                limpar();
                carregar();
            }

        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            CConfiguracao c = new CConfiguracao();

  
            c.salvar(ttbmensagem.Text, 0, 0, 0, "S");
            MessageBox.Show("Salvo com Sucesso!");
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

        private void btnempresa_Click(object sender, EventArgs e)
        {
            FEmpresa f = new FEmpresa();
            f.ShowDialog();
        }
    }
}
