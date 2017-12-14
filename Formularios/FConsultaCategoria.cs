using System;
using System.Data;
using System.Windows.Forms;

namespace MGMPDV
{
    public partial class FConsultaCategoria : Form
    {
        public bool ok { get; set; }
        public DataTable dt { get; set; }
        public int index { get; set; }

        public FConsultaCategoria()
        {

            InitializeComponent();
            ok = false;
            cbbfiltro.SelectedIndex = 0;
            grid.AutoGenerateColumns = false;

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                Close();
                return true;    // indicate that you handled this keystroke
            }
            if (keyData == Keys.Enter)
            {
                if (dt.Rows.Count > 0)
                {
                    ok = true;
                    index = grid.CurrentRow.Index;
                }
                Close();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pesquisar();
        }

        private void grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dt.Rows.Count > 0)
            {
                ok = true;
                index = grid.CurrentRow.Index;
            }
            Close();
        }

        private void FConsultaCategoria_Load(object sender, EventArgs e)
        {
            btnpesquisar.PerformClick();
        }

        private void ttbpesquisar_TextChanged(object sender, EventArgs e)
        {
            pesquisar();
        }

        private void pesquisar()
        {
            dt = new DataTable();
            CCategoria c = new CCategoria();
            dt = c.pesquisar(ttbpesquisar.Text, cbbfiltro.Text);
            grid.DataSource = dt;
        }
    }
}
