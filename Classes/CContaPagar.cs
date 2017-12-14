using Classes.FBBanco;
using System;
using System.Data;

namespace MGMPDV
{
    class CContaPagar
    {

        public CContaPagar()
        { }

        public void removerParcela(int idParcela)
        {
            FBBanco fb = new FBBanco();
            if (fb.conecta())
            {
                fb.executeNonQuery("delete from parcelacontapagar where par_id=@id", "@id", idParcela);
                fb.desconecta();
            }
        }

        public void removerParcelaDinheiro(int idcompra)
        {
            FBBanco fb = new FBBanco();
            if (fb.conecta())
            {
                fb.executeNonQuery(@"delete from parcelacontapagar
                where com_id=@id and par_descricao = 'Dinheiro'"
                , "@id", idcompra);
                fb.desconecta();
            }
        }

        public void removerParcelaDebito(int idcompra)
        {
            FBBanco fb = new FBBanco();
            if (fb.conecta())
            {
                fb.executeNonQuery(@"delete from parcelacontapagar
                where com_id=@id and par_descricao = 'Cartão - Débito'"
                , "@id", idcompra);
                fb.desconecta();
            }
        }

        public decimal carregarQtdeParcelasDinheiro(int idcompra)
        {
            FBBanco fb = new FBBanco();
            DataTable dt = new DataTable();
            if (fb.conecta())
            {

                string sql = @"select 
                count(par_id) as qtde
                from parcelacontapagar p  where com_id = @idcompra and par_descricao='Dinheiro' order by par_pai,par_numero,par_id";
                fb.executeQuery(sql, out dt, "@idcompra", idcompra);
                fb.desconecta();
            }

            decimal qtde = 0;
            try { qtde = decimal.Parse(dt.Rows[0]["qtde"].ToString()); }
            catch { }
            return qtde;
        }

        public decimal carregarQtdeParcelasDebito(int idcompra)
        {
            FBBanco fb = new FBBanco();
            DataTable dt = new DataTable();
            if (fb.conecta())
            {

                string sql = @"select 
                count(par_id) as qtde
                from parcelacontapagar p  where com_id = @idcompra and par_descricao='Cartão - Débito' order by par_pai,par_numero,par_id";
                fb.executeQuery(sql, out dt, "@idcompra", idcompra);
                fb.desconecta();
            }

            decimal qtde = 0;
            try { qtde = decimal.Parse(dt.Rows[0]["qtde"].ToString()); }
            catch { }
            return qtde;
        }

        public decimal carregarQtdeParcelasCheque(int idcompra)
        {
            FBBanco fb = new FBBanco();
            DataTable dt = new DataTable();
            if (fb.conecta())
            {

                string sql = @"select 
                count(par_id) as qtde
                from parcelacontapagar p  where com_id = @idcompra and par_descricao='Cheque' order by par_pai,par_numero,par_id";
                fb.executeQuery(sql, out dt, "@idcompra", idcompra);
                fb.desconecta();
            }

            decimal qtde = 0;
            try { qtde = decimal.Parse(dt.Rows[0]["qtde"].ToString()); }
            catch { }
            return qtde;
        }

        public decimal carregarParcelaCreditoValor(int idparcela)
        {
            FBBanco fb = new FBBanco();
            DataTable dt = new DataTable();
            if (fb.conecta())
            {

                string sql = @"select 
                *
                from parcelacontapagar p  where par_id = @idparcela and par_descricao='Cartão - Crédito'  order by par_pai,par_numero,par_id";
                fb.executeQuery(sql, out dt, "@idparcela", idparcela);
                fb.desconecta();
            }

            decimal valor = 0;
            try { valor = decimal.Parse(dt.Rows[0]["par_valor"].ToString()); }
            catch { }
            return valor;
        }

        public decimal carregarParcelaBoletoValor(int idparcela)
        {
            FBBanco fb = new FBBanco();
            DataTable dt = new DataTable();
            if (fb.conecta())
            {

                string sql = @"select 
                *
                from parcelacontapagar p  where par_id = @idparcela and par_descricao='Boleto' order by par_pai,par_numero,par_id";
                fb.executeQuery(sql, out dt, "@idparcela", idparcela);
                fb.desconecta();
            }

            decimal valor = 0;
            try { valor = decimal.Parse(dt.Rows[0]["par_valor"].ToString()); }
            catch { }
            return valor;
        }

        public DataTable carregarParcelasIDParcela(int idparcela)
        {
            FBBanco fb = new FBBanco();
            DataTable dt = new DataTable();
            if (fb.conecta())
            {

                string sql = @"select 
                *
                from parcelacontapagar p
                left join compra c on c.com_id = p.com_id
                left join fornecedor f on f.for_id=c.for_id where par_id = @idparcela order by par_pai,par_numero,par_id";
                fb.executeQuery(sql, out dt, "@idparcela", idparcela);
                fb.desconecta();
            }
            return dt;
        }

        public DataTable carregarParcelasIDFornecedor(int idfornecedor, DateTime datai, DateTime dataf)
        {
            FBBanco fb = new FBBanco();
            DataTable dt = new DataTable();
            if (fb.conecta())
            {

                string sql = @"select 
                *
                from parcelacontapagar p
                left join compra c on c.com_id = p.com_id
                left join fornecedor f on f.for_id=c.for_id where c.for_id = @idfornecedor 
                and par_dtvencimento between @datai and @dataf 
                order by par_pai,par_numero,par_id";
                fb.executeQuery(sql, out dt, "@idfornecedor", idfornecedor, "@datai", datai, "@dataf", dataf);
                fb.desconecta();
            }
            return dt;
        }

        public DataTable carregarParcelasCartao(int idcompra)
        {
            FBBanco fb = new FBBanco();
            DataTable dt = new DataTable();
            if (fb.conecta())
            {

                string sql = @"select 
                *
                from parcelacontapagar where com_id = @idcompra and par_descricao='Cartão - Crédito' order by par_pai,par_numero,par_id";
                fb.executeQuery(sql, out dt, "@idcompra", idcompra);
                fb.desconecta();
            }
            return dt;
        }

        public DataTable carregarParcelasBoleto(int idcompra)
        {
            FBBanco fb = new FBBanco();
            DataTable dt = new DataTable();
            if (fb.conecta())
            {

                string sql = @"select 
                *
                from parcelacontapagar p 
                where com_id = @idcompra and par_descricao='Boleto' order by par_pai,par_numero,par_id";
                fb.executeQuery(sql, out dt, "@idcompra", idcompra);
                fb.desconecta();
            }
            return dt;
        }

        public DataTable carregarParcelas(int idcompra)
        {
            FBBanco fb = new FBBanco();
            DataTable dt = new DataTable();
            if (fb.conecta())
            {

                string sql = @"select 
                *
                from parcelacontapagar where com_id = @idconpra order by par_pai,par_numero,par_id";
                fb.executeQuery(sql, out dt, "@idcompra", idcompra);
                fb.desconecta();
            }
            return dt;
        }

        public DataTable carregarParcelas()
        {
            FBBanco fb = new FBBanco();
            DataTable dt = new DataTable();
            if (fb.conecta())
            {

                string sql = @"select 
                *
                from parcelacontapagar p
                inner join compra c on c.com_id=p.com_id  
                left join fornecedor f on f.for_id=c.for_id order by par_status desc,par_dtvencimento asc";
                fb.executeQuery(sql, out dt);
                fb.desconecta();
            }
            return dt;
        }

        public DataTable carregarParcelasPagas(DateTime datai, DateTime dataf)
        {
            FBBanco fb = new FBBanco();
            DataTable dt = new DataTable();
            if (fb.conecta())
            {

                string sql = @"select 
                *
                from parcelacontapagar where par_status=0 and par_dtpagamento between @datai and @dataf order by par_pai,par_numero,par_id";
                fb.executeQuery(sql, out dt, "@datai", datai,"@dataf", dataf);
                fb.desconecta();
            }
            return dt;
        }

        public decimal carregarParcelasPagasDinheiro(int idcompra)
        {
            FBBanco fb = new FBBanco();
            DataTable dt = new DataTable();
            if (fb.conecta())
            {

                string sql = @"select sum(par_valor) as par_valor 
                from parcelacontapagar where com_id = @idcompra and par_descricao = 'Dinheiro'";
                fb.executeQuery(sql, out dt, "@idcompra", idcompra);
                fb.desconecta();
            }


            try
            {
                return decimal.Parse(dt.Rows[0]["par_valor"].ToString());
            }
            catch { return 0; }

        }

        public decimal carregarParcelasPagasCheque(int idcompra)
        {
            FBBanco fb = new FBBanco();
            DataTable dt = new DataTable();
            if (fb.conecta())
            {

                string sql = @"select sum(par_valor) as par_valor 
                from parcelacontapagar where com_id = @idcompra and par_descricao = 'Cheque'";
                fb.executeQuery(sql, out dt, "@idcompra", idcompra);
                fb.desconecta();
            }


            try
            {
                return decimal.Parse(dt.Rows[0]["par_valor"].ToString());
            }
            catch { return 0; }

        }

        public decimal carregarParcelasPagasCredito(int idcompra)
        {
            FBBanco fb = new FBBanco();
            DataTable dt = new DataTable();
            if (fb.conecta())
            {

                string sql = @"select sum(par_valor) as par_valor 
                from parcelacontapagar where com_id = @idcompra and par_descricao = 'Cartão - Crédito'";
                fb.executeQuery(sql, out dt, "@idcompra", idcompra);
                fb.desconecta();
            }


            try
            {
                return decimal.Parse(dt.Rows[0]["par_valor"].ToString());
            }
            catch { return 0; }

        }

        public decimal carregarParcelasPagasDebito(int idcompra)
        {
            FBBanco fb = new FBBanco();
            DataTable dt = new DataTable();
            if (fb.conecta())
            {

                string sql = @"select sum(par_valor) as par_valor 
                from parcelacontapagar where com_id = @idcomrpa and par_descricao = 'Cartão - Débito'";
                fb.executeQuery(sql, out dt, "@idcompra", idcompra);
                fb.desconecta();
            }


            try
            {
                return decimal.Parse(dt.Rows[0]["par_valor"].ToString());
            }
            catch { return 0; }

        }

        public decimal carregarParcelasPagasBoleto(int idcompra)
        {
            FBBanco fb = new FBBanco();
            DataTable dt = new DataTable();
            if (fb.conecta())
            {

                string sql = @"select sum(par_valor) as par_valor 
                from parcelacontapagar where com_id = @idcompra and par_descricao = 'Boleto'";
                fb.executeQuery(sql, out dt, "@idcompra", idcompra);
                fb.desconecta();
            }


            try
            {
                return decimal.Parse(dt.Rows[0]["par_valor"].ToString());
            }
            catch { return 0; }

        }

        public DataTable carregarParcelasPagasporValor(decimal valor)
        {
            FBBanco fb = new FBBanco();
            DataTable dt = new DataTable();
            if (fb.conecta())
            {

                string sql = @"select 
                *
                from parcelacontapagar where par_status=0 and par_valorpago=@valor order by par_pai,par_numero,par_id";
                fb.executeQuery(sql, out dt, "@valor", valor);
                fb.desconecta();
            }
            return dt;
        }

        public DataTable carregarParcelasData(DateTime datai, DateTime dataf)
        {
            FBBanco fb = new FBBanco();
            DataTable dt = new DataTable();
            if (fb.conecta())
            {

                string sql = @"select 
                *
                from parcelacontapagar p
                inner join compra c on c.com_id=p.com_id  
                left join fornecedor f on f.for_id=c.for_id where par_dtvencimento between @datai and @dataf order by par_status desc, par_dtvencimento";
                fb.executeQuery(sql, out dt, "@datai", datai, "@dataf", dataf);
                fb.desconecta();
            }
            return dt;
        }

        public DataTable carregarParcelasFornecedor(string fornecedornome)
        {
            FBBanco fb = new FBBanco();
            DataTable dt = new DataTable();
            if (fb.conecta())
            {

                string sql = @"select 
                *
                from parcelacontapagar p
                inner join compra c on c.com_id=p.com_id  
                left join fornecedor f on f.for_id=c.for_id where UPPER(for_nome) like UPPER(@fornecedornome) order by par_status desc,for_nome,par_dtvencimento";
                fb.executeQuery(sql, out dt, "@fornecedornome", "%" + fornecedornome + "%");
                fb.desconecta();
            }
            return dt;
        }

        public DataTable carregarParcelasCaixa(int idcaixa)
        {
            FBBanco fb = new FBBanco();
            DataTable dt = new DataTable();
            if (fb.conecta())
            {

                string sql = @"select 
                *
                from parcelacontapagar p
                inner join compra c on c.com_id=p.com_id  
                left join fornecedor f on f.for_id=c.for_id  where cai_id=@idcaixa order by for_nome,par_descricao,par_pai,par_numero,par_id";
                fb.executeQuery(sql, out dt, "@idcaixa", idcaixa);
                fb.desconecta();
            }
            return dt;
        }

        public void pagar(int idcompra, int idcaixa,int idparcela, 
        int par_controle, int par_numero, int par_pai, decimal valor, 
        decimal valorpago, DateTime dtvencimento, DateTime dtpagamento, string descricao)
        {
            FBBanco fb = new FBBanco();
            if (fb.conecta())
            {
                try
                {
                    fb.beginTransaction();
                    string sql = "";

                    if (par_controle > 1)
                    {
                        sql = @"update parcelacontapagar set    
                                par_estornar = 0
                                where par_numero   = @par_numero and 
                                      par_controle = @par_controle and 
                                      par_pai      = @par_pai";
                        fb.executeNonQuery(sql, "@par_numero", par_numero, "@par_controle", par_controle-1, "@par_pai", par_pai);
                    }

                    sql = @"update parcelacontapagar set 
                            par_status      = 0,
                            par_valorpago   = @par_valorpago,
                            par_estornar    = 1,
                            par_dtpagamento = @par_dtpagamento 
                            where par_id = @par_id";
                    fb.executeNonQuery(sql,  "@par_id", idparcela,
                                            "@par_valorpago", valorpago, "@par_dtpagamento", dtpagamento
                                       );

                    if (valor > valorpago)
                    {
                        DateTime data = dtvencimento.AddMonths(1);
                        sql = @"insert into parcelacontapagar(
                                par_pai,par_controle,par_numero,com_id,par_valor,
                                par_dtvencimento,par_status,
                                par_valorpago, par_descricao
                                ) values(
                                @par_pai,@par_controle,@par_numero,@com_id,@par_valor,
                                @par_dtvencimento,@par_status,
                                @par_valorpago, @par_descricao
                                )";

                        if ( par_pai <= 0)
                            par_pai = idparcela;
                        
                        par_controle++;
                        fb.executeNonQuery(sql,
                            "@com_id", idcompra, "@par_pai", par_pai,"@par_controle", par_controle, 
                            "@par_numero", par_numero, "@par_valor", valor-valorpago,
                            "@par_dtvencimento", data, "@par_status", 1, "@par_valorpago", 0, "@par_descricao", descricao);
                    }

                    fb.commitTransaction();

                }
                catch
                {
                    fb.rollbackTransaction();
                }

                fb.desconecta();
            }
        }

        public void estornar(int idparcela, int par_controle, int par_numero, int par_pai)
        {
            FBBanco fb = new FBBanco();
            if (fb.conecta())
            {
                try
                {
                    fb.beginTransaction();
                    string sql = "";

                    if (par_controle > 1)
                    {
                        sql = @"update parcelacontapagar set 
                                par_estornar    = 1 
                                where par_numero    = @par_numero and 
                                      par_controle  = @par_controle and 
                                      par_pai       = @par_pai";
                        fb.executeNonQuery(sql, "@par_numero", par_numero, "@par_controle", par_controle-1, "@par_pai", par_pai);

                    }

                    sql = @"update parcelacontapagar set 
                            par_status      = 1,
                            par_valorpago   = 0,
                            par_estornar    = 0,
                            par_dtpagamento = null 
                            where par_id=@par_id";

                    fb.executeNonQuery(sql, "@par_id", idparcela);

                    sql = @"delete from parcelacontapagar 
                            where par_numero    = @par_numero and 
                                  par_controle  = @par_controle and 
                                  par_pai       = @par_pai";
                    fb.executeNonQuery(sql,
                                       "@par_pai", par_pai, "@par_numero", par_numero,
                                       "@par_controle", par_controle+1);

                    fb.commitTransaction();
                }
                catch 
                {
                    fb.rollbackTransaction();
                }

                fb.desconecta();
            }

        }

        public void alterarValor(int idparcela, decimal valor)
        {
            FBBanco fb = new FBBanco();
            if (fb.conecta())
            {
                fb.executeNonQuery(@"update parcelacontapagar set 
                par_valor=@valor
                where par_id = @idparcela"
                , "@idparcela", idparcela, "@valor", valor);
                fb.desconecta();
            }
        }

        public void alterarValorDinheiro(int idcompra, decimal valor)
        {
            FBBanco fb = new FBBanco();
            if (fb.conecta())
            {
                fb.executeNonQuery(@"update parcelacontapagar set 
                par_valor=@valor
                where com_id=@id and par_descricao = 'Dinheiro'"
                , "@id", idcompra, "@valor", valor);
                fb.desconecta();
            }
        }

        public void alterarValorDebito(int idcompra, decimal valor)
        {
            FBBanco fb = new FBBanco();
            if (fb.conecta())
            {
                fb.executeNonQuery(@"update parcelacontapagar set 
                par_valor=@valor
                where com_id=@id and par_descricao = 'Cartão - Débito'"
                , "@id", idcompra, "@valor", valor);
                fb.desconecta();
            }
        }

        public void alterarValorCheque(int idcompra, decimal valor)
        {
            FBBanco fb = new FBBanco();
            if (fb.conecta())
            {
                fb.executeNonQuery(@"update parcelacontapagar set 
                par_valor=@valor
                where com_id=@id and par_descricao = 'Cheque'"
                , "@id", idcompra, "@valor", valor);
                fb.desconecta();
            }
        }

        public void alterarData(int idparcela, DateTime data)
        {
            FBBanco fb = new FBBanco();
            if (fb.conecta())
            {
                fb.executeNonQuery(@"update parcelacontapagar set 
                par_dtvencimento=@data  
                where par_id = @idparcela"
                , "@idparcela", idparcela, "@data", data.Date);
                fb.desconecta();
            }
        }

        public decimal totalPacelaContaPagar(int idcaixa)
        {
            decimal total=0;
            FBBanco fb = new FBBanco();
            if (fb.conecta())
            {
                DataTable dt = new DataTable();
                fb.executeQuery("select sum(par_valor) as total from parcelacontapagar where cai_id=@cai_id", out dt, "@cai_id", idcaixa);
                try
                {
                    total = decimal.Parse(dt.Rows[0]["total"].ToString());
                }
                catch { }
                fb.desconecta();
            }

            return total;
        }

        public decimal totalPacelaContaPagarCompra(int idcompra)
        {
            decimal total = 0;
            FBBanco fb = new FBBanco();
            if (fb.conecta())
            {
                DataTable dt = new DataTable();
                fb.executeQuery("select sum(par_valor) as total from parcelacontapagar where com_id=@com_id", out dt, "@com_id", idcompra);
                try
                {
                    total = decimal.Parse(dt.Rows[0]["total"].ToString());
                }
                catch { }
                fb.desconecta();
            }

            return total;
        }


        public void cancelarConta(int idcompra)
        {
            FBBanco fb = new FBBanco();
            if (fb.conecta())
            {
                fb.executeNonQuery("delete from parcelacontapagar where com_id = @com_id", "@com_id", idcompra);
                fb.desconecta();
            }
        }

        /*
        public int insereContaPagar(int idcompra, int quantidadeparcela, decimal total, DateTime dataprimeirovenc, bool avista, int idcaixa, string descricao)
        {
            FBBanco fb = new FBBanco();

            decimal totalaux = total, resto = 0;
            int parcelaaux = 0;
            int idparcela = 0;
           
            if (fb.conecta())
            {
                for (int i = 1; i <= quantidadeparcela; i++)
                {
                    if (quantidadeparcela > 1)
                    {
                        if (i == quantidadeparcela)
                        {
                            parcelaaux = quantidadeparcela - 1;
                            resto = totalaux * parcelaaux;
                            totalaux = total - resto;
                        }
                        else
                            totalaux = Decimal.Round(total / quantidadeparcela, 2);
                    }

                    if (avista)
                        idparcela = fb.executeScalar(@"insert into parcelacontapagar(
                        com_id,par_numero,par_valor,par_dtvencimento,
                        par_dtpagamento,par_status,par_valorpago,cai_id,par_descricao
                        ) values (
                        @com_id,@par_numero,@par_valor,@par_dtvencimento,
                        @par_dtpagamento,@par_status,@par_valorpago,@cai_id,@par_descricao
                        ) returning par_id"
                        , "@com_id", idcompra, "@par_numero", i,
                        "@par_valor", totalaux, "@par_dtvencimento", dataprimeirovenc,
                        "@par_dtpagamento", DateTime.Now.Date, "@par_status", 0,
                        "@par_valorpago", totalaux, "@cai_id", idcaixa, "@par_descricao", descricao
                          );
                    else
                        if (dataprimeirovenc == DateTime.Now.Date)
                        {
                            idparcela = fb.executeScalar(@"insert into parcelacontapagar(
                                com_id,par_numero,par_valor,par_dtvencimento,
                                par_dtpagamento,par_status,par_valorpago,cai_id,par_descricao
                                ) values (
                                @com_id,@par_numero,@par_valor,@par_dtvencimento,
                                @par_dtpagamento,@par_status,@par_valorpago,@cai_id,@par_descricao
                                ) returning par_id"
                                , "@com_id", idcompra, "@par_numero", i,
                                "@par_valor", totalaux, "@par_dtvencimento", dataprimeirovenc,
                                "@par_dtpagamento", dataprimeirovenc, "@par_status", 0,
                                "@par_valorpago", totalaux, "@cai_id", idcaixa, "@par_descricao", descricao
                              );

                        }
                        else
                        {
                            idparcela = fb.executeScalar(@"insert into parcelacontapagar(
                                com_id,par_numero,par_valor,par_dtvencimento,par_descricao
                                ) values (
                                @com_id,@par_numero,@par_valor,@par_dtvencimento,@par_descricao
                                ) returning par_id"
                                , "@com_id", idcompra, "@par_numero", i,
                                "@par_valor", totalaux, "@par_dtvencimento", dataprimeirovenc, "@par_descricao",descricao
                            );
                        }

                    fb.executeNonQuery(@"update parcelacontapagar set
                                        par_pai=@par_pai where par_id = @par_id"
                                        , "@par_pai", idparcela, "@par_id", idparcela);
                   

                    dataprimeirovenc = dataprimeirovenc.AddMonths(1);
                }
                fb.desconecta();
               
            }
            return idparcela;
        }*/

        public int insereContaPagar(int idcompra, int parnumero, decimal valorparcela, DateTime dtvencimento, bool avista, int idcaixa, string descricao)
        {
            FBBanco fb = new FBBanco();
 
            int idparcela = 0;

            if (fb.conecta())
            {

                    if (avista)
                        idparcela = fb.executeScalar(@"insert into parcelacontapagar(
                        com_id,par_numero,par_valor,par_dtvencimento,
                        par_dtpagamento,par_status,par_valorpago,cai_id,par_descricao,par_estornar
                        ) values (
                        @com_id,@par_numero,@par_valor,@par_dtvencimento,
                        @par_dtpagamento,@par_status,@par_valorpago,@cai_id,@par_descricao,@par_estornar
                        ) returning par_id"
                        , "@com_id", idcompra, "@par_numero", parnumero,
                        "@par_valor", valorparcela, "@par_dtvencimento", dtvencimento,
                        "@par_dtpagamento", DateTime.Now.Date, "@par_status", 0,
                        "@par_valorpago", valorparcela, "@cai_id", idcaixa, "@par_descricao", descricao,"@par_estornar", 1
                          );
                    else
                        if (dtvencimento == DateTime.Now.Date)
                        {
                            idparcela = fb.executeScalar(@"insert into parcelacontapagar(
                                com_id,par_numero,par_valor,par_dtvencimento,
                                par_dtpagamento,par_status,par_valorpago,cai_id,par_descricao,par_estornar
                                ) values (
                                @com_id,@par_numero,@par_valor,@par_dtvencimento,
                                @par_dtpagamento,@par_status,@par_valorpago,@cai_id,@par_descricao,@par_estornar
                                ) returning par_id"
                                , "@com_id", idcompra, "@par_numero", parnumero,
                                "@par_valor", valorparcela, "@par_dtvencimento", dtvencimento,
                                "@par_dtpagamento", dtvencimento, "@par_status", 0,
                                "@par_valorpago", valorparcela, "@cai_id", idcaixa, "@par_descricao", descricao, "@par_estornar", 1
                              );
                        }
                        else
                        {
                            idparcela = fb.executeScalar(@"insert into parcelacontapagar(
                                com_id,par_numero,par_valor,cai_id,par_dtvencimento,par_descricao
                                ) values (
                                @com_id,@par_numero,@par_valor,@cai_id,@par_dtvencimento,@par_descricao
                                ) returning par_id"
                                , "@com_id", idcompra, "@par_numero", parnumero,
                                "@par_valor", valorparcela, "@cai_id", idcaixa, "@par_dtvencimento", dtvencimento, "@par_descricao", descricao
                            );
                        }

                    fb.executeNonQuery(@"update parcelacontapagar set
                                        par_pai=@par_pai where par_id = @par_id"
                                        , "@par_pai", idparcela, "@par_id", idparcela);

                }
                fb.desconecta();

            
            return idparcela;
        }


    }
}
