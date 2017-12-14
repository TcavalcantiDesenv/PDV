using System;
using Classes.FBBanco;
using System.Data;

namespace MGMPDV
{
    class CCaixa
    {

        public int cai_id { get; set; }
        public int fun_id {get; set;}          
        public int fun_idfechamento {get; set;}
        public decimal cai_valorinicial {get; set;}
        public decimal cai_valorfinal {get; set;} 
        public DateTime cai_datainicial {get; set;}
        public DateTime cai_datafinal {get; set;}   
        public DateTime cai_horainicial {get; set;} 
        public DateTime cai_horafinal {get; set;}
        public int cai_status { get; set; }
        public string cai_informacao { get; set; }
        public int cai_numero { get; set; }
       
        public CCaixa()
        {

        }

        public decimal totalCaixa(int idcaixa)
        {
            decimal total = 0;
            //decimal valorfinal = 0;
            //CTransacao ct = new CTransacao();
            //total = ct.totalTransacaoIdCaixa(idcaixa);

            DataTable dt = pegacaixa(idcaixa);
            if (dt.Rows.Count>0)
	        {
                total += decimal.Parse(dt.Rows[0]["cai_valorinicial"].ToString());
	        }

            /*try
            {
                valorfinal = decimal.Parse(dt.Rows[0]["cai_valorfinal"].ToString());
            }
            catch { }
            total += valorfinal;*/

            //CContaPagar cp = new CContaPagar();
            //total -= cp.totalPacelaContaPagar(idcaixa);

            CContaReceber cr = new CContaReceber();
            total += cr.totalPacelaContaReceber(idcaixa);

            CTransacao ct = new CTransacao();
            total += ct.totalTransacaoIdCaixa(idcaixa);

            return total;
        }

        public int abrir(int cai_numero,int fun_id, decimal cai_valorinicial,  DateTime cai_datainicial, DateTime cai_horainicial)
        {
            
            FBBanco fb = new FBBanco();
            int numero = 0;
            if (fb.conecta())
            {
                numero = fb.executeScalar(@"insert into Caixa(
                    cai_numero,fun_id,cai_valorinicial,cai_datainicial,cai_horainicial
                    ) values (
                    @cai_numero,@fun_id,@cai_valorinicial,@cai_datainicial,@cai_horainicial
                    ) returning cai_id",
                    "@cai_numero", cai_numero,"@fun_id", fun_id, "@cai_valorinicial", cai_valorinicial, "@cai_datainicial",  cai_datainicial, "@cai_horainicial", cai_horainicial
                    );
                fb.desconecta();
        
            }

            return numero;

        }

        public void fechar(int fun_idfechamento, decimal cai_valorfinal, DateTime cai_datafinal, DateTime cai_horafinal, int cai_status, string cai_informacao)
        {
            FBBanco fb = new FBBanco();
            if (fb.conecta())
            {

                fb.executeNonQuery(@"update caixa set
                                fun_idfechamento=@fun_idfechamento,cai_valorfinal=@cai_valorfinal,cai_datafinal=@cai_datafinal,cai_horafinal=@cai_horafinal,cai_status=@cai_status,cai_informacao=@cai_informacao
                                where cai_status = '1'",
                                "@fun_idfechamento", fun_idfechamento, "@cai_valorfinal", cai_valorfinal,
                                "@cai_datafinal", cai_datafinal, "@cai_horafinal", cai_horafinal,
                                "@cai_status", cai_status,"@cai_informacao",cai_informacao
                                );
                fb.desconecta();
            }        
        }

        public void fechar(int idcaixa, int fun_idfechamento, decimal cai_valorfinal, DateTime cai_datafinal, DateTime cai_horafinal, int cai_status, string cai_informacao)
        {
            FBBanco fb = new FBBanco();
            if (fb.conecta())
            {

                fb.executeNonQuery(@"update caixa set
                                fun_idfechamento=@fun_idfechamento,cai_valorfinal=@cai_valorfinal,cai_datafinal=@cai_datafinal,cai_horafinal=@cai_horafinal,cai_status=@cai_status,cai_informacao=@cai_informacao
                                where cai_id = @cai_id",
                                "@fun_idfechamento", fun_idfechamento, "@cai_valorfinal", cai_valorfinal,
                                "@cai_datafinal", cai_datafinal, "@cai_horafinal", cai_horafinal,
                                "@cai_status", cai_status, "@cai_informacao", cai_informacao, "@cai_id", cai_id
                                );
                fb.desconecta();
            }
        }

        public DataTable pegaaberto()
        {
            DataTable dt = new DataTable();
            FBBanco fb = new FBBanco();
            if (fb.conecta())
            {
                fb.executeQuery(@"select c.*,f.fun_nome as fun_abertura,f2.fun_nome as fun_fechamento from caixa c 
                left join funcionario f on f.fun_id=c.fun_id 
                left join funcionario f2 on f2.fun_id=c.fun_idfechamento where cai_status = 1",
                                 out dt);
                fb.desconecta();
            }

            return dt;
        }

        public int pegaIdAberto()
        {
            DataTable dt = new DataTable();
            FBBanco fb = new FBBanco();
            if (fb.conecta())
            {
                fb.executeQuery(@"select * from caixa where cai_status = 1",
                                 out dt);
                fb.desconecta();
            }

            if (dt.Rows.Count > 0)
            {
                return int.Parse(dt.Rows[0]["cai_id"].ToString());
            }
            else
                return 0;
        }

        public DataTable pegacaixa(int idcaixa)
        {
            DataTable dt = new DataTable();
            FBBanco fb = new FBBanco();
            if (fb.conecta())
            {
                fb.executeQuery(@"select c.*,f.fun_nome as fun_abertura,f2.fun_nome as fun_fechamento from caixa c 
                left join funcionario f on f.fun_id=c.fun_id 
                left join funcionario f2 on f2.fun_id=c.fun_idfechamento where cai_id=@idcaixa",
                                 out dt,"@idcaixa", idcaixa);
                fb.desconecta();
            }

            return dt;
        }

        public DataTable pegacaixa(int idcaixa, int cai_numero)
        {
            DataTable dt = new DataTable();
            FBBanco fb = new FBBanco();
            if (fb.conecta())
            {
                fb.executeQuery(@"select c.*,f.fun_nome as fun_abertura,f2.fun_nome as fun_fechamento from caixa c 
                left join funcionario f on f.fun_id=c.fun_id 
                left join funcionario f2 on f2.fun_id=c.fun_idfechamento where cai_id=@idcaixa and cai_numero = @cai_numero",
                                 out dt, "@idcaixa", idcaixa, "@cai_numero", cai_numero);
                fb.desconecta();
            }

            return dt;
        }




        public DataTable pegaultimo(int numero)
        {
            DataTable dt = new DataTable();
            FBBanco fb = new FBBanco();
            if (fb.conecta())
            {
                fb.executeQuery("select first 1 * from caixa where cai_numero = @numero order by cai_id desc",
                                 out dt, "@numero", numero);
                fb.desconecta();
            }

           
            return dt;
        }

        public DataTable pegaDataIeDataF(DateTime datai, DateTime dataf)
        {
            DataTable dt = new DataTable();
            FBBanco fb = new FBBanco();
            if (fb.conecta())
            {
                fb.executeQuery(@"select c.*,f.fun_nome as fun_abertura,f2.fun_nome as fun_fechamento from caixa c 
                left join funcionario f on f.fun_id=c.fun_id 
                left join funcionario f2 on f2.fun_id=c.fun_idfechamento where cai_datainicial between @datai and @dataf order by cai_id desc",
                                 out dt, "@datai", datai, "@dataf", dataf);
                fb.desconecta();
            }

            return dt;
        }

        public bool isAberto()
        {
            DataTable dt = new DataTable();
            FBBanco fb = new FBBanco();
            if (fb.conecta())
            {
                fb.executeQuery("select * from caixa where cai_status = 1",
                                 out dt);
                fb.desconecta();
            }

            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }

        public DataTable relatorioCaixa(int idcaixa)
        {
            DataTable dt = new DataTable();
            FBBanco fb = new FBBanco();
            if (fb.conecta())
            {
                fb.executeQuery(@"select f1.fun_nome as fun_nome1, f2.fun_nome as fun_nome2, c.*, p.*,cli_nome  from caixa c
                                    left join funcionario f1 on f1.fun_id = c.fun_id
                                    left join funcionario f2 on f2.fun_id = c.fun_idfechamento
                                    left join venda v on v.cai_id = c.cai_id
                                    left join parcelacontareceber p on p.ven_id = v.ven_id
                                    left join cliente cli on cli.cli_id= p.cli_id
                                   where c.cai_id=@id
                                    ",
                                 out dt, "@id", idcaixa);
                fb.desconecta();
            }


            return dt;
        }

        public DataTable carregarcaixa(DateTime datai, DateTime dataf)
        {
            FBBanco fb = new FBBanco();
            DataTable dt = new DataTable();
            if (fb.conecta())
            {

                string sql = @"select * from caixa
                where cai_datainicial between @datai and @dataf order by cai_id";
                fb.executeQuery(sql, out dt, "@datai", datai, "@dataf", dataf);
                fb.desconecta();
            }
            return dt;
         }
    }
}
