using Classes.FBBanco;
using System;
using System.Data;

namespace MGMPDV
{
    class CTransacao
    {
        public int tra_id { get; set; }
        public int cai_id { get; set; }
        public decimal tra_valor { get; set; }
        public DateTime tra_data { get; set; }
        public DateTime tra_hora { get; set; }
        public char tra_tipo { get; set; }
        public string tra_descricao { get; set; }


        public CTransacao()
        { }

        public void inserir(int idcaixa, decimal valor, char debitoOUcredito, string descricao, string informacao, int fun_id)
        {
            FBBanco fb = new FBBanco();
            if (fb.conecta())
            {
                fb.executeNonQuery(@"insert into transacao(cai_id,tra_valor,tra_tipo,tra_descricao,tra_informacao,fun_id
                                    ) values(
                                    @cai_id,@tra_valor,@tra_tipo,@tra_descricao,@tra_informacao,@fun_id
                                    )"
                                    , "@cai_id", idcaixa, "@tra_valor", valor,
                                    "@tra_tipo", debitoOUcredito, "@tra_descricao", descricao, "@tra_informacao", informacao, "@fun_id", fun_id 
                                    );
            }
        }

        public DataTable pegaTransacao(int idcaixa)
        {
            FBBanco fb = new FBBanco();
            DataTable dt = new DataTable();
            if (fb.conecta())
            {
                fb.executeQuery(@"select * from transacao where cai_id=@cai_id", out dt, "@cai_id", idcaixa);
                fb.desconecta();
            }

            return dt;
        }

        public decimal totalTransacaoIdCaixa(int idcaixa)
        {
            FBBanco fb = new FBBanco();
            DataTable dt = new DataTable();
            decimal total = 0;
            if (fb.conecta())
            {
                fb.executeQuery(@"select sum(tra_valor) as total 
                                    from transacao where cai_id=@cai_id", out dt, "@cai_id", idcaixa);
                fb.desconecta();
            }

            try
            {
                total = decimal.Parse(dt.Rows[0][0].ToString());
            }
            catch { }
            return total;
        }

        public decimal totalSuprimentoIdCaixa(int idcaixa)
        {
            FBBanco fb = new FBBanco();
            DataTable dt = new DataTable();
            decimal total = 0;
            if (fb.conecta())
            {
                fb.executeQuery(@"select sum(tra_valor) as total 
                                    from transacao where cai_id=@cai_id and tra_descricao='SUPRIMENTO'", out dt, "@cai_id", idcaixa);
                fb.desconecta();
            }

            try
            {
                total = decimal.Parse(dt.Rows[0][0].ToString());
            }
            catch { }
            return total;
        }
        public decimal totalSangriaIdCaixa(int idcaixa)
        {
            FBBanco fb = new FBBanco();
            DataTable dt = new DataTable();
            decimal total = 0;
            if (fb.conecta())
            {
                fb.executeQuery(@"select sum(tra_valor) as total 
                                    from transacao where cai_id=@cai_id and tra_descricao='SANGRIA'", out dt, "@cai_id", idcaixa);
                fb.desconecta();
            }

            try
            {
                total = decimal.Parse(dt.Rows[0][0].ToString());
            }
            catch { }
            return total;
        }
    }
}
