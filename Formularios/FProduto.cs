using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace MGMPDV
{
    public partial class FProduto : Form
    {
        int btnstatus;
        int id = 0;
        int idcategoria = 0;
        int idmarca = 0;
        string ncm = "";
        string aliquota = "";
        string cfop = "";
        CConfiguracao configuracao = new CConfiguracao();

        public FProduto()
        {
            InitializeComponent();
            inicializar();
            if (configuracao.lite > 0)
                ckbestoque.Enabled = false;

        }

        private void inicializar()
        {

            leitura();


            limpar();
        }

        private void limpar()
        {
            ttbcodigo.Clear();
            ttbnome.Clear();
            ttbvalor.Clear();
            ttbdescricao.Clear();
            ttbquantidade.Clear();
            ttbcategoria.Clear();
            idcategoria = 0;

            idmarca = 0;
            ttbncm.Clear();
            ncm = "";
            ttbaliquota.Clear();
            aliquota = "";
            ttbcfop.Clear();
            cfop = "";
            ttbcsosn.Clear();
            ttbcst.Clear();
            ttbcest.Clear();
            ttbporcentagemtributo.Clear();


            //img.Image = null;
            //ttbimagem.Clear();
            id = 0;
            cbbunidade.SelectedIndex = 0;
            cbborigem.SelectedIndex = 0;
            ckbestoque.Checked = false;
            pictureBox1.Image = null;
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



        private void btnsair_Click(object sender, EventArgs e)
        {
            Close();
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
            btnstatus = 0;
            btncategoria.Focus();
        }


        private void btnexcluir_Click(object sender, EventArgs e)
        {
            if (id > 0)
            {
                if (MessageBox.Show("Deseja Excluir?", "Excluir!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    CProduto c = new CProduto();
                    if (c.excluir(id))
                    {
                        limpar();
                        leitura();
                        MessageBox.Show("Excluído com sucesso!");
                    }
                    else MessageBox.Show("Não foi possivel efetuar a exclusão!");
                }
            }
            else
                MessageBox.Show("Selecione um Produto para excluir!");


        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            limpar();
            leitura();
        }

        private void ButGravar_Click(object sender, EventArgs e)
        {

        }
        public byte[] ConvertImageToByteArray(Image image, ImageFormat imageFormat)
        {
            if (image == null)
                return null;
            MemoryStream ms = new MemoryStream();
            image.Save(ms, imageFormat);
            return ms.ToArray();
        }

        public Image ConvertByteArrayToImage(byte[] byteArray)
        {
            if (byteArray == null || byteArray.Length == 0)
            { return (null); }
            return (Image.FromStream(new MemoryStream(byteArray)));
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            MGM mgm = new MGM();

            if (idcategoria <= 0)
            {
                MessageBox.Show("Escolha uma categoria!");
                return;
            }

            if (ttbnome.Text.Trim() == "")
            {
                MessageBox.Show("Campo nome deve ser preenchido!");
                return;
            }

            decimal valor = 0;
            if (!mgm.isDecimal(ttbvalor.Text, false, out valor))
            {
                MessageBox.Show("Campo Valor inválido");
                return;
            }

            decimal quantidade = 0;
            if (!mgm.isDecimal(ttbquantidade.Text, false, out quantidade))
            {
                MessageBox.Show("Campo Quantidade inválido");
                return;
            }

            if (ttbncm.Text.Trim() == "")
            {
                ttbncm.Text = "0";
                ncm = "0";
            }
            ncm = ttbncm.Text;
            aliquota = "0";

            if (ttbaliquota.Text.Trim() == "")
            {
                ttbaliquota.Text = "0";
            }

            try
            {
                decimal.Parse(ttbaliquota.Text);
            }
            catch
            {
                MessageBox.Show("Aliquota inválida!");
                return;
            }

            if (ttbporcentagemtributo.Text.Trim() == "")
            {
                ttbporcentagemtributo.Text = "0";
            }

            try
            {
                decimal.Parse(ttbporcentagemtributo.Text);
            }
            catch
            {
                MessageBox.Show("Porcentagem de Tributos inválido!");
                return;
            }

            cfop = ttbcfop.Text;
            if (cfop.Trim() == "")
            {
                ttbcfop.Text = "0";
                cfop = "0";
                //MessageBox.Show("CFOP inválido!");
                //return;
            }

            if (ttbcest.Text.Trim() == "")
            {
                MessageBox.Show("Código Cest inválido!");
                return;
            }


            int status = 1;
            if (ckbdesativar.Checked)
                status = 0;


            CProduto c = new CProduto();

            int pro_estoque = 0;
            if (ckbestoque.Checked)
                pro_estoque = 1;

            byte[] arrayimagem = new byte[0];
            if (!String.IsNullOrEmpty(pictureBox1.ImageLocation))
            {
                if (new FileInfo(pictureBox1.ImageLocation).Exists)
                {
                    Image Image1 = Image.FromFile(pictureBox1.ImageLocation);
                    arrayimagem = ConvertImageToByteArray(Image1, ImageFormat.Jpeg);
                }
                else
                {
                    MessageBox.Show("Imagem inválida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try {
                    Image Image1 = Image.FromFile(pictureBox1.ImageLocation);
                    arrayimagem = ConvertImageToByteArray(Image1, ImageFormat.Jpeg);
                }
                catch { }
            }

            if (btnstatus == 0)
            {

                c.inserir(idcategoria, idmarca, ttbnome.Text, ttbdescricao.Text, valor, ttbcodigo.Text, cbbunidade.Text, quantidade, pro_estoque, ncm, decimal.Parse(ttbaliquota.Text), cfop, cbborigem.SelectedIndex, decimal.Parse(ttbporcentagemtributo.Text), ttbcsosn.Text, ttbcst.Text, ttbcest.Text, status, arrayimagem);
                //c.inserir(idcategoria, ttbnome.Text, ttbdescricao.Text, valor, ttbcodigo.Text, quantidade,pro_estoque);
            }

            if (btnstatus == 1)
            {
                c.atualizar(id, idcategoria, idmarca, ttbnome.Text, ttbdescricao.Text, valor, ttbcodigo.Text, cbbunidade.Text, quantidade, pro_estoque, ncm, decimal.Parse(ttbaliquota.Text), cfop, cbborigem.SelectedIndex, decimal.Parse(ttbporcentagemtributo.Text), ttbcsosn.Text, ttbcst.Text, ttbcest.Text, status, arrayimagem);
                //c.atualizar(id, idcategoria,ttbnome.Text, ttbdescricao.Text, valor, ttbcodigo.Text, quantidade,pro_estoque);
            }

            limpar();
            leitura();
            MessageBox.Show("Salvo com sucesso!");
        }

        private void mostrar(FConsultaProduto f)
        {
            int index = f.index;
            id = int.Parse(f.dt.Rows[index]["pro_id"].ToString());
            idcategoria = int.Parse(f.dt.Rows[index]["cat_id"].ToString());
            ttbcategoria.Text = f.dt.Rows[index]["cat_nome"].ToString();
            ttbnome.Text = f.dt.Rows[index]["pro_nome"].ToString();
            ttbdescricao.Text = f.dt.Rows[index]["pro_descricao"].ToString();
            ttbvalor.Text = decimal.Parse(f.dt.Rows[index]["pro_valor"].ToString()).ToString("00.00");
            ttbquantidade.Text = decimal.Parse(f.dt.Rows[index]["pro_quantidade"].ToString()).ToString("00");
            ttbcodigo.Text = f.dt.Rows[index]["pro_codigo"].ToString();
            cbbunidade.SelectedItem = f.dt.Rows[index]["pro_unidade"].ToString();
            ckbestoque.Checked = (int.Parse(f.dt.Rows[index]["pro_estoque"].ToString()) == 1);
            ckbdesativar.Checked = (int.Parse(f.dt.Rows[index]["pro_status"].ToString()) != 1);
            ttbncm.Text = f.dt.Rows[index]["pro_ncm"].ToString();
            ncm = ttbncm.Text;
            ttbaliquota.Text = f.dt.Rows[index]["pro_aliquota"].ToString();
            aliquota = ttbaliquota.Text;
            ttbcfop.Text = f.dt.Rows[index]["pro_cfop"].ToString();
            cfop = ttbcfop.Text;
            cbborigem.SelectedIndex = int.Parse(f.dt.Rows[index]["pro_origem"].ToString());
            ttbporcentagemtributo.Text = decimal.Parse(f.dt.Rows[index]["pro_porcentagemtributo"].ToString()).ToString("00.00");
            ttbcst.Text = f.dt.Rows[index]["pro_cst"].ToString();
            ttbcsosn.Text = f.dt.Rows[index]["pro_csosn"].ToString();
            ttbcest.Text = f.dt.Rows[index]["pro_cest"].ToString();
            Image Image1 = null;
            Image1 = ConvertByteArrayToImage((f.dt.Rows[index]["pro_imagem"] as byte[]));

            pictureBox1.Image = Image1;
            pictureBox1.Refresh();
            pictureBox1.Update();
            //ttbimagem.Text = f.dt.Rows[index]["pro_imagem"].ToString();
        }
        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            FConsultaProduto f = new FConsultaProduto();
            f.ShowDialog();
            if (f.ok)
            {
                mostrar(f);
                btncategoria.Focus();
                gravacao();
                btnstatus = 1;
            }
            else
                id = 0;
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

        private void btncategoria_Click(object sender, EventArgs e)
        {
            FConsultaCategoria f = new FConsultaCategoria();
            f.ShowDialog();

            if (f.ok)
            {
                idcategoria = int.Parse(f.dt.Rows[f.index]["cat_id"].ToString());
                ttbcategoria.Text = f.dt.Rows[f.index]["cat_nome"].ToString();
            }
        }

        private void btncategoriaadd_Click(object sender, EventArgs e)
        {
            FCategoria f = new FCategoria();
            f.ShowDialog();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnimg_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            string arquivo;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "JPG,JPEG,BMP,PNG |*.jpg;*.bmp;*.png;*.jpeg";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        arquivo = openFileDialog1.FileName;
                        //ttbimagem.Text = arquivo;
                        //img.Load(arquivo);
                    }
                }
                catch
                {
                    MessageBox.Show("Erro ao abrir o arquivo");
                }
            }

        }

        private void btnimagem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Imagem do Produto";
                dlg.Filter = "Imagens |*.bmp;*.jpg;*.png;*.jpeg";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    // Create a new Bitmap object from the picture file on disk,
                    // and assign that to the PictureBox.Image property
                    pictureBox1.ImageLocation = dlg.FileName;
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ttbdescricao_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnimagemexcluir_Click(object sender, EventArgs e)
        {
            byte[] arrayimagem = new byte[0];
            pictureBox1.ImageLocation = "";
            Image Image1 = null;
            pictureBox1.Image = Image1;
            pictureBox1.Refresh();
            pictureBox1.Update();
        }
    }
}
