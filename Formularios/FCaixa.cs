using System;
using System.Data;
using System.Windows.Forms;

namespace MGMPDV
{
    public partial class FCaixa : Form
    {
        int X = 0;
        int Y = 0;
        DataTable dtgrid = new DataTable();
        public bool ok
        {
            get; set;
        }
        public int index {get; set;}
        public int idcaixa { get; set; }
        public FCaixa()
        {
            InitializeComponent();
            lbltitulo.MouseDown += new MouseEventHandler(Form3_MouseDown);
            lbltitulo.MouseMove += new MouseEventHandler(Form3_MouseMove);
            grid.AutoGenerateColumns = false;
            CCaixa c = new CCaixa();
            dtgrid = c.pegaDataIeDataF(dtpdata.Value.Date, dtpdata.Value.Date);
            grid.DataSource = dtgrid;
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

        private void btnfechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dtpdata_ValueChanged(object sender, EventArgs e)
        {
            CCaixa c = new CCaixa();
            dtgrid = c.pegaDataIeDataF(dtpdata.Value.Date, dtpdata.Value.Date);
            grid.DataSource = dtgrid;
        }

        private void grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                selecionarlinha();
        }

        private void selecionarlinha()
        {
            try
            {
                if (dtgrid.Rows.Count > 0)
                {
                    ok = true;
                    index = grid.CurrentRow.Index;
                    idcaixa = int.Parse(dtgrid.Rows[index]["cai_id"].ToString());
                }
            }
            catch { }
            Close();
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0)
                if(e.ColumnIndex==0)
                selecionarlinha();
        }
    }
}
