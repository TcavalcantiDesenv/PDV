using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace MGMPDV.Formularios
{
    public partial class FCancelarCupom : Form
    {
        int X = 0;
        int Y = 0;

        public int idfuncionario { get; set; }
        DataTable dt = new DataTable();
        public int cai_numero { get; set; }

        public FCancelarCupom(int idfuncionario, int cai_numero)
        {
            
            InitializeComponent();
            pnldescricao.BackColor = Color.FromArgb(50, Color.Black);
            pnltitulo.BackColor = Color.FromArgb(50, Color.Black);
            //grid.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            //grid.EnableHeadersVisualStyles = false;
            lbltitulo.MouseDown += new MouseEventHandler(Form3_MouseDown);
            lbltitulo.MouseMove += new MouseEventHandler(Form3_MouseMove);
            grid.Columns["ven_hora"].DefaultCellStyle.Format = "HH:mm:ss";
            grid.AutoGenerateColumns = false;
            
            this.idfuncionario = idfuncionario;
            this.cai_numero = cai_numero;
            carregar();
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

                Close();
                return true;    // indicate that you handled this keystroke
            }

            if (keyData == Keys.Enter)
            {

                if (!grid.Focused)
                {
                    grid.Focus();
                }
                else
                {
                    selecionar();
                }
                return true;    // indicate that you handled this keystroke
            }

            // Call the base class
            return base.ProcessCmdKey(ref msg, keyData);
        }
        
        private void selecionar()
        {
            try
            {
                if (dt.Rows.Count < 1)
                {
                    FMessageOk fmok = new FMessageOk();
                    fmok.Mostrar("Não há cupons para serem cancelados!");
                    return;
                }

                int index = grid.SelectedCells[0].RowIndex;
                int idvenda = int.Parse(dt.Rows[index]["ven_id"].ToString());
                FVendaDetalhe f = new FVendaDetalhe(idfuncionario, idvenda);
                f.ShowDialog();
                carregar();
            }
            catch { }
        }

        private void grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            selecionar();
        }

        private void dtpdata_ValueChanged(object sender, EventArgs e)
        {
            carregar();
        }

        private void carregar()
        {
            CSat sat = new CSat();
            dt = sat.carregarData(dtpdata.Value,cai_numero);
            grid.DataSource = dt;
        }

        private void FCancelarCupom_Load(object sender, EventArgs e)
        {
            carregar();
        }

        private void btnfechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void grid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (grid.Columns[e.ColumnIndex].Name == "ven_hora")
            {
                if (e.Value == null || e.Value.ToString() == "")
                {
                    return;
                }

                e.Value = Convert.ToDateTime(e.Value.ToString()).ToString("T");
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btncancelarvendaaberta_Click(object sender, EventArgs e)
        {
            selecionar();
        }
    }
}
