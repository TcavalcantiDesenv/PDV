using System;
using System.Windows.Forms;

namespace MGMPDV.Formularios
{
    public partial class FMessageOk : Form
    {
        int X = 0;
        int Y = 0;
        string titulo = "";
        string mensagem = "";
        public bool ok { get; set; }
        public FMessageOk()
        {
            InitializeComponent();
            lbltitulo.MouseDown += new MouseEventHandler(Form3_MouseDown);
            lbltitulo.MouseMove += new MouseEventHandler(Form3_MouseMove);
            ok = false;
        }

        public void EsconderBotao()
        {
            btnconfirmar.Visible = false;
        }
        public void MostrarBotao()
        {
            btnconfirmar.Visible = true;
        }

        public void Mostrar(string mensagem)
        {
            
            this.mensagem = mensagem;
            this.ShowDialog();

        }
        public void Fechar()
        {

            Close();

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


            if (keyData == Keys.Enter || keyData == Keys.Space)
            {
                btnconfirmar.PerformClick();
                return true;   // indicate that you handled this keystroke
            }




            // Call the base class
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void FMessageOk_Shown(object sender, EventArgs e)
        {

            lblmensagem.Text = mensagem;
        }

        private void btnconfirmar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
