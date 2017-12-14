using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MGMPDV.Classes
{
    public class CTEF
    {
        string vbCrLf;
        string ValorTEF = "";
        string Rede = "";
        string NSU = "";
        bool bTemImpressao = false;
        string Finalizacao = "";
        string MsgOperador = "";
        public bool EnviaSolicitação(string valorTEF)
        {
            string NumSequencialTEF;
            string Mensagem;
            bool retorno = false;


            //'inicializa as variaveis usadas no TEF
            InicializaVariaveisTEF();

            try
            {
                if (File.Exists(@"C:\TEF_DIAL\RESP\intpos.001"))
                {
                    File.Delete(@"C:\TEF_DIAL\RESP\intpos.001");
                }
            }
            catch { };


            NumSequencialTEF = DateTime.Now.ToString("MMddHHmmss");

            //'        valorTEF = valorTEF.Replace(",", "")
            //'monta o arquivo de solicitação do TEF
            Mensagem = "000-000 = CRT" + vbCrLf +
                       "001-000 = " + NumSequencialTEF + vbCrLf +
                       "003-000 = " + valorTEF.Replace(",", "").Trim() + vbCrLf +
                       "999-999 = 0";

            //'gera o arquivo de solicitacao
            if (!GeraArquivoSolicitacao(Mensagem))
            {
                return false;
            }

            // 'verifica se a transacao foi ou não aprovada
            if (!TransacaoAprovada())
            {
                //'exibe mensagem ao operador
                if (MsgOperador != "")
                {
                    // FrmOperador As New FormOperador
                    //FrmOperador.lblNSU.Visible = False
                    //FrmOperador.lblRede.Visible = False
                    //FrmOperador.lblValor.Visible = False
                    //FrmOperador.lblMsgOperador.Text = Me.MsgOperador
                    //FrmOperador.bSaidaAutomatica = False
                    //FrmOperador.botaoOkVisivel = True
                    //FrmOperador.ShowDialog()

                    // 'apaga o arquivo intpos.001 de resposta
                    // ApagaArquivoResposta();
                    retorno = true;
                }
            }
            return retorno;
        }

        public void InicializaVariaveisTEF()
        {
            //'inicializa as variaveis
            ValorTEF = "";
            Rede = "";
            NSU = "";
            bTemImpressao = false;
            Finalizacao = "";
            MsgOperador = "";
        }

        private bool GeraArquivoSolicitacao(string Mensagem)
        {
            bool retorno = false;
            string PathREQ = @"C:\TEF_DIAL\REQ";//   'path do arquivo de solicitacao
            string PathRESP = @"C:\TEF_DIAL\RESP";// 'path do arquivo de resposta

            StreamWriter Arquivo = new StreamWriter("Nothing");//'arquivo de solicitacao

            try
            {
                //'apaga os arquivos se existirem
                if (File.Exists(PathREQ + @"\intpos.tmp")) File.Delete(PathREQ + @"\intpos.tmp");

                if (File.Exists(@"C:\TEF_DIAL\REQ\intpos.001")) File.Delete(@"C:\TEF_DIAL\REQ\intpos.001");

                //'cria o arquivo de solicitação temporariamente
                Arquivo = File.CreateText(PathREQ + @"\intpos.tmp");
                Arquivo.Write(Mensagem);
                Arquivo.Close();
                //Arquivo = Nothing;

                // 'renomeia o arquivo para intpos.001
                // Rename(PathREQ + "\intpos.tmp", PathREQ + "\intpos.001")
                File.Move(PathREQ + @"\intpos.tmp", PathREQ + @"\intpos.001");

                //     'aguarda até 7 segundos para receber a confirmação de recebimento 
                //  'da(solicitacao). Se não receber exibe a mensagem de gerenciador
                //  'padrão inativo
                int Contador = 0;
                while (true)
                {
                    if (!File.Exists(PathRESP + @"\intpos.sts") && Contador < 70)
                    {

                        //Espera(100);
                        Contador++;
                    }
                };

                if (Contador < 70)
                {
                    File.Delete(PathRESP + @"\intpos.sts");
                    return true;
                }
                else
                {
                    if (File.Exists(PathREQ + @"\intpos.001")) File.Delete(PathREQ + @"\intpos.001");

                    //mesage MessageBox.Show("O Gerenciador Padrão não está ativo!", "TEF_VBNET", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    return false;

                }
            }
            catch
            {
                // MessageBox.Show(ex.Message);
            }
            return retorno;
        }

        private bool TransacaoAprovada()
        {
            bool retorno = false;
            // 'lê o arquivo de resposta e verifica se a transação foi aprovada
            string PathRESP = @"C:\TEF_DIAL\RESP";
            //StreamReader ArqResposta = new StreamReader("nothing");
            string LinhaArquivo = "";

            //'aguarda receber o arquivo de resposta IntPos.001
            while (true)
            {
                if (File.Exists(PathRESP + @"\intpos.001"))
                {
                 //   return;
                }
            }
            StreamReader ArqResposta = new StreamReader(PathRESP + @"\intpos.001", System.Text.Encoding.UTF7);
            LinhaArquivo = ArqResposta.ReadLine();
            //While Not LinhaArquivo Is Nothing

            // 'campo 003 - VALOR
            if (LinhaArquivo.Substring(0, 3) == "003")
            {
                ValorTEF = LinhaArquivo.Substring(10);
            }

            //'campo 009 - verifica se a transação foi aprovada
            if (LinhaArquivo.Substring(0, 3) == "009")
            {
                if (LinhaArquivo.Substring(10, LinhaArquivo.Length - 10) == "0")
                {
                    retorno = true;
                }
                else
                {
                    retorno = false;
                }
            }

            //'campo 010 - REDE
            if (LinhaArquivo.Substring(0, 3) == "010") Rede = LinhaArquivo.Substring(10);

            //campo 012 - NSU
            if (LinhaArquivo.Substring(0, 3) == "012") NSU = LinhaArquivo.Substring(10);

            //'campo 027 - Finalizacao
            if (LinhaArquivo.Substring(0, 3) == "027") Finalizacao = LinhaArquivo.Substring(10);

            //  'campo 028 - qtde de linhas para serem impressas
            if (LinhaArquivo.Substring(0, 3) == "028")
            {
                if (Convert.ToInt32(LinhaArquivo.Substring(10, LinhaArquivo.Length - 10)) > 0) bTemImpressao = true;

            }
            //   'campo 030 - Mensagem ao operador
            if (LinhaArquivo.Substring(0, 3) == "030") MsgOperador = LinhaArquivo.Substring(10);
            LinhaArquivo = ArqResposta.ReadLine();
       // ArqResposta Close();// 'fecha o arquivo
     //   ArqResposta = "Nothing";
    }

    }
}
