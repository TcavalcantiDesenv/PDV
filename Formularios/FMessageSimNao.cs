using System;
using System.Drawing;
using System.Windows.Forms;

namespace MGMPDV.Formularios
{
    public partial class FMessageSimNao : Form
    {
        int X = 0;
        int Y = 0;
        string titulo = "";
        string mensagem = "";
        public bool ok { get; set; }
        public FMessageSimNao()
        {
            InitializeComponent();
            lbltitulo.MouseDown += new MouseEventHandler(Form3_MouseDown);
            lbltitulo.MouseMove += new MouseEventHandler(Form3_MouseMove);
            pnltitulo.BackColor = Color.FromArgb(50, Color.Black);
            ok = false;


        }

        public bool Mostrar(string titulo, string mensagem)
        {
            this.titulo = titulo;
            this.mensagem = mensagem;
            this.ShowDialog();

            return ok;
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
            if (keyData == Keys.Escape)
            {
                btncancelar.PerformClick();
                return true;   // indicate that you handled this keystroke
            }

            if (keyData == Keys.Enter)
                {
                    btnconfirmar.PerformClick();
                    return true;   // indicate that you handled this keystroke
                }

            


            // Call the base class
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnfechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnconfirmar_Click(object sender, EventArgs e)
        {
            ok = true;
            Close();
        }

        private void FMessageSimNao_Shown(object sender, EventArgs e)
        {
            lbltitulo.Text = titulo;
            lblmensagem.Text = mensagem;
        }
    }
}
