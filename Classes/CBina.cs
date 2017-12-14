using Classes.FBBanco;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace MGMPDV
{
    class CBina
    {
        string linha = "";
        string arq = "";

        public CBina()
        {
           arq= Application.StartupPath + "\\BINA.txt";
        }

        public string Detectar()
        {
            if (File.Exists(arq))
            {
                
                StreamReader s = new StreamReader(arq);
                linha = "";
                linha = s.ReadLine();
                //MessageBox.Show(arq);
                s.Close();
                File.Delete(arq);

            }
            return linha;
        }

        public void inserir(string ddd, string numero)
        {
            FBBanco fb = new FBBanco();
            if (fb.conecta())
            {
                fb.executeNonQuery("insert into bina(bin_ddd,bin_numero) values(@ddd,@numero)", "@ddd", ddd, "@numero", numero);
                fb.desconecta();
            }
        }


        public DataTable carregar(string filtro)
        {
            DataTable dt = new DataTable();
            FBBanco fb = new FBBanco();
            if (fb.conecta())
            {
                fb.executeQuery(@"
                                  SELECT * FROM BINA B 
                                  LEFT JOIN CLIENTE C ON
                                    (c.cli_telefone1 = bin_numero and c.cli_ddd1=bin_ddd) or
                                    (c.cli_telefone2 = bin_numero and c.cli_ddd2=bin_ddd) or
                                    (c.cli_telefone3 = bin_numero and c.cli_ddd3=bin_ddd)
                                  WHERE
                                    bin_numero like @filtro or 
                                    UPPER(cli_nome) like UPPER(@filtro) or
                                    UPPER(cli_endereco) like UPPER(@filtro)
                                    order by bin_data desc, bin_hora desc;
                                "
                    , out dt, "@filtro",'%'+filtro+'%');
                fb.desconecta();
            }

            return dt;
        }
    }
}
