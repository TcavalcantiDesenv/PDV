using System;
using System.Drawing;
using System.Windows.Forms;

namespace MGMPDV.Formularios
{
    public partial class FInputDataPicker : Form
    {
        public DateTime data { get; set; }
        public bool ok { get; set; }
        public string valor { get; set; }
        public bool somenteleitura = false;

        public FInputDataPicker(string datalabel, DateTime data, string valorlabel,string valor)
        {
            InitializeComponent();
            pnltitulo.BackColor = Color.FromArgb(50, Color.Black);
            ok = false;
            lblvalor.Text = valorlabel;
            lbldata.Text = datalabel;
            dtp.Value = data;
            this.data = data;
            ttbvalor.Text = valor;
            this.valor = valor;
        }

        public FInputDataPicker(string datalabel, DateTime data, string valorlabel, string valor, bool somenteleitura)
        {
            InitializeComponent();
            pnltitulo.BackColor = Color.FromArgb(50, Color.Black);
            ok = false;
            lblvalor.Text = valorlabel;
            lbldata.Text = datalabel;
            dtp.Value = data;
            this.data = data;
            ttbvalor.Text = valor;
            this.valor = valor;
            if(somenteleitura)
            {
                ttbvalor.ReadOnly = true;
            }
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
            try
            {
                decimal.Parse(ttbvalor.Text);
            }
            catch { FMessageOk f = new FMessageOk(); f.Mostrar("Valor inválido!"); return; }
            valor = ttbvalor.Text;
            Close();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            ok = false;
            data = dtp.Value;
            valor = ttbvalor.Text;
            Close();
        }
    }
}
