using System;
using System.Drawing;
using System.Windows.Forms;

namespace MGMPDV.Formularios
{
    public partial class FDataPicker : Form
    {
        public DateTime data { get; set; }
        public bool ok { get; set; }
        public FDataPicker(string labeltexto, DateTime data)
        {
            InitializeComponent();
            pnltitulo.BackColor = Color.FromArgb(50, Color.Black);
            lbltexto.Text = labeltexto;
            dtp.Value = data;
            this.data = data;
            ok = false;
        }

        private void lblmensagem_Click(object sender, EventArgs e)
        {

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

        private void btnconfirmar_Click(object sender, EventArgs e)
        {
            ok = true;
            data = dtp.Value;
            Close();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            ok = false;
            data = dtp.Value;
            Close();
        }
    }
}
