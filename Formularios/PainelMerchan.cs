using MGMPDV.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MGMPDV.Formularios
{
   
    public partial class PainelMerchan : Form
    {
        string arqmedia = string.Empty;
        CIniFile Ini = new CIniFile();
        public PainelMerchan()
        {
            InitializeComponent();

            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.KeyPreview = true;
            this.TopMost = true;

            Ini.IniFile("checkout");
            arqmedia = Ini.IniReadString("video", "caminho", "");

            this.TopMost = true;

            iniciavideo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog video = new OpenFileDialog();

            if (video.ShowDialog() == DialogResult.OK)
            {
                MediaVideo.URL = video.FileName;

            }
        }

        public void iniciavideo()
        {
            //TextReader f = null;
            //try
            //{
            //    f = File.OpenText(Application.StartupPath + "\\Media.ini");
            //}
            //catch { MessageBox.Show("Erro ao abrir arquivo de conexão"); return; }

            //arqmedia = f.ReadLine();

            //f.Close();

            //MediaVideo.URL = Application.StartupPath + arqmedia;// @"\videos\video.mp4";

            MediaVideo.URL =  arqmedia;

        }

        private void MediaVideo_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (MediaVideo.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                MediaVideo.Ctlcontrols.play();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
