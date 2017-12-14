using System;
using System.IO;
using System.Windows.Forms;

namespace MGMPDV
{
    public partial class FEmpresa : Form
    {
        CEmpresa cempresa;
        public FEmpresa()
        {
            InitializeComponent();
            cempresa = new CEmpresa();
            cempresa.pesquisar();
            limpar();
            mostrar();
        }

        private void mostrar()
        {
            if (cempresa.emp_id<=0)
            {
                return;
            }
            ttbbairro.Text = cempresa.emp_bairro;
            ttbcep.Text = cempresa.emp_cep;
            ttbcidade.Text = cempresa.emp_cidade;
            ttbuf.Text = cempresa.emp_uf;
            ttbemail.Text = cempresa.emp_email;
            ttbendereco.Text = cempresa.emp_endereco;
            ttbnumero.Text = cempresa.emp_numero;
            ttblogo.Text = cempresa.emp_logo;
            ttbrazao.Text = cempresa.emp_razao;
            ttbcnpj.Text = cempresa.emp_cnpj;
            ttbie.Text = cempresa.emp_ie;
            ttbfantasia.Text = cempresa.emp_fantasia;
            ttbsite.Text = cempresa.emp_site;
            ttbtelefone1.Text = cempresa.emp_telefone1;
            ttbtelefone2.Text = cempresa.emp_telefone2;
            ttbtelefone3.Text = cempresa.emp_telefone3;
           
            try
            {
                pblogo.Load(ttblogo.Text);
            }
            catch { }
        }

        private void limpar()
        {
            
            ttbbairro.Clear();
            ttbcep.Clear();
            ttbcidade.Clear(); 
            ttbuf.Clear();
            ttbemail.Clear();
            ttbendereco.Clear();
            ttbnumero.Clear();
            ttblogo.Clear();
            ttbrazao.Clear();
            ttbcnpj.Clear();
            ttbfantasia.Clear(); 
            ttbsite.Clear();
            ttbtelefone1.Clear();
            ttbtelefone2.Clear();
            ttbtelefone3.Clear();
        }
        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            string arquivo;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\" ;
            openFileDialog1.Filter = "JPG,JPEG,BMP,PNG |*.jpg;*.bmp;*.png;*.jpeg";
            openFileDialog1.FilterIndex = 2 ;
            openFileDialog1.RestoreDirectory = true ;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        arquivo = openFileDialog1.FileName;
                        ttblogo.Text = arquivo;
                        pblogo.Load(arquivo);
                    }
                }
                catch 
                {
                    MessageBox.Show("Erro ao abrir o arquivo");
                }
            }
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            limpar();
            mostrar();
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            cempresa = new CEmpresa();
            cempresa.emp_bairro = ttbbairro.Text;
            cempresa.emp_cep = ttbcep.Text;
            cempresa.emp_cidade = ttbcidade.Text;
            cempresa.emp_cnpj = ttbcnpj.Text;
            cempresa.emp_email = ttbemail.Text;
            cempresa.emp_endereco = ttbendereco.Text;
            cempresa.emp_fantasia = ttbfantasia.Text;
            cempresa.emp_logo = ttblogo.Text;
            cempresa.emp_numero = ttbnumero.Text;
            cempresa.emp_razao = ttbrazao.Text;
            cempresa.emp_site = ttbsite.Text;
            cempresa.emp_telefone1 = ttbtelefone1.Text;
            cempresa.emp_telefone2 = ttbtelefone2.Text;
            cempresa.emp_telefone3 = ttbtelefone3.Text;
            cempresa.emp_uf = ttbuf.Text;


            if (ttbfantasia.Text.Trim()=="")
            {
                MessageBox.Show("Fantasia deve ser preenchido");
                return;
            }
            cempresa.atualizar();
            MessageBox.Show("Salvo com sucesso!");
            Close();
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
