using System;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MGMPDV
{
    public partial class FConsultaProduto : Form
    {
        public bool ok { get; set; }
        public DataTable dt { get; set; }
        public int index { get; set; }
        string componente = "";

        bool mover = false;
        int X = 0;
        int Y = 0;
        bool botaook = true;
        public FConsultaProduto()
        {
            InitializeComponent();
            grid.AutoGenerateColumns = false;
            pnltitulo.BackColor = Color.FromArgb(50, Color.Black);
           // grid.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.Info;
           // grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
           // grid.ColumnHeadersDefaultCellStyle.Font = new Font("Courier New", 12);
           // grid.RowsDefaultCellStyle.Font = new Font("Courier New", 12);
           // grid.RowTemplate.Height = 40;
           // grid.EnableHeadersVisualStyles = false;

            lbltitulo.MouseDown += new MouseEventHandler(Form3_MouseDown);
            lbltitulo.MouseMove += new MouseEventHandler(Form3_MouseMove);

            ok = false;
        }

        private void FConsultaProduto_Load(object sender, EventArgs e)
        {
            ttbproduto.Focus();
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
                if (ttbproduto.Focused)
                    ttbproduto.Clear();
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
            //if (componente == "ttbproduto")
            //{
            CProduto c = new CProduto();
            dt = c.pesquisar(ttbproduto.Text, "");
            grid.DataSource = dt;
            if (dt.Rows.Count > 0)
                grid.Focus();

            botaook = false;
            //}
        }

        private void lblproduto_Enter(object sender, EventArgs e)
        {
            if (sender is Label)
                componente = (sender as Label).Name;
            if (sender is TextBox)
                componente = (sender as TextBox).Name;
            if (sender is Button)
                componente = (sender as Button).Name;
        }

        private void limpar()
        {
            ttbproduto.Text = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            enterclique();
        }

        private void grid_Enter(object sender, EventArgs e)
        {
            componente = "grid";
        }

        private void lbltitulo_MouseUp(object sender, MouseEventArgs e)
        {
            mover = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            ttbproduto.Clear();
            timer2.Enabled = false;
        }

        private void ttbproduto_TextChanged(object sender, EventArgs e)
        {
            timer2.Enabled = false;
            timer2.Enabled = true;
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {

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
                Close();
            }
            catch { }
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                selecionar();
        }

        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnconfirmar_Click(object sender, EventArgs e)
        {
            FProduto f = new FProduto();
            f.ShowDialog();
        }

        private void ttbproduto_Click(object sender, EventArgs e)
        {
            ttbproduto.Clear();
        }
    }
}
