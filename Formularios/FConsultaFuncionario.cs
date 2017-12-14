using System;
using System.Data;
using System.Windows.Forms;

namespace MGMPDV
{
    public partial class FConsultaFuncionario : Form
    {
        public bool ok { get; set; }
        public DataTable dt { get; set; }
        public int index { get; set; }

        public FConsultaFuncionario()
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

        private void button2_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            CFuncionario c = new CFuncionario();
            dt = c.pesquisar(ttbpesquisar.Text, cbbfiltro.Text);
            grid.DataSource = dt;
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

        private void FConsultaCliente_Load(object sender, EventArgs e)
        {
            btnpesquisar.PerformClick();
        }
    }
}
