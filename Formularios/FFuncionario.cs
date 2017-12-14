using System;
using System.Data;
using System.Windows.Forms;

namespace MGMPDV
{
    public partial class FFuncionario : Form
    {
        int status;
        int fun_id=0;
        string usuarioselecionado = "";
        DataTable dtcidade = new DataTable();

        public FFuncionario()
        {
            InitializeComponent();
            inicializar();
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

        private void carregacidade()
        {
            CCidade cc = new CCidade();
            dtcidade = cc.pesquisar("", "nome");
            cbbcidade.DataSource = dtcidade;
            
        }

        private void inicializar()
        {
            limpar();
            leitura();
        }

        private void limpar()
        {
            ttbnome.Clear();
            cbbsexo.SelectedIndex = -1;
            ttbrg.Clear();
            ttbcpf.Clear();
            dtpnascimento.Value = DateTime.Now;
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
            //cbbnivel.Text = "";
            cbbnivel.SelectedIndex = 2;
            ckbdesativar.Checked = false;
            ttbusuario.Clear();
            ttbsenha.Clear();
          

            fun_id = 0;
            
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

        private void mostrar(FConsultaFuncionario f)
        {
            int index = f.index;
            fun_id = int.Parse(f.dt.Rows[index]["fun_id"].ToString());
            ttbnome.Text = f.dt.Rows[index]["fun_nome"].ToString();
            cbbsexo.SelectedItem = f.dt.Rows[index]["fun_sexo"].ToString();
            ttbrg.Text = f.dt.Rows[index]["fun_rg"].ToString();
            ttbcpf.Text = f.dt.Rows[index]["fun_cpf"].ToString();
            dtpnascimento.Value = Convert.ToDateTime(f.dt.Rows[index]["fun_dtnascimento"].ToString());
            ttbendereco.Text = f.dt.Rows[index]["fun_endereco"].ToString();
            ttbnumero.Text = f.dt.Rows[index]["fun_numero"].ToString();
            ttbbairro.Text = f.dt.Rows[index]["fun_bairro"].ToString();
            cbbcidade.SelectedValue = f.dt.Rows[index]["cid_id"].ToString();
            ttbuf.Text = f.dt.Rows[index]["cid_uf"].ToString();
            ttbcep.Text = f.dt.Rows[index]["fun_cep"].ToString();
            ttbddd1.Text = f.dt.Rows[index]["fun_ddd1"].ToString();
            ttbddd2.Text = f.dt.Rows[index]["fun_ddd2"].ToString();
            ttbddd3.Text = f.dt.Rows[index]["fun_ddd3"].ToString();
            ttbtelefone1.Text = f.dt.Rows[index]["fun_telefone1"].ToString();
            ttbtelefone2.Text = f.dt.Rows[index]["fun_telefone2"].ToString();
            ttbtelefone3.Text = f.dt.Rows[index]["fun_telefone3"].ToString();
            ttbinformacao.Text = f.dt.Rows[index]["fun_informacao"].ToString();
            ttbemail.Text = f.dt.Rows[index]["fun_email"].ToString();
            ttbusuario.Text = f.dt.Rows[index]["fun_usuario"].ToString();
            usuarioselecionado = ttbusuario.Text;
            ttbsenha.Text = f.dt.Rows[index]["fun_senha"].ToString();

            cbbnivel.SelectedItem = f.dt.Rows[index]["fun_nivel"].ToString();
            if (int.Parse(f.dt.Rows[index]["fun_status"].ToString()) == 1)
            {
                ckbdesativar.Checked = false;
            }
            else
                ckbdesativar.Checked = true;
            
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

            if (cbbsexo.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione um sexo!");
                return;
            }

            if (cbbcidade.SelectedIndex < 0)
	        {
                MessageBox.Show("Selecione uma cidade!");
                return;
	        }

            if (ttbusuario.Text.Trim()=="")
            {
                MessageBox.Show("Informe um usuario");
                return;
            }

            if (ttbsenha.Text.Trim() == "")
            {
                MessageBox.Show("Informe uma senha");
                return;
            }

            if (cbbnivel.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione um nível!");
                return;
            }

            CFuncionario c = new CFuncionario();
            c.fun_nome = ttbnome.Text;
            c.fun_sexo = cbbsexo.Text;
            c.fun_rg = ttbrg.Text;
            c.fun_cpf = ttbcpf.Text;
            c.fun_dtnascimento = dtpnascimento.Value.Date;
            c.fun_endereco = ttbendereco.Text;
            c.fun_numero = ttbnumero.Text;
            c.fun_bairro = ttbbairro.Text;
            c.cid_id = int.Parse(cbbcidade.SelectedValue.ToString());
            c.fun_cep = ttbcep.Text;
            c.fun_ddd1 = ttbddd1.Text;
            c.fun_ddd2 = ttbddd2.Text;
            c.fun_ddd3 = ttbddd3.Text;
            c.fun_telefone1 = ttbtelefone1.Text;
            c.fun_telefone2 = ttbtelefone2.Text;
            c.fun_telefone3 = ttbtelefone3.Text;
            c.fun_informacao = ttbinformacao.Text;
            c.fun_email = ttbemail.Text;
            c.fun_usuario = ttbusuario.Text;
            c.fun_senha = ttbsenha.Text;
            c.fun_nivel = cbbnivel.Text;
            if (ckbdesativar.Checked)
                c.fun_status = 0;
            else
                c.fun_status = 1;

            if (status == 0)
            {
                DataTable dt = c.pesquisar(ttbusuario.Text, "usuario");
                if (dt.Rows.Count>0)
                {
                    MessageBox.Show("Usuário já existe");
                    return;
                }
                else
                    c.inserir();
            }

            if (status == 1)
            {
                if (ttbusuario.Text != usuarioselecionado)
                {
                    DataTable dt = c.pesquisarExiste(ttbusuario.Text, "usuario");
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Usuário já existe");
                        return;
                    }
                   
                        
                }

                c.atualizar(fun_id);
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
            FConsultaFuncionario f = new FConsultaFuncionario();
            f.ShowDialog();
            if (f.ok)
            {
                mostrar(f);
                gravacao();
                ttbnome.Focus();
                status = 1;
            }
            else
                fun_id = 0;
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            if (fun_id > 0)
            {
                if (MessageBox.Show("Deseja Excluir?", "Excluir!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    CFuncionario c = new CFuncionario();
                    if (c.excluir(fun_id))
                    {
                        limpar();
                        leitura();
                        MessageBox.Show("Excluído com sucesso!");
                    }
                    else MessageBox.Show("Não foi possivel efetuar a exclusão!");
                }
            }
            else
                MessageBox.Show("Selecione um Funcionario para excluir!");


            
        }

        private void btnsair_Click_2(object sender, EventArgs e)
        {
            Close();
        }

        private void cbbcidade_SelectedIndexChanged(object sender, EventArgs e)
        {
      

        }

        private void ttbsenha_TextChanged(object sender, EventArgs e)
        {


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


    }
}
