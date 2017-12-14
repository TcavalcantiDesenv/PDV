using System;
using System.IO;
using System.Windows.Forms;
using Classes.FBBanco;
using System.Data;

namespace MGMPDV
{
    class CSat
    {

        string caminhoMonitorEntrada = @"C:\ACBrMonitorPLUS\ENT.txt";
        string caminhoMonitorSaida = @"C:\ACBrMonitorPLUS\SAI.txt";
        public string hora { get; set; }
        public string data { get; set; }
        public CSat() { }


        public int lerSleep()
        {
            int valor = 0;
            try
            {
                valor = int.Parse(Application.StartupPath + @"\Sleep.txt");
            }
            catch { MessageBox.Show("Erro com arquivo Sleep"); valor = 0; }
            return valor;
        }
        public string Inicializar()
        {
            string text = "SAT.Inicializar";
            // WriteAllText creates a file, writes the specified string to the file, 
            // and then closes the file.
            File.WriteAllText(caminhoMonitorEntrada, text);
            System.Threading.Thread.Sleep(lerSleep());
            string[] str = File.ReadAllLines(caminhoMonitorSaida);

            return str[str.Length-1];
        }

        public string enviarCFe()
        {
            //tring text = @""
            return "";
        }

        public void inserir(int ven_id, int sat_sessao, string sat_xml)
        {
            FBBanco fb = new FBBanco();

            if (fb.conecta())
            {
                fb.executeNonQuery(@"insert into SAT(
                    ven_id,sat_sessao,sat_xml
                    ) values (
                    @ven_id,@sat_sessao,@sat_xml                   
                    )",
                "@ven_id", ven_id, "@sat_sessao", sat_sessao, "@sat_xml", sat_xml);
                fb.desconecta();

            }
        }

        public string carregarXMLIDVenda(int ven_id)
        {
            string xml = "";
            FBBanco fb = new FBBanco();
            DataTable dt = new DataTable();
            if (fb.conecta())
            {
                fb.executeQuery(@"select * from sat where ven_id = @idvenda", out dt, "@idvenda", ven_id);
                fb.desconecta();
            }

            if(dt.Rows.Count>0)
            {
                xml = dt.Rows[0]["sat_xml"].ToString();
                
                hora = dt.Rows[0]["sat_hora"].ToString();
                data = dt.Rows[0]["sat_data"].ToString();
            }

            return xml;
        }

        private string parametroSat(string chave)
        {

            string retorno = "";
            string[] lines = File.ReadAllLines(Application.StartupPath + @"\SAT.ini");
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].Contains(chave + "="))
                {
                    retorno = lines[i].Substring(chave.Length + 1);
                }
            }
            return retorno;
        }

        public bool cancelarIDVenda(int ven_id)
        {
            CConfiguracao configuracao = new CConfiguracao();
            bool ok = true;

            string xml = carregarXMLIDVenda(ven_id);

            if (xml.Length > 0)
            {
                if (hora.Trim().Length > 0)
                {
                    try
                    {
                        DateTime horavenda = DateTime.Parse(hora);
                        DateTime datavenda = DateTime.Parse(data);
                        horavenda = horavenda.AddMinutes(31);

                        if (DateTime.Now.Date == datavenda.Date)
                        {
                            if (horavenda.TimeOfDay > DateTime.Now.TimeOfDay)
                            {
                                string xmlpuro = xml;
                                xml = "SAT.CancelarCFe(\"" + xmlpuro + "\");";

                                System.IO.File.WriteAllText(parametroSat("caminhocupomtxt"), xml);
                                int sleep = 3000;
                                int.TryParse(parametroSat("sleep"), out sleep);
                                System.Threading.Thread.Sleep(sleep);

                                string retorno = retornoSAT("codigoDeRetorno");
                                if (retorno.Contains("7000"))
                                {
                                    excluirsat(ven_id);
                                    xml = "SAT.ImprimirExtratoCancelamento(\"" + xmlpuro + "\");";
                                    System.IO.File.WriteAllText(@"C:\ACBrMonitorPLUS\ENT.txt", xml);
                                    return ok;
                                }
                                else
                                    ok = false;
                            }
                            else ok = false;
                        }
                        else
                            ok = false;


                        
                    }
                    catch { ok = false; }
                }

            }
            ok = false;
            return ok;
        }

        public void excluirsat(int idvenda)
        {
            FBBanco fb = new FBBanco();
            DataTable dt = new DataTable();
            if (fb.conecta())
            {
                fb.executeNonQuery(@"update sat set sat_status = 0 where ven_id = @idvenda", "@idvenda", idvenda);
                fb.desconecta();
            }
            
        }


        private string retornoSAT(string chave)
        {
            string retorno = "";
            try
            {
                string[] lines = File.ReadAllLines(caminhoMonitorSaida);
                for (int i = 0; i < lines.Length; i++)
                {
                    if (lines[i].Contains(chave + "="))
                    {
                        retorno = lines[i].Substring(chave.Length + 1);
                    }
                }
            }
            catch { retorno = "Erro Monitor"; }

            return retorno;
        }

        public void imprimirIDVenda(int ven_id)
        {
            string xml = carregarXMLIDVenda(ven_id);

            if (xml.Length>0)
            {
                
                xml = "SAT.ImprimirExtratoVenda(\"" + xml + "\");";

                System.IO.File.WriteAllText(@"C:\ACBrMonitorPLUS\ENT.txt", xml);
            }
        }
        
        public DataTable carregarData(DateTime data, int numerocaixa)
        {
            FBBanco fb = new FBBanco();
            DataTable dt = new DataTable();
            if(fb.conecta())
            {
                fb.executeQuery(@"select * from sat s
                                 left join venda v on v.ven_id = s.ven_id
                                 left join cliente c on c.cli_id = v.cli_id
                                 left join caixa cai on cai.cai_id = v.cai_id
    
                                 where v.ven_data = @data and cai.cai_numero=@numerocaixa", out dt, "@data", data, "@numerocaixa", numerocaixa);
                fb.desconecta();
            }
            return dt;
        }
    }
}
