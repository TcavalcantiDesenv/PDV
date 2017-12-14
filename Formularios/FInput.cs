using System;
using System.Drawing;
using System.Speech.Synthesis;
using System.Windows.Forms;

namespace MGMPDV.Formularios
{
    public partial class FInput : Form
    {
        int X = 0;
        int Y = 0;
        string titulo = "";
        string mensagem = "";
        string texto2 = "FALANDO";
        bool ok;
        public string valor { get; set; }
        public FInput()
        {
            InitializeComponent();
            //lbltitulo.MouseDown += new MouseEventHandler(Form3_MouseDown);
            //lbltitulo.MouseMove += new MouseEventHandler(Form3_MouseMove);
            pnltitulo.BackColor = Color.FromArgb(50, Color.Black);
            ok = false;
            valor = "";

        }

        public bool Mostrar(string titulo, string mensagem)
        {
            ok = false;
            this.titulo = titulo;
            this.mensagem = mensagem;
            ttbvalor.Focus();
            this.ShowDialog();

            return ok;
        }

        public bool Mostrar(string titulo, string mensagem, string valor)
        {
            ok = false;
            this.titulo = titulo;
            this.mensagem = mensagem;
            ttbvalor.Text = valor;
            ttbvalor.Focus();
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

        private void btnsair_Click(object sender, EventArgs e)
        {
            ok = false;
            Close();
        }

        private void FInput_Shown(object sender, EventArgs e)
        {
            lbltitulo.Text = titulo;
            lblmensagem.Text = mensagem;
        }

        private void btnconfirmar_Click(object sender, EventArgs e)
        {
            valor = ttbvalor.Text;
            ok = true;
            Close();
        }
        SpeechSynthesizer reader;
        void reader_SpeakCompleted(object sender, SpeakCompletedEventArgs e)
        {
            texto2 = "IDLE";
        }

        public void falar(string texto)
        {
            textBox1.Text = texto;
            //     reader.Dispose();
            if (textBox1.Text != "")
            {

                reader = new SpeechSynthesizer();
                reader.SpeakAsync(textBox1.Text);
                texto2 = "FALANDO";
                button2.Enabled = true;
                button4.Enabled = true;
                reader.SpeakCompleted += new EventHandler<SpeakCompletedEventArgs>(reader_SpeakCompleted);
            }
            else
            {
                MessageBox.Show("Digite alguma frase", "Message", MessageBoxButtons.OK);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            falar("um.");
            ttbvalor.Text += button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            falar("dois.");
            ttbvalor.Text += button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            falar("três.");
            ttbvalor.Text += button3.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            falar("quatro.");
            ttbvalor.Text += button6.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            falar("cinco.");
            ttbvalor.Text += button5.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            falar("seis.");
            ttbvalor.Text += button4.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            falar("sete.");
            ttbvalor.Text += button10.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            falar("oito.");
            ttbvalor.Text += button8.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            falar("nove.");
            ttbvalor.Text += button7.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            falar("ponto.");
            ttbvalor.Text += button13.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            falar("zero.");
            ttbvalor.Text += button12.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (ttbvalor.Text != "")
            {
                ttbvalor.Text = ttbvalor.Text.Remove(ttbvalor.TextLength - 1);
            }
        }
    }
}
