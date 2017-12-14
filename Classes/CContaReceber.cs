using Classes.FBBanco;
using System;
using System.Data;

namespace MGMPDV
{
    class CContaReceber
    {
        public int par_id { get; set; }
        public decimal par_valor { get; set; }
        public decimal par_valorpago { get; set; }
        public DateTime par_dtvencimento { get; set; }
        public string par_descricao { get; set; }

        public CContaReceber()
        { }

        public void removerParcela(int idParcela)
        {
            FBBanco fb = new FBBanco();
            if (fb.conecta())
            {
                fb.executeNonQuery("delete from parcelacontareceber where par_id=@id", "@id", idParcela);
                fb.desconecta();
            }
        }
        
        public void removerParcelaDinheiro(int idvenda)
        {
            FBBanco fb = new FBBanco();
            if (fb.conecta())
            {
                fb.executeNonQuery(@"delete from parcelacontareceber
                where ven_id=@id and par_descricao = 'Dinheiro'"
                , "@id", idvenda);
                fb.desconecta();
            }
        }

        public void removerParcelaDebito(int idvenda)
        {
            FBBanco fb = new FBBanco();
            if (fb.conecta())
            {
                fb.executeNonQuery(@"delete from parcelacontareceber
                where ven_id=@id and par_descricao = 'Cartão - Débito'"
                , "@id", idvenda);
                fb.desconecta();
            }
        }

        public decimal carregarQtdeParcelasDinheiro(int idvenda)
        {
            FBBanco fb = new FBBanco();
            DataTable dt = new DataTable();
            if (fb.conecta())
            {

                string sql = @"select 
                count(par_id) as qtde
                from parcelacontareceber p  where ven_id = @idvenda and par_descricao='Dinheiro' order by par_pai,par_numero,par_id";
                fb.executeQuery(sql, out dt, "@idvenda", idvenda);
                fb.desconecta();
            }

            decimal qtde = 0;
            try { qtde = decimal.Parse(dt.Rows[0]["qtde"].ToString()); }
            catch { }
            return qtde;
        }

        public decimal carregarQtdeParcelasDebito(int idvenda)
        {
            FBBanco fb = new FBBanco();
            DataTable dt = new DataTable();
            if (fb.conecta())
            {

                string sql = @"select 
                count(par_id) as qtde
                from parcelacontareceber p  where ven_id = @idvenda and par_descricao='Cartão - Débito' order by par_pai,par_numero,par_id";
                fb.executeQuery(sql, out dt, "@idvenda", idvenda);
                fb.desconecta();
            }

            decimal qtde = 0;
            try { qtde = decimal.Parse(dt.Rows[0]["qtde"].ToString()); }
            catch { }
            return qtde;
        }

        public DataTable carregarParcelaIDParcela(int idparcela)
        {
            FBBanco fb = new FBBanco();
            DataTable dt = new DataTable();
            if (fb.conecta())
            {

                string sql = @"select 
                *
                from parcelacontareceber p  where par_id = @idparcela";
                fb.executeQuery(sql, out dt, "@idparcela", idparcela);
                fb.desconecta();
            }

            return dt;
        }

        public decimal carregarParcelaCreditoValor(int idparcela)
        {
            FBBanco fb = new FBBanco();
            DataTable dt = new DataTable();
            if (fb.conecta())
            {

                string sql = @"select 
                *
                from parcelacontareceber p  where par_id = @idparcela and par_descricao='Cartão - Crédito'  order by par_pai,par_numero,par_id";
                fb.executeQuery(sql, out dt, "@idparcela", idparcela);
                fb.desconecta();
            }

            decimal valor = 0;
            try { valor = decimal.Parse(dt.Rows[0]["par_valor"].ToString()); }
            catch { }
            return valor;
        }

        public decimal carregarParcelaChequeValor(int idparcela)
        {
            FBBanco fb = new FBBanco();
            DataTable dt = new DataTable();
            if (fb.conecta())
            {

                string sql = @"select 
                *
                from parcelacontareceber p  where par_id = @idparcela and par_descricao='Cheque' order by par_pai,par_numero,par_id";
                fb.executeQuery(sql, out dt, "@idparcela", idparcela);
                fb.desconecta();
            }

            decimal valor = 0;
            try { valor = decimal.Parse(dt.Rows[0]["par_valor"].ToString()); }
            catch { }
            return valor;
        }

        public decimal carregarParcelaMarcarValor(int idparcela)
        {
            FBBanco fb = new FBBanco();
            DataTable dt = new DataTable();
            if (fb.conecta())
            {

                string sql = @"select 
                *
                from parcelacontareceber p  where par_id = @idparcela and par_descricao='Marcar' order by par_pai,par_numero,par_id";
                fb.executeQuery(sql, out dt, "@idparcela", idparcela);
                fb.desconecta();
            }

            decimal valor = 0;
            try { valor = decimal.Parse(dt.Rows[0]["par_valor"].ToString()); }
            catch { }
            return valor;
        }
        public DataTable carregarParcelasMeioPagamentoAgrupado(int idvenda)
        {
            FBBanco fb = new FBBanco();
            DataTable dt = new DataTable();
            if (fb.conecta())
            {

                string sql = @"select 
                sum(par_valor) as par_total, par_descricao, p.mei_id
                from parcelacontareceber p 
                inner join meiopagamento m on m.mei_id = p.mei_id
                where ven_id = @idvenda 
                group by p.mei_id, par_descricao
                ";
                fb.executeQuery(sql, out dt, "@idvenda", idvenda);
                fb.desconecta();
            }
            return dt;
        }

        public DataTable carregarParcelas(int idvenda)
        {
            FBBanco fb = new FBBanco();
            DataTable dt = new DataTable();
            if (fb.conecta())
            {

                string sql = @"select 
                *
                from parcelacontareceber p left join cliente c on c.cli_id=p.cli_id where ven_id = @idvenda order by par_pai,par_numero,par_id";
                fb.executeQuery(sql, out dt, "@idvenda", idvenda);
                fb.desconecta();
            }
            return dt;
        }
        public decimal totaldinheiro(int idcaixa)
        {
            FBBanco fb = new FBBanco();
            DataTable dt = new DataTable();
            decimal total = 0;
            if (fb.conecta())
            {

                string sql = @"select 
                sum(par_valor) as total
                from parcelacontareceber where cai_id = @idcaixa and par_descricao='Dinheiro'";
                fb.executeQuery(sql, out dt, "@idcaixa", idcaixa);
                fb.desconecta();
            }

            if (dt.Rows.Count > 0)
            {
                try { total = decimal.Parse(dt.Rows[0]["total"].ToString()); }
                catch { }
            }
            return total;
        }
        public decimal totalcredito(int idcaixa)
        {
            FBBanco fb = new FBBanco();
            DataTable dt = new DataTable();
            decimal total = 0;
            if (fb.conecta())
            {

                string sql = @"select 
                sum(par_valor) as total
                from parcelacontareceber where cai_id = @idcaixa and par_descricao='Cartão - Crédito'";
                fb.executeQuery(sql, out dt, "@idcaixa", idcaixa);
                fb.desconecta();
            }
            
            if(dt.Rows.Count>0)
            {
                try { total = decimal.Parse(dt.Rows[0]["total"].ToString()); }
                catch { }
            }
            return total;
        }

        public decimal totaldebito(int idcaixa)
        {
            FBBanco fb = new FBBanco();
            DataTable dt = new DataTable();
            decimal total = 0;
            if (fb.conecta())
            {

                string sql = @"select 
                sum(par_valor) as total
                from parcelacontareceber where cai_id = @idcaixa and par_descricao='Cartão - Débito'";
                fb.executeQuery(sql, out dt, "@idcaixa", idcaixa);
                fb.desconecta();
            }

            if (dt.Rows.Count > 0)
            {
                try { total = decimal.Parse(dt.Rows[0]["total"].ToString()); }
                catch { }
            }
            return total;
        }

        public decimal totalcheque(int idcaixa)
        {
            FBBanco fb = new FBBanco();
            DataTable dt = new DataTable();
            decimal total = 0;
            if (fb.conecta())
            {

                string sql = @"select 
                sum(par_valor) as total
                from parcelacontareceber where cai_id = @idcaixa and par_descricao='Cheque'";
                fb.executeQuery(sql, out dt, "@idcaixa", idcaixa);
                fb.desconecta();
            }

            if (dt.Rows.Count > 0)
            {
                try { total = decimal.Parse(dt.Rows[0]["total"].ToString()); }
                catch { }
            }
            return total;
        }

        public decimal totalmarcar(int idcaixa)
        {
            FBBanco fb = new FBBanco();
            DataTable dt = new DataTable();
            decimal total = 0;
            if (fb.conecta())
            {

                string sql = @"select 
                sum(par_valor) as total
                from parcelacontareceber where cai_id = @idcaixa and par_descricao='Marcar'";
                fb.executeQuery(sql, out dt, "@idcaixa", idcaixa);
                fb.desconecta();
            }

            if (dt.Rows.Count > 0)
            {
                try { total = decimal.Parse(dt.Rows[0]["total"].ToString()); }
                catch { }
            }
            return total;
        }

        public decimal totalboleto(int idcaixa)
        {
            FBBanco fb = new FBBanco();
            DataTable dt = new DataTable();
            decimal total = 0;
            if (fb.conecta())
            {

                string sql = @"select 
                sum(par_valor) as total
                from parcelacontareceber where cai_id = @idcaixa and par_descricao='Boleto'";
                fb.executeQuery(sql, out dt, "@idcaixa", idcaixa);
                fb.desconecta();
            }

            if (dt.Rows.Count > 0)
            {
                try { total = decimal.Parse(dt.Rows[0]["total"].ToString()); }
                catch { }

            }
            return total;
        }
        public DataTable carregarParcelasCartao(int idvenda)
        {
            FBBanco fb = new FBBanco();
            DataTable dt = new DataTable();
            if (fb.conecta())
            {

                string sql = @"select 
                *
                from parcelacontareceber where ven_id = @idvenda and par_descricao='Cartão - Crédito' order by par_pai,par_numero,par_id";
                fb.executeQuery(sql, out dt, "@idvenda", idvenda);
                fb.desconecta();
            }
            return dt;
        }

        public DataTable carregarParcelasCheque(int idvenda)
        {
            FBBanco fb = new FBBanco();
            DataTable dt = new DataTable();
            if (fb.conecta())
            {

                string sql = @"select 
                *
                from parcelacontareceber p 
                left join cliente c on c.cli_id = p.cli_id
                where ven_id = @idvenda and par_descricao='Cheque' order by par_pai,par_numero,par_id";
                fb.executeQuery(sql, out dt, "@idvenda", idvenda);
                fb.desconecta();
            }
            return dt;
        }

        public DataTable carregarParcelasMarcar(int idvenda)
        {
            FBBanco fb = new FBBanco();
            DataTable dt = new DataTable();
            if (fb.conecta())
            {

                string sql = @"select 
                *
                from parcelacontareceber p 
                left join cliente c on c.cli_id = p.cli_id
                 where ven_id = @idvenda and par_descricao='Marcar' order by par_pai,par_numero,par_id";
                fb.executeQuery(sql, out dt, "@idvenda", idvenda);
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
                p.*,c.cli_id,c.cli_nome
                from parcelacontareceber p 
                left join venda v on v.ven_id = p.ven_id
                left join cliente c on c.cli_id=p.cli_id order by par_status desc,par_dtvencimento asc";
                fb.executeQuery(sql, out dt);
                fb.desconecta();
            }
            return dt;
        }
 
        public DataTable carregarParcelasPagasporValor(decimal valor)
        {
            FBBanco fb = new FBBanco();
            DataTable dt = new DataTable();
            if (fb.conecta())
            {

                string sql = @"select 
                *
                from parcelacontareceber p 
                left join venda v on v.ven_id = p.ven_id
                left join cliente c on c.cli_id=p.cli_id where par_status=0 and par_valorpago=@valor order by par_pai,par_numero,par_id";
                fb.executeQuery(sql, out dt, "@valor", valor);
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
                from parcelacontareceber p 
                left join venda v on v.ven_id = p.ven_id
                left join cliente c on c.cli_id=p.cli_id where par_status=0 and par_dtpagamento between @datai and @dataf order by par_pai,par_numero,par_id";
                fb.executeQuery(sql, out dt, "@datai", datai, "@dataf", dataf);
                fb.desconecta();
            }
            return dt;
        }

        public decimal carregarParcelasPagasDinheiro(int idvenda)
        {
            FBBanco fb = new FBBanco();
            DataTable dt = new DataTable();
            if (fb.conecta())
            {

                string sql = @"select sum(par_valor) as par_valor 
                from parcelacontareceber where ven_id = @idvenda and par_descricao = 'Dinheiro'";
                fb.executeQuery(sql, out dt, "@idvenda", idvenda);
                fb.desconecta();
            }


                try
                {
                    return decimal.Parse(dt.Rows[0]["par_valor"].ToString());
                }
                catch { return 0; }

        }

        public decimal carregarParcelasPagasCredito(int idvenda)
        {
            FBBanco fb = new FBBanco();
            DataTable dt = new DataTable();
            if (fb.conecta())
            {

                string sql = @"select sum(par_valor) as par_valor 
                from parcelacontareceber where ven_id = @idvenda and par_descricao = 'Cartão - Crédito'";
                fb.executeQuery(sql, out dt, "@idvenda", idvenda);
                fb.desconecta();
            }


            try
            {
                return decimal.Parse(dt.Rows[0]["par_valor"].ToString());
            }
            catch { return 0; }

        }

        public decimal carregarParcelasPagasDebito(int idvenda)
        {
            FBBanco fb = new FBBanco();
            DataTable dt = new DataTable();
            if (fb.conecta())
            {

                string sql = @"select sum(par_valor) as par_valor 
                from parcelacontareceber where ven_id = @idvenda and par_descricao = 'Cartão - Débito'";
                fb.executeQuery(sql, out dt, "@idvenda", idvenda);
                fb.desconecta();
            }


            try
            {
                return decimal.Parse(dt.Rows[0]["par_valor"].ToString());
            }
            catch { return 0; }

        }

        public decimal carregarParcelasPagasMarcar(int idvenda)
        {
            FBBanco fb = new FBBanco();
            DataTable dt = new DataTable();
            if (fb.conecta())
            {

                string sql = @"select sum(par_valor) as par_valor 
                from parcelacontareceber where ven_id = @idvenda and par_descricao = 'Marcar'";
                fb.executeQuery(sql, out dt, "@idvenda", idvenda);
                fb.desconecta();
            }


            try
            {
                return decimal.Parse(dt.Rows[0]["par_valor"].ToString());
            }
            catch { return 0; }

        }

        public decimal carregarParcelasPagasCheque(int idvenda)
        {
            FBBanco fb = new FBBanco();
            DataTable dt = new DataTable();
            if (fb.conecta())
            {

                string sql = @"select sum(par_valor) as par_valor 
                from parcelacontareceber where ven_id = @idvenda and par_descricao = 'Cheque'";
                fb.executeQuery(sql, out dt, "@idvenda", idvenda);
                fb.desconecta();
            }


            try
            {
                return decimal.Parse(dt.Rows[0]["par_valor"].ToString());
            }
            catch { return 0; }

        }


        public DataTable carregarParcelasIDCliente(int idcliente,DateTime datai, DateTime dataf)
        {
            FBBanco fb = new FBBanco();
            DataTable dt = new DataTable();
            if (fb.conecta())
            {

                string sql = @"select 
                *
                from parcelacontareceber p 
                left join venda v on v.ven_id = p.ven_id
                left join cliente c on c.cli_id=p.cli_id where p.cli_id=@id and par_dtvencimento between @datai and @dataf order by cli_nome,par_status desc, par_dtvencimento";
                fb.executeQuery(sql, out dt, "@datai", datai, "@dataf", dataf, "@id", idcliente);
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
                from parcelacontareceber p 
                left join venda v on v.ven_id = p.ven_id
                left join cliente c on c.cli_id=p.cli_id where par_dtvencimento between @datai and @dataf order by par_status desc, par_dtvencimento";
                fb.executeQuery(sql, out dt, "@datai", datai, "@dataf", dataf);
                fb.desconecta();
            }
            return dt;
        }
        

        public DataTable carregarParcelasDataPagamento(DateTime datai, DateTime dataf)
        {
            FBBanco fb = new FBBanco();
            DataTable dt = new DataTable();
            if (fb.conecta())
            {

                string sql = @"select 
                p.cai_id, m.mei_nome, (sum p.par_valor) as par_total
                from parcelacontareceber p 
                inner join meiopagamento m on m.mei_id = p.mei_id
";
                fb.executeQuery(sql, out dt, "@datai", datai, "@dataf", dataf);
                fb.desconecta();
            }
            return dt;
        }

        public DataTable carregarParcelasCliente(string clientenome)
        {
            FBBanco fb = new FBBanco();
            DataTable dt = new DataTable();
            if (fb.conecta())
            {

                string sql = @"select 
                *
                from parcelacontareceber p 
                left join venda v on v.ven_id = p.ven_id
                left join cliente c on c.cli_id=p.cli_id where UPPER(cli_nome) like UPPER(@clientenome) order by par_status desc,cli_nome,par_dtvencimento";
                fb.executeQuery(sql, out dt, "@clientenome", "%" + clientenome + "%");
                fb.desconecta();
            }
            return dt;
        }

        public DataTable carregarParcelasClienteInadimplente(int idcliente)
        {
            DataTable dt = new DataTable();
            FBBanco fb = new FBBanco();
            if (fb.conecta())
            {
                if (idcliente<=0)
                {
                    fb.executeQuery(@"select v.*,c.cli_nome,p.par_id,f.fun_nome from venda v
                                         inner join parcelacontareceber p on p.ven_id=v.ven_id
                                         left join cliente c on c.cli_id = p.cli_id 
                                         left join funcionario f on f.fun_id=v.fun_id
                                         where p.par_dtvencimento < @data and p.par_status = 1 order by par_status desc, par_dtvencimento", out dt, "@data", DateTime.Now.Date);
                }
                else
                    fb.executeQuery(@"select v.*,c.cli_nome,p.par_id,f.fun_nome from venda v
                                         inner join parcelacontareceber p on p.ven_id=v.ven_id
                                         left join cliente c on c.cli_id = p.cli_id 
                                         left join funcionario f on f.fun_id=v.fun_id
                                         where p.par_dtvencimento < @data and p.cli_id=@idcliente and p.par_status = 1 order by par_status desc, par_dtvencimento", out dt, "@data", DateTime.Now.Date, "@idcliente", idcliente);
                                
                fb.desconecta();
            }

            return dt;
        }

   

        public void pagar(int idcompra, int idcaixa, int idparcela,
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
                        sql = @"update parcelacontareceber set    
                                par_estornar = 0
                                where par_numero   = @par_numero and 
                                      par_controle = @par_controle and 
                                      par_pai      = @par_pai";
                        fb.executeNonQuery(sql, "@par_numero", par_numero, "@par_controle", par_controle - 1, "@par_pai", par_pai);
                    }

                    sql = @"update parcelacontareceber set 
                            cai_id          = @cai_id,
                            par_status      = 0,
                            par_valorpago   = @par_valorpago,
                            par_estornar    = 1,
                            par_dtpagamento = @par_dtpagamento 
                            where par_id = @par_id";
                    fb.executeNonQuery(sql, "@cai_id", idcaixa, "@par_id", idparcela,
                                            "@par_valorpago", valorpago, "@par_dtpagamento", dtpagamento
                                       );

                    if (valor > valorpago)
                    {
                        DateTime data = dtvencimento.AddMonths(1);
                        sql = @"insert into parcelacontareceber(
                                par_pai,par_controle,par_numero,ven_id,par_valor,
                                par_dtvencimento,par_status,
                                par_valorpago, par_descricao
                                ) values(
                                @par_pai,@par_controle,@par_numero,@ven_id,@par_valor,
                                @par_dtvencimento,@par_status,
                                @par_valorpago,@par_descricao
                                )";

                        if (par_pai <= 0)
                            par_pai = idparcela;

                        par_controle++;
                        fb.executeNonQuery(sql,
                            "@ven_id", idcompra, "@par_pai", par_pai, "@par_controle", par_controle,
                            "@par_numero", par_numero, "@par_valor", valor - valorpago,
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
                        sql = @"update parcelacontareceber set 
                                par_estornar    = 1 
                                where par_numero    = @par_numero and 
                                      par_controle  = @par_controle and 
                                      par_pai       = @par_pai";
                        fb.executeNonQuery(sql, "@par_numero", par_numero, "@par_controle", par_controle - 1, "@par_pai", par_pai);

                    }

                    sql = @"update parcelacontareceber set 
                            par_status      = 1,
                            par_valorpago   = 0,
                            par_estornar    = 0,
                            par_dtpagamento = null 
                            where par_id=@par_id";

                    fb.executeNonQuery(sql, "@par_id", idparcela);

                    sql = @"delete from parcelacontareceber 
                            where par_numero    = @par_numero and 
                                  par_controle  = @par_controle and 
                                  par_pai       = @par_pai";
                    fb.executeNonQuery(sql,
                                       "@par_pai", par_pai, "@par_numero", par_numero,
                                       "@par_controle", par_controle + 1);

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
                fb.executeNonQuery(@"update parcelacontareceber set 
                par_valor=@valor
                where par_id = @idparcela"
                , "@idparcela", idparcela, "@valor", valor);
                fb.desconecta();
            }
        }

        public void alterarValorDinheiro(int idvenda, decimal valor)
        {
            FBBanco fb = new FBBanco();
            if (fb.conecta())
            {
                fb.executeNonQuery(@"update parcelacontareceber set 
                par_valor=@valor
                where ven_id=@id and par_descricao = 'Dinheiro'"
                , "@id", idvenda, "@valor", valor);
                fb.desconecta();
            }
        }

        public void alterarValorDebito(int idvenda, decimal valor)
        {
            FBBanco fb = new FBBanco();
            if (fb.conecta())
            {
                fb.executeNonQuery(@"update parcelacontareceber set 
                par_valor=@valor
                where ven_id=@id and par_descricao = 'Cartão - Débito'"
                , "@id", idvenda, "@valor", valor);
                fb.desconecta();
            }
        }

        public void alterarData(int idparcela, DateTime data)
        {
            FBBanco fb = new FBBanco();
            if (fb.conecta())
            {
                fb.executeNonQuery(@"update parcelacontareceber set 
                par_dtvencimento=@data  
                where par_id = @idparcela"
                , "@idparcela", idparcela, "@data", data.Date);
                fb.desconecta();
            }
        }

        public decimal totalPacelaContaReceber(int idcaixa)
        {
            decimal total=0;
            FBBanco fb = new FBBanco();
            if (fb.conecta())
            {
                DataTable dt = new DataTable();
                fb.executeQuery("select sum(par_valor) as total from parcelacontareceber where cai_id=@cai_id", out dt, "@cai_id", idcaixa);
                try
                {
                    total = decimal.Parse(dt.Rows[0]["total"].ToString());
                }
                catch { }
                fb.desconecta();
            }

            return total;
        }

        public DataTable carregarParcelasTotalPagamento(DateTime datai, DateTime dataf)
        {
            FBBanco fb = new FBBanco();
            DataTable dt = new DataTable();
            if (fb.conecta())
            {

                string sql = @"select
m.mei_nome as par_descricao, sum(p.par_valor) as par_total
from caixa c
left join parcelacontareceber p on p.cai_id = c.cai_id
inner join meiopagamento m on m.mei_id = p.mei_id
where cai_datainicial between @datai and @dataf
group by p.mei_id, par_descricao
order by par_descricao";
                fb.executeQuery(sql, out dt, "@datai", datai, "@dataf", dataf);
                fb.desconecta();
            }
            return dt;
        }

        public DataTable carregarParcelasCaixaRelatorio(int idcaixa)
        {
            FBBanco fb = new FBBanco();
            DataTable dt = new DataTable();
            if (fb.conecta())
            {

                string sql = @"select
m.mei_nome as par_descricao, sum(p.par_valor) as par_total
from parcelacontareceber p
inner join meiopagamento m on m.mei_id = p.mei_id
where p.cai_id=@cai_id
group by p.mei_id, par_descricao
order by par_descricao";
                fb.executeQuery(sql, out dt, "@cai_id", idcaixa);
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
                from parcelacontareceber p 
                left join venda v on v.ven_id = p.ven_id
                left join cliente c on c.cli_id=p.cli_id  where p.cai_id=@cai_id order by cli_nome,par_descricao,par_pai,par_numero,par_id";
                fb.executeQuery(sql, out dt, "@cai_id", idcaixa);
                fb.desconecta();
            }
            return dt;
        }

        public decimal totalPacelaContaReceberVenda(int idvenda)
        {
            decimal total = 0;
            FBBanco fb = new FBBanco();
            if (fb.conecta())
            {
                DataTable dt = new DataTable();
                fb.executeQuery("select sum(par_valor) as total from parcelacontareceber where ven_id=@ven_id", out dt, "@ven_id", idvenda);
                try
                {
                    total = decimal.Parse(dt.Rows[0]["total"].ToString());
                }
                catch { }
                fb.desconecta();
            }

            return total;
        }

        public void cancelarConta(int idvenda)
        {
            FBBanco fb = new FBBanco();
            if (fb.conecta())
            {
                fb.executeNonQuery("update parcelacontareceber set par_status = 0 and par_valorpago = 0 where ven_id = @ven_id", "@ven_id", idvenda);
                fb.desconecta();
            }
        }

        /*       public int insereContaReceber(int idvenda, int quantidadeparcela, decimal total, DateTime dataprimeirovenc, bool avista, int idcaixa, int idcliente, string descricao)
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
                               idparcela = fb.executeScalar(@"insert into parcelacontareceber(
                               cli_id,ven_id,par_numero,par_valor,par_dtvencimento,
                               par_dtpagamento,par_status,par_valorpago,cai_id,par_descricao
                               ) values (
                               @cli_id,@ven_id,@par_numero,@par_valor,@par_dtvencimento,
                               @par_dtpagamento,@par_status,@par_valorpago,@cai_id,@par_descricao
                               ) returning par_id"
                               , "@cli_id", idcliente, "@ven_id", idvenda, "@par_numero", i,
                               "@par_valor", totalaux, "@par_dtvencimento", dataprimeirovenc,
                               "@par_dtpagamento", DateTime.Now.Date, "@par_status", 0,
                               "@par_valorpago", totalaux, "@cai_id", idcaixa, "@par_descricao", descricao
                                 );
                           else
                               if (dataprimeirovenc == DateTime.Now.Date)
                               {
                                   idparcela = fb.executeScalar(@"insert into parcelacontareceber(
                                       cli_id,ven_id,par_numero,par_valor,par_dtvencimento,
                                       par_dtpagamento,par_status,par_valorpago,cai_id,par_descricao
                                       ) values (
                                       @cli_id,@ven_id,@par_numero,@par_valor,@par_dtvencimento,
                                       @par_dtpagamento,@par_status,@par_valorpago,@cai_id,@par_descricao
                                       ) returning par_id"
                                       , "@cli_id", idcliente, "@ven_id", idvenda, "@par_numero", i,
                                       "@par_valor", totalaux, "@par_dtvencimento", dataprimeirovenc,
                                       "@par_dtpagamento", dataprimeirovenc, "@par_status", 0,
                                       "@par_valorpago", totalaux, "@cai_id", idcaixa, "@par_descricao", descricao
                                     );

                               }
                               else
                               {
                                   idparcela = fb.executeScalar(@"insert into parcelacontareceber(
                                       cli_id, ven_id,par_numero,par_valor,par_dtvencimento,par_descricao
                                       ) values (
                                       @cli_id, @ven_id,@par_numero,@par_valor,@par_dtvencimento,@par_descricao
                                       ) returning par_id"
                                       , "@cli_id", idcliente, "@ven_id", idvenda, "@par_numero", i,
                                       "@par_valor", totalaux, "@par_dtvencimento", dataprimeirovenc,"@par_descricao", descricao
                                   );
                               }

                           fb.executeNonQuery(@"update parcelacontareceber set
                                               par_pai=@par_pai where par_id = @par_id"
                           , "@par_pai", idparcela, "@par_id", idparcela);

                           dataprimeirovenc = dataprimeirovenc.AddMonths(1);

                       }


                       fb.desconecta();

                   }
                   return idparcela;
               }

               public CContaReceber[] insereContaReceberVet(int idvenda, int quantidadeparcela, decimal total, DateTime dataprimeirovenc, bool avista, int idcaixa, int idcliente, string descricao)
               {
                   FBBanco fb = new FBBanco();
                   CContaReceber[] cr = new CContaReceber[1000];
                   int k = 0;
                   decimal totalaux = total, resto = 0;

                   int parcelaaux = 0;

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


                           cr[k++] = new CContaReceber();

                           if (avista)
                           {
                               cr[k].par_dtvencimento = dataprimeirovenc;
                               cr[k].par_descricao = descricao;
                               cr[k].par_valor = totalaux;
                               cr[k].par_id = fb.executeScalar(@"insert into parcelacontareceber(
                               cli_id,ven_id,par_numero,par_valor,par_dtvencimento,
                               par_dtpagamento,par_status,par_valorpago,cai_id,par_descricao
                               ) values (
                               @cli_id,@ven_id,@par_numero,@par_valor,@par_dtvencimento,
                               @par_dtpagamento,@par_status,@par_valorpago,@cai_id,@par_descricao
                               ) returning par_id"
                               , "@cli_id", idcliente, "@ven_id", idvenda, "@par_numero", i,
                               "@par_valor", totalaux, "@par_dtvencimento", dataprimeirovenc,
                               "@par_dtpagamento", DateTime.Now.Date, "@par_status", 0,
                               "@par_valorpago", totalaux, "@cai_id", idcaixa, "@par_descricao", descricao
                                 );
                           }
                           else
                               if (dataprimeirovenc == DateTime.Now.Date)
                               {
                                   cr[k].par_dtvencimento = dataprimeirovenc;
                                   cr[k].par_descricao = descricao;
                                   cr[k].par_valor = totalaux;
                                   cr[k].par_id = fb.executeScalar(@"insert into parcelacontareceber(
                                       cli_id,ven_id,par_numero,par_valor,par_dtvencimento,
                                       par_dtpagamento,par_status,par_valorpago,cai_id,par_descricao
                                       ) values (
                                       @cli_id,@ven_id,@par_numero,@par_valor,@par_dtvencimento,
                                       @par_dtpagamento,@par_status,@par_valorpago,@cai_id,@par_descricao
                                       ) returning par_id"
                                       , "@cli_id", idcliente, "@ven_id", idvenda, "@par_numero", i,
                                       "@par_valor", totalaux, "@par_dtvencimento", dataprimeirovenc,
                                       "@par_dtpagamento", dataprimeirovenc, "@par_status", 0,
                                       "@par_valorpago", totalaux, "@cai_id", idcaixa, "@par_descricao", descricao
                                     );

                               }
                               else
                               {
                                   cr[k].par_dtvencimento = dataprimeirovenc;
                                   cr[k].par_descricao = descricao;
                                   cr[k].par_valor = totalaux;
                                   cr[k].par_id = fb.executeScalar(@"insert into parcelacontareceber(
                                       cli_id, ven_id,par_numero,par_valor,par_dtvencimento,par_descricao
                                       ) values (
                                       @cli_id, @ven_id,@par_numero,@par_valor,@par_dtvencimento,@par_descricao
                                       ) returning par_id"
                                       , "@cli_id", idcliente, "@ven_id", idvenda, "@par_numero", i,
                                       "@par_valor", totalaux, "@par_dtvencimento", dataprimeirovenc, "@par_descricao", descricao
                                   );
                               }

                           //vetidparcela[veti++]=idparcela;
                           fb.executeNonQuery(@"update parcelacontareceber set
                                               par_pai=@par_pai where par_id = @par_id"
                           , "@par_pai", cr[k].par_id, "@par_id", cr[k].par_id);

                           dataprimeirovenc = dataprimeirovenc.AddMonths(1);

                       }


                       fb.desconecta();

                   }
                   return cr;
               }*/
        public int insereContaReceber(int idvenda, int parnumero, decimal valorparcela, DateTime dtvencimento, bool avista, int idcaixa, int idcliente, string descricao, int mei_id)
        {
            FBBanco fb = new FBBanco();
            int idparcela = 0;
            if (fb.conecta())
            {

                if (avista)
                {
                    idparcela = fb.executeScalar(@"insert into parcelacontareceber(
                        mei_id,cli_id,ven_id,par_numero,par_valor,par_dtvencimento,
                        par_dtpagamento,par_status,par_valorpago,cai_id,par_descricao,par_estornar
                        ) values (
                        @mei_id,@cli_id,@ven_id,@par_numero,@par_valor,@par_dtvencimento,
                        @par_dtpagamento,@par_status,@par_valorpago,@cai_id,@par_descricao,@par_estornar
                        ) returning par_id"
                    , "mei_id", mei_id,"@cli_id", idcliente, "@ven_id", idvenda, "@par_numero", parnumero,
                    "@par_valor", valorparcela, "@par_dtvencimento", dtvencimento,
                    "@par_dtpagamento", DateTime.Now.Date, "@par_status", 0,
                    "@par_valorpago", valorparcela, "@cai_id", idcaixa, "@par_descricao", descricao, "@par_estornar", 1
                      );
                }
                else
                    if (dtvencimento == DateTime.Now.Date)
                {
                    idparcela = fb.executeScalar(@"insert into parcelacontareceber(
                                mei_id,cli_id,ven_id,par_numero,par_valor,par_dtvencimento,
                                par_dtpagamento,par_status,par_valorpago,cai_id,par_descricao,par_estornar
                                ) values (
                                @mei_id,@cli_id,@ven_id,@par_numero,@par_valor,@par_dtvencimento,
                                @par_dtpagamento,@par_status,@par_valorpago,@cai_id,@par_descricao,@par_estornar
                                ) returning par_id"
                        , "mei_id", mei_id, "@cli_id", idcliente, "@ven_id", idvenda, "@par_numero", parnumero,
                        "@par_valor", valorparcela, "@par_dtvencimento", dtvencimento,
                        "@par_dtpagamento", dtvencimento, "@par_status", 0,
                        "@par_valorpago", valorparcela, "@cai_id", idcaixa, "@par_descricao", descricao, "@par_estornar", 1
                      );

                }
                else
                {
                    idparcela = fb.executeScalar(@"insert into parcelacontareceber(
                                mei_id,cli_id, ven_id,par_numero,par_valor,cai_id,par_dtvencimento,par_descricao
                                ) values (
                                @mei_id,@cli_id, @ven_id,@par_numero,@par_valor,@cai_id,@par_dtvencimento,@par_descricao
                                ) returning par_id"
                        , "mei_id", mei_id, "@cli_id", idcliente, "@ven_id", idvenda, "@par_numero", parnumero,
                        "@par_valor", valorparcela, "@cai_id", idcaixa, "@par_dtvencimento", dtvencimento, "@par_descricao", descricao
                    );
                }

                fb.executeNonQuery(@"update parcelacontareceber set
                                        par_pai=@par_pai where par_id = @par_id"
                , "@par_pai", idparcela, "@par_id", idparcela);


                fb.desconecta();
            }


            return idparcela;
        }
        public int insereContaReceber(int idvenda, int parnumero, decimal valorparcela, DateTime dtvencimento, bool avista, int idcaixa, int idcliente, string descricao)
        {
            FBBanco fb = new FBBanco();
            int idparcela = 0;
            if (fb.conecta())
            {

                    if (avista)
                    {
                        idparcela = fb.executeScalar(@"insert into parcelacontareceber(
                        cli_id,ven_id,par_numero,par_valor,par_dtvencimento,
                        par_dtpagamento,par_status,par_valorpago,cai_id,par_descricao,par_estornar
                        ) values (
                        @cli_id,@ven_id,@par_numero,@par_valor,@par_dtvencimento,
                        @par_dtpagamento,@par_status,@par_valorpago,@cai_id,@par_descricao,@par_estornar
                        ) returning par_id"
                        , "@cli_id", idcliente, "@ven_id", idvenda, "@par_numero", parnumero,
                        "@par_valor", valorparcela, "@par_dtvencimento", dtvencimento,
                        "@par_dtpagamento", DateTime.Now.Date, "@par_status", 0,
                        "@par_valorpago", valorparcela, "@cai_id", idcaixa, "@par_descricao", descricao,"@par_estornar",1
                          );
                    }
                    else
                        if (dtvencimento == DateTime.Now.Date)
                        {
                            idparcela = fb.executeScalar(@"insert into parcelacontareceber(
                                cli_id,ven_id,par_numero,par_valor,par_dtvencimento,
                                par_dtpagamento,par_status,par_valorpago,cai_id,par_descricao,par_estornar
                                ) values (
                                @cli_id,@ven_id,@par_numero,@par_valor,@par_dtvencimento,
                                @par_dtpagamento,@par_status,@par_valorpago,@cai_id,@par_descricao,@par_estornar
                                ) returning par_id"
                                , "@cli_id", idcliente, "@ven_id", idvenda, "@par_numero", parnumero,
                                "@par_valor", valorparcela, "@par_dtvencimento", dtvencimento,
                                "@par_dtpagamento", dtvencimento, "@par_status", 0,
                                "@par_valorpago", valorparcela, "@cai_id", idcaixa, "@par_descricao", descricao, "@par_estornar", 1
                              );

                        }
                        else
                        {
                            idparcela = fb.executeScalar(@"insert into parcelacontareceber(
                                cli_id, ven_id,par_numero,par_valor,cai_id,par_dtvencimento,par_descricao
                                ) values (
                                @cli_id, @ven_id,@par_numero,@par_valor,@cai_id,@par_dtvencimento,@par_descricao
                                ) returning par_id"
                                , "@cli_id", idcliente, "@ven_id", idvenda, "@par_numero", parnumero,
                                "@par_valor", valorparcela, "@cai_id", idcaixa, "@par_dtvencimento", dtvencimento, "@par_descricao", descricao
                            );
                        }

                    fb.executeNonQuery(@"update parcelacontareceber set
                                        par_pai=@par_pai where par_id = @par_id"
                    , "@par_pai", idparcela, "@par_id", idparcela);


                    fb.desconecta();
                }


            return idparcela;
        }
    }
}
