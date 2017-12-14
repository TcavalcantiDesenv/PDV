using MGMPDV.Classes;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MGMPDV.Formularios
{
    public partial class FAbrirCaixa : Form
    {
        int X = 0;
        int Y = 0;
        CIniFile Ini = new CIniFile();
        string caixanum = "";
        int idfuncionario;
        DataTable dtcaixa = new DataTable();
        bool cai_status = false;
        DataTable dtfuncionario = new DataTable();
        public int numerocaixa { get; set; }
        public int idcaixa {get; set;}
        public bool ok { get; set; }
        public FAbrirCaixa(int idfuncionario)
        {
            InitializeComponent();
            Ini.IniFile("checkout");
            caixanum = Ini.IniReadString("Caixa", "Numero", "");

            lbltitulo.MouseDown += new MouseEventHandler(Form3_MouseDown);
            lbltitulo.MouseMove += new MouseEventHandler(Form3_MouseMove);
            pnltitulo.BackColor = Color.FromArgb(50, Color.Black);
            pnlbot.BackColor = Color.FromArgb(50, Color.Black);


            this.idfuncionario = idfuncionario;
            ok = false;
            idcaixa = 0;
            numerocaixa = 0;
            CFuncionario c = new CFuncionario();
            dtfuncionario = c.pesquisarID(idfuncionario);
            try {
                ttbusuario.Text = dtfuncionario.Rows[0]["fun_usuario"].ToString();
            }
            catch { }
            carregarcaixa();
            selecionarCaixa();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {





            // Call the base class
            return base.ProcessCmdKey(ref msg, keyData);
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

        private void carregarcaixa()
        {
            //TextReader f = null;
            //try
            //{
            //    f = File.OpenText(Application.StartupPath + "\\Caixa.ini");
            //}
            //catch { MessageBox.Show("Erro ao abrir arquivo de conexão"); return; }

            //string caixastring = f.ReadLine();

            //f.Close();

            //if (caixastring.Trim() == "")
            //{
            //    MessageBox.Show("Erro na configuração do Caixa!");
            //}

            ttbcaixanumero.Text = caixanum;// caixastring;
            int numerocaixa = 0;
            int.TryParse(ttbcaixanumero.Text, out numerocaixa);
            this.numerocaixa = numerocaixa;
            
        }

        private void gridcaixa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                selecionarCaixa();

            }
            catch { }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (lblstatus.Visible)
                ttbvalor.ReadOnly = true;
            else
                ttbvalor.ReadOnly = false;
            lblhora.Text = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();
        }

        private void selecionarCaixa()
        {

            if (numerocaixa == 0)
                return;


            CCaixa caixa = new CCaixa();
            DataTable dt = caixa.pegaultimo(numerocaixa);
            try
            {
                cai_status = (dt.Rows[0]["cai_status"].ToString() == "1");
            }
            catch { cai_status = false; }

            decimal valor = 0;
            int cai_id = 0;
            if (cai_status)
            {
                lblstatus.Visible = true;
                try
                {
                    int.TryParse(dt.Rows[0]["cai_id"].ToString(), out cai_id);
                    this.idcaixa = cai_id;
                    valor = caixa.totalCaixa(cai_id);
                }
                catch { }
            }
            else
                lblstatus.Visible = false;

            ttbvalor.Text = valor.ToString("00.00");
            
            ttbvalor.Focus();
            
            
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {

            Close();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            FMessageSimNao f = new FMessageSimNao();
            FMessageOk fm = new FMessageOk();
            
            if (cai_status)
            {
              
                if(f.Mostrar("Caixa Aberto!","O Caixa está aberto, deseja fechar?"))
                {
                    FFecharCaixa1 fecharcaixa = new FFecharCaixa1(idfuncionario,idcaixa);
                    fecharcaixa.ShowDialog();
                }
                carregarcaixa();
                selecionarCaixa();

            }


            MGM mgm = new MGM();
            decimal valor = 0;
            if(!mgm.isDecimal(ttbvalor.Text, false, out valor))
            {
                fm.Mostrar("Valor inválido!");
                return;
            }
            f = new FMessageSimNao();
            //if(valor>0)
            //{
            if (cai_status)
            {
               
                if (f.Mostrar("Abrir Caixa", "Deseja reabrir o caixa com o valor R$: " + ttbvalor.Text + " ? " ))
                {

                    if (idcaixa > 0)
                        ok = true;
                    else
                        fm.Mostrar("Falha ao abrir caixa!");

                    Close();
                }
            }
            else
                if (f.Mostrar("Abrir Caixa", "Deseja abrir o caixa com o valor R$: " + ttbvalor.Text + "?"))
                {
                    CCaixa c = new CCaixa();
                
                    idcaixa = c.abrir(numerocaixa, idfuncionario, valor, DateTime.Now.Date, DateTime.Now);
                    if (idcaixa > 0)
                        ok = true;
                    else
                        fm.Mostrar("Falha ao abrir caixa!");

                    Close();
                }
                      

        }



        private void FAbrirCaixa_KeyUp(object sender, KeyEventArgs e)
        {


            if (e.KeyCode == Keys.Escape)
                btncancelar.PerformClick();

        }


        private void ttbvalor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
               
                 btnsair.PerformClick();

            }
        }
    }
}
