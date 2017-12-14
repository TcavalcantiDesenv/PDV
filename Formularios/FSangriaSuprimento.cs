using System;
using System.Drawing;
using System.Windows.Forms;

namespace MGMPDV.Formularios
{
    public partial class FSangriaSuprimento : Form
    {
        int fun_id = 0;
        int cai_id = 0;
        int X = 0;
        int Y = 0;
        public FSangriaSuprimento(int idfuncionario, int idcaixa)
        {
            InitializeComponent();
            lbltitulo.MouseDown += new MouseEventHandler(Form3_MouseDown);
            lbltitulo.MouseMove += new MouseEventHandler(Form3_MouseMove);
            pnltitulo.BackColor = Color.FromArgb(50, Color.Black);
            this.fun_id = idfuncionario;
            this.cai_id = idcaixa;
            ttbvalor.Clear();
            ttbinformacao.Clear();
            ttbvalor.Focus();


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

        private void btnsair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnconfirmar_Click(object sender, EventArgs e)
        {
            if (rbtsuprimento.Checked)
            {
                FMessageSimNao f = new FMessageSimNao();
                if (!f.Mostrar("Depositar no Caixa", "Deseja efetuar o depósito?"))
                {
                    return;
                }
                decimal valor = 0;
                MGM mgm = new MGM();
                FMessageOk fmok = new FMessageOk();
                if (!mgm.isDecimal(ttbvalor.Text, false, out valor))
                {
                    fmok.Mostrar("Valor inválido");
                    return;
                }

                CTransacao cc = new CTransacao();
                cc.inserir(cai_id, valor, 'C', "SUPRIMENTO", ttbinformacao.Text, fun_id);
                fmok.Mostrar("Depositado com Sucesso");
            }
            else
            {
                FMessageSimNao f = new FMessageSimNao();
                if (!f.Mostrar("Retirar do Caixa", "Deseja efetuar a retirada?"))
                {
                    return;
                }
                decimal valor = 0;
                MGM mgm = new MGM();
                FMessageOk fmok = new FMessageOk();
                if (!mgm.isDecimal(ttbvalor.Text, false, out valor))
                {
                    fmok.Mostrar("Valor inválido");
                    return;
                }

                CTransacao cc = new CTransacao();
                cc.inserir(cai_id, (-1) * valor, 'D', "SANGRIA", ttbinformacao.Text, fun_id);
                fmok.Mostrar("Retirado com Sucesso");
                Close();
            }
            Close();
        }
    }
}
