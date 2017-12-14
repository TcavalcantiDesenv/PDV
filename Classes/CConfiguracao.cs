using Classes.FBBanco;
using System;
using System.Data;

namespace MGMPDV
{
    class CConfiguracao
    {
        DataTable dt = new DataTable();
        FBBanco fb = new FBBanco();
        public int bina { get; set; }
        public string mensagem { get; set; }
        public int senha { get; set; }

        public int lite { get; set; }
        public int sleep { get; set; }
        public string regime { get; set; }

        public int mesvalidacao { get; set; }
        public string chavevalidacao { get; set; }

        public CConfiguracao()
        {
            bina = 0;
            mensagem = "";
            if (fb.conecta())
            {
                fb.executeQuery("select * from configuracao", out dt);
                fb.desconecta();

                if (dt.Rows.Count > 0)
                {
                    bina = int.Parse(dt.Rows[0]["con_bina"].ToString());
                    mensagem = dt.Rows[0]["con_mensagem"].ToString();
                    regime = dt.Rows[0]["con_regime"].ToString();
                    senha = int.Parse(dt.Rows[0]["con_senha"].ToString());
                    try
                    {
                        lite = int.Parse(dt.Rows[0]["con_lite"].ToString());
                    }
                    catch { }

                    try
                    {
                        sleep = int.Parse(dt.Rows[0]["con_sleep"].ToString());
                    }
                    catch { sleep = 1000; }

                    try
                    {
                        mesvalidacao = int.Parse(dt.Rows[0]["con_mesvalidacao"].ToString());
                    }
                    catch { }
                    chavevalidacao = dt.Rows[0]["con_chavevalidacao"].ToString();

                }

            }
        }

        public DataTable carregar()
        {
            DataTable dt = new DataTable();

            if (fb.conecta())
            {
                fb.executeQuery("select * from configuracao", out dt);
                fb.desconecta();
            }

            return dt;
        }

        public void inserir()
        {
            if (fb.conecta())
            {
                fb.executeNonQuery("insert into configuracao(con_senha) values(0)");
                fb.desconecta();
            }
        }

        public void salvar(string mensagem, int bina, int senha, int sleep, string regime)
        {
            if (fb.conecta())
            {
                fb.executeNonQuery("update configuracao set con_mensagem = @mensagem, con_bina = @bina, con_senha = @senha, con_sleep = @sleep, con_regime = @regime", "@mensagem", mensagem, "@bina", bina, "@senha", senha, "@sleep", sleep, "@regime", regime);
                fb.desconecta();
            }
        }

        public void atualizarvalidacao(string chave, int quantidade)
        {
            if (fb.conecta())
            {
                fb.executeNonQuery("update configuracao set con_chavevalidacao=@chave, con_mesvalidacao=@quantidade", "@chave", chave, "@mes", quantidade);
                fb.desconecta();
            }
        }

        public void atualizar(int quantidade, DateTime data)
        {
            if (fb.conecta())
            {
                fb.executeNonQuery("update configuracao set con_quantidade=@quantidade, con_data=@data", "@quantidade", quantidade, "@data", data.Date);
                fb.desconecta();
            }
        }

        public int retornaQuantidade()
        {
            int quantidade = 0;
            if (dt.Rows.Count > 0)
            {
                quantidade = int.Parse(dt.Rows[0]["con_quantidade"].ToString());
            }
            return quantidade;
        }

        public void retiraQuantidade()
        {
            if (fb.conecta())
            {
                fb.executeNonQuery("update configuracao set con_quantidade=con_quantidade-@quantidade", "@quantidade", 1);
                fb.desconecta();
            }
        }

        public void colocaAtivo()
        {
            if (fb.conecta())
            {
                DataTable dt = new DataTable();
                fb.executeQuery("select * from configuracao", out dt);
                if (dt.Rows.Count <= 0)
                {
                    fb.executeNonQuery("insert into configuracao(con_data,con_quantidade,con_ativo) values(@data,@quantidade,1)", "@data", DateTime.Now.AddMonths(1).AddDays(15).Date, "@quantidade", 150);
                }
                else
                    fb.executeNonQuery("update configuracao set con_ativo=1");
                fb.desconecta();
            }
        }

        public DateTime retornaData()
        {
            DateTime data = new DateTime();
            if (dt.Rows.Count > 0)
            {
                data = DateTime.Parse(dt.Rows[0]["con_data"].ToString());
            }
            return data;
        }

        public int retornaAtivo()
        {
            int ativo = 0;
            if (dt.Rows.Count > 0)
            {
                ativo = int.Parse(dt.Rows[0]["con_ativo"].ToString());
            }
            return ativo;
        }

        public int retornaSleep()
        {
            int sleep = 0;
            if (dt.Rows.Count > 0)
            {
                sleep = int.Parse(dt.Rows[0]["con_sleep"].ToString());
            }
            return sleep;
        }

    }
}
