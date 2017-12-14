using System;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MGMPDV
{
    public partial class FConsultaCliente : Form
    {
        public bool ok { get; set; }
        public DataTable dt { get; set; }
        public int index { get; set; }
 

        int X = 0;
        int Y = 0;

        bool botaook = true;
        public FConsultaCliente()
        {
            InitializeComponent();
            grid.AutoGenerateColumns = false;
            pnltitulo.BackColor = Color.FromArgb(50, Color.Black);

            lbltitulo.MouseDown += new MouseEventHandler(Form3_MouseDown);
            lbltitulo.MouseMove += new MouseEventHandler(Form3_MouseMove);

            ok = false;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                if (grid.Focused)
                    selecionar();
                else
                    enterclique();
                return true;   // indicate that you handled this keystroke
            }

            if (keyData == Keys.Delete)
            {
                if(ttbcliente.Focused)
                    ttbcliente.Clear();
                return true;   // indicate that you handled this keystroke
            }

            if (keyData == Keys.Escape)
            {
                Close();
                return true;   // indicate that you handled this keystroke
            }



            // Call the base class
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private static bool isValid(String str)
        {
            return Regex.IsMatch(str, @"^[a-zA-Z0-9]+$");
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

        private void enterclique()
        {

                CCliente c = new CCliente();
                dt = c.pesquisar(ttbcliente.Text, "nome");
                grid.DataSource = dt;
                if (dt.Rows.Count > 0)
                    grid.Focus();


    
        }

        private void btnfechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblproduto_Enter(object sender, EventArgs e)
        {
        }

        private void lblproduto_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void limpar()
        {
            ttbcliente.Text = "";
        }

        private void FConsultaCliente_Load(object sender, EventArgs e)
        {
            ttbcliente.Focus();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {

            enterclique();
        }


        private void timer2_Tick(object sender, EventArgs e)
        {
            ttbcliente.Clear();
            timer2.Enabled = false;
        }

        private void grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
                    selecionar();
        }

        private void selecionar()
        {
            try
            {
                if (dt.Rows.Count > 0)
                {
                    ok = true;
                    index = grid.CurrentRow.Index;
                }
            }
            catch { }
            Close();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnconfirmar_Click(object sender, EventArgs e)
        {
            FCliente f = new FCliente();
            f.ShowDialog();
        }

        private void ttbcliente_Click(object sender, EventArgs e)
        {
            ttbcliente.Clear();
        }
    }
}
