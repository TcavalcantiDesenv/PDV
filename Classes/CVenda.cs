using Classes.FBBanco;
using System;
using System.Data;


namespace MGMPDV
{
    class CVenda
    {
        public int ven_id { get; set; }
        public int cli_id { get; set; }
        public int fun_id { get; set; }
        public DateTime ven_data { get; set; }
        public DateTime ven_hora { get; set; }
        public string ven_dataf { get; set; }
        public string ven_horaf { get; set; }
        public decimal ven_total { get; set; }
        public decimal ven_desconto {get; set;}
        public int ven_status { get; set; }
        public string ven_senha { get; set; }
        public int cai_id { get; set; }



        public CVenda()
        {

        }

        public int inserir(int cli_id, int fun_id, int ven_total, string ven_senha, int cai_id)
        {
            FBBanco fb = new FBBanco();
            int idvenda = 0; ;
            if (fb.conecta())
            {
                idvenda = fb.executeScalar(@"insert into Venda(
                    cli_id,fun_id,ven_total,ven_senha, cai_id
                    ) values (
                    @cli_id,@fun_id,@ven_total,@ven_senha, @cai_id
                    ) returning ven_id",
                    "@cli_id",cli_id, "@fun_id",fun_id,"@ven_total",ven_total,"@ven_senha", ven_senha, "@cai_id", cai_id
                    );
                
                fb.desconecta();
                ven_id = idvenda;
                return idvenda;

            }
            ven_id = idvenda;
            return idvenda;
        }

        public int inserircancelada(int fun_id)
        {
            FBBanco fb = new FBBanco();
            int idvenda = 0; ;
            if (fb.conecta())
            {
                idvenda = fb.executeScalar(@"insert into Vendacancelada(
                    ven_id,cli_id,fun_id,ven_total,ven_senha,ven_data,ven_hora
                    ) values (
                    @ven_id,@cli_id,@fun_id,@ven_total,@ven_senha,@ven_data,@ven_hora
                    ) returning ven_id",
                     "@ven_id", ven_id, "@cli_id", cli_id, "@fun_id", fun_id, "@ven_total", ven_total, "@ven_senha", ven_senha, "@ven_data", ven_data, "@ven_hora", ven_hora
                    );

                fb.desconecta();
                ven_id = idvenda;
                return idvenda;

            }
            ven_id = idvenda;
            return idvenda;
        }

        public void aplicardesconto(int idvenda, decimal desconto)
        {
            FBBanco fb = new FBBanco();

            if (fb.conecta())
            {

                fb.executeNonQuery("update Venda set ven_desconto=ven_desconto+@desconto where ven_id = @ven_id", "@ven_id", idvenda, "@desconto", desconto);
                CContaPagar cc = new CContaPagar();
                fb.desconecta();



            }
        }

        public void atualizarDesconto(int idvenda, decimal desconto)
        {
            FBBanco fb = new FBBanco();

            if (fb.conecta())
            {

                fb.executeNonQuery("update Venda set ven_desconto=@desconto where ven_id = @ven_id", "@ven_id", idvenda, "@desconto", desconto);
                CContaPagar cc = new CContaPagar();
                fb.desconecta();



            }
        }

        public void atualizarClienteFuncionario(int idvenda, int idcliente, int idfunvenda)
        {
            FBBanco fb = new FBBanco();

            if (fb.conecta())
            {

                fb.executeNonQuery("update Venda set cli_id=@idcliente,fun_id=@idfunvenda where ven_id = @ven_id", "@ven_id", idvenda, "@idcliente", idcliente,  "@idfunvenda", idfunvenda);
                CContaPagar cc = new CContaPagar();
                fb.desconecta();
            }
        }

        public void atualizarCaixa(int idvenda, int idcaixa)
        {
            FBBanco fb = new FBBanco();

            if (fb.conecta())
            {

                fb.executeNonQuery("update Venda set cai_id=@idcaixa where ven_id = @ven_id", "@ven_id", idvenda, "@idcaixa", idcaixa);
                fb.desconecta();
            }
        }

        public void atualizarSenha(int idvenda, string senha)
        {
            FBBanco fb = new FBBanco();

            if (fb.conecta())
            {

                fb.executeNonQuery("update Venda set ven_senha=@senha where ven_id = @ven_id", "@senha", senha, "@ven_id", idvenda);
                fb.desconecta();
            }
        }

        public void adicionarvalor(int idvenda, decimal total)
        {
            FBBanco fb = new FBBanco();

            if (fb.conecta())
            {

                fb.executeNonQuery("update Venda set ven_total=ven_total+@total where ven_id = @ven_id", "@ven_id", idvenda, "@total", total);
                fb.desconecta();



            }
        }


        public void reativar(int idvenda)
        {
            FBBanco fb = new FBBanco();

            if (fb.conecta())
            {

                fb.executeNonQuery("update Venda set ven_status=1 where ven_id = @ven_id", "@ven_id", idvenda);
                // CContaPagar cc = new CContaPagar();
                // cc.cancelarConta(idvenda);
                fb.desconecta();



            }
        }

        public void cancelar(int idvenda)
        {
            FBBanco fb = new FBBanco();
            
            if (fb.conecta())
            {

                fb.executeNonQuery("update Venda set ven_status=0, ven_total=0, ven_desconto=0 where ven_id = @ven_id", "@ven_id", idvenda);
               // CContaPagar cc = new CContaPagar();
               // cc.cancelarConta(idvenda);
                fb.desconecta();
                
                

            }
        }

        public void excluir(int idvenda)
        {
            FBBanco fb = new FBBanco();

            if (fb.conecta())
            {

                fb.executeNonQuery("delete from Venda where ven_id = @ven_id", "@ven_id", idvenda);

                fb.desconecta();



            }
        }

        public void fechar(int idvenda)
        {
            FBBanco fb = new FBBanco();

            if (fb.conecta())
            {

                fb.executeNonQuery("update Venda set ven_status=0, ven_total=@ven_total where ven_id = @ven_id", "@ven_id", idvenda, "@ven_total", ven_total, "@ven_dataf", DateTime.Now.Date, "@ven_horaf", DateTime.Now.TimeOfDay);
                fb.desconecta();



            }
        }

        public DataTable pesquisar(string parametro, string campo)
        {
            DataTable dt = new DataTable();
            FBBanco fb = new FBBanco();
            if (fb.conecta())
            {
                fb.executeQuery(@"select * from Venda v 
                                left join cliente c on c.cli_id=v.cli_id 
                                left join funcionario f on f.fun_id=v.fun_id 
                                where cli_nome like @parametro order by ven_data desc, ven_hora desc, cli_nome asc",
                                 out dt, "@parametro", '%' + parametro + '%');
                fb.desconecta();
            }

            return dt;
        }

        public DataTable pesquisarIDCliente(int idcliente)
        {
            DataTable dt = new DataTable();
            FBBanco fb = new FBBanco();
            if (fb.conecta())
            {
                fb.executeQuery(@"select * from Venda v 
                                left join cliente c on c.cli_id=v.cli_id 
                                left join funcionario f on f.fun_id=v.fun_id 
                                where v.cli_id = @parametro order by ven_data desc, ven_hora desc, cli_nome asc",
                                 out dt, "@parametro", idcliente);
                fb.desconecta();
            }

            return dt;
        }


        public DataTable pesquisarIDCaixa(int idcaixa)
        {
            DataTable dt = new DataTable();
            FBBanco fb = new FBBanco();
            if (fb.conecta())
            {
                fb.executeQuery(@"select * from Venda v 
                                where v.cai_id = @parametro order by ven_data desc, ven_hora asc",
                                 out dt, "@parametro", idcaixa);
                fb.desconecta();
            }

            return dt;
        }
        public DataTable pesquisar(string parametro, DateTime datai, DateTime dataf)
        {
            DataTable dt = new DataTable();
            FBBanco fb = new FBBanco();
            if (fb.conecta())
            {
                fb.executeQuery(@"select * from Venda v 
                                left join cliente c on c.cli_id=v.cli_id 
                                left join funcionario f on f.fun_id=v.fun_id 
                                where 
                                (upper(cli_nome) like upper(@parametro) or
                                upper(ven_senha) like upper(@parametro) or
                                upper(fun_nome) like upper(@parametro) or
                                upper(cli_endereco) like upper(@parametro) )
                                and (ven_data between @datai and @dataf) and ven_status = 0
                                order by  ven_data desc, ven_hora desc, cli_nome asc",
                                 out dt, "@parametro", '%' + parametro + '%', "@datai", datai, "@dataf", dataf);
                fb.desconecta();
            }

            return dt;
        }

        public DataTable pesquisarcancelada(string parametro, DateTime datai, DateTime dataf)
        {
            DataTable dt = new DataTable();
            FBBanco fb = new FBBanco();
            if (fb.conecta())
            {
                fb.executeQuery(@"select * from Vendacancelada v 
                                left join cliente c on c.cli_id=v.cli_id 
                                left join funcionario f on f.fun_id=v.fun_id 
                                where 
                                (upper(cli_nome) like upper(@parametro) or
                                upper(ven_senha) like upper(@parametro) or
                                upper(fun_nome) like upper(@parametro) or
                                upper(cli_endereco) like upper(@parametro) )
                                and ven_data between @datai and @dataf
                                order by  ven_data desc, ven_hora desc, cli_nome asc",
                                 out dt, "@parametro", '%' + parametro + '%', "@datai", datai, "@dataf", dataf);
                fb.desconecta();
            }

            return dt;
        }

        public DataTable pesquisarDataIeDataF(DateTime datai, DateTime dataf)
        {
            DataTable dt = new DataTable();
            FBBanco fb = new FBBanco();
            if (fb.conecta())
            {
                fb.executeQuery(@"select * from Venda v 
                                  left join cliente c on c.cli_id=v.cli_id 
                                  left join funcionario f on f.fun_id = v.fun_id 
                                  where (ven_data between @datai and @dataf) and ven_status = 0 order by ven_data desc, ven_hora desc",
                                 out dt, "@datai", datai, "@dataf", dataf);
                fb.desconecta();
            }

            return dt;
        }

        public DataTable pesquisarDataIeDataFvendacancelada(DateTime datai, DateTime dataf)
        {
            DataTable dt = new DataTable();
            FBBanco fb = new FBBanco();
            if (fb.conecta())
            {
                fb.executeQuery(@"select * from Vendacancelada v 
                                  left join cliente c on c.cli_id=v.cli_id 
                                  left join funcionario f on f.fun_id = v.fun_id 
                                  where ven_data between @datai and @dataf order by ven_data desc, ven_hora desc",
                                 out dt, "@datai", datai, "@dataf", dataf);
                fb.desconecta();
            }

            return dt;
        }

        public DataTable pesquisarvendaaberta(int idcaixa)
        {
            DataTable dt = new DataTable();
            FBBanco fb = new FBBanco();
            if (fb.conecta())
            {
                fb.executeQuery(@"select * from Venda v 
                left join cliente c on c.cli_id=v.cli_id 
                left join funcionario f on f.fun_id=v.fun_id
                left join caixa ca on ca.cai_id = v.cai_id
                where ven_status = 1 and v.cai_id = @idcaixa order by cli_nome asc, ven_data desc, ven_hora desc",
                                 out dt, "@idcaixa", idcaixa);
                fb.desconecta();
            }

            ven_id = 0;
            if (dt.Rows.Count >0 )
            {
                ven_id = int.Parse(dt.Rows[0]["ven_id"].ToString());
                cli_id = int.Parse(dt.Rows[0]["cli_id"].ToString());
                fun_id = int.Parse(dt.Rows[0]["fun_id"].ToString());
                ven_data = DateTime.Parse(dt.Rows[0]["ven_data"].ToString());
                ven_hora = DateTime.Parse(dt.Rows[0]["ven_hora"].ToString());
                ven_dataf = "";
                ven_horaf = "";
                try
                {
                    ven_dataf = DateTime.Parse(dt.Rows[0]["ven_dataf"].ToString()).ToShortDateString();
                    ven_horaf = DateTime.Parse(dt.Rows[0]["ven_horaf"].ToString()).ToString("T");
                }
                catch {  }
                ven_total = decimal.Parse(dt.Rows[0]["ven_total"].ToString());
                ven_desconto = decimal.Parse(dt.Rows[0]["ven_desconto"].ToString());
                ven_status = int.Parse(dt.Rows[0]["ven_status"].ToString());
                ven_senha = dt.Rows[0]["ven_senha"].ToString();
                cai_id = int.Parse(dt.Rows[0]["cai_id"].ToString());
            }
            return dt;
        }

        public DataTable pesquisarvendaIdVenda(int idvenda)
        {
            DataTable dt = new DataTable();
            FBBanco fb = new FBBanco();
            if (fb.conecta())
            {
                fb.executeQuery(@"select * from Venda v 
                left join cliente c on c.cli_id=v.cli_id 
                 where ven_id = @idvenda order by cli_nome asc, ven_data desc, ven_hora desc",
                                 out dt, "@idvenda", idvenda);
                fb.desconecta();

                if (dt.Rows.Count > 0)
                {
                    ven_id = int.Parse(dt.Rows[0]["ven_id"].ToString());
                    cli_id = int.Parse(dt.Rows[0]["cli_id"].ToString());
                    fun_id = int.Parse(dt.Rows[0]["fun_id"].ToString());
                    ven_data = DateTime.Parse(dt.Rows[0]["ven_data"].ToString());
                    ven_hora = DateTime.Parse(dt.Rows[0]["ven_hora"].ToString());
                    ven_dataf = "";
                    ven_horaf = "";
                    try
                    {
                        ven_dataf = DateTime.Parse(dt.Rows[0]["ven_dataf"].ToString()).ToShortDateString();
                        ven_horaf = DateTime.Parse(dt.Rows[0]["ven_horaf"].ToString()).ToString("T");
                    }
                    catch { }
                    ven_total = decimal.Parse(dt.Rows[0]["ven_total"].ToString());
                    ven_desconto = decimal.Parse(dt.Rows[0]["ven_desconto"].ToString());
                    ven_status = int.Parse(dt.Rows[0]["ven_status"].ToString());
                    ven_senha = dt.Rows[0]["ven_senha"].ToString();
                    cai_id = int.Parse(dt.Rows[0]["cai_id"].ToString());
                }
            }


            return dt;
        }

        public DataTable carregarVenda(string datastring)
        {
            FBBanco fb = new FBBanco();
            DataTable dt = new DataTable();
            if (fb.conecta())
            {
                string sql = @"select v.ven_id,v.ven_total, ven_data,p.par_status from venda v
left join parcelacontareceber p on p.ven_id = v.ven_id ";
                if (datastring.Trim() != "")
                {
                    sql += "where ven_data = @data ";
                    sql += "group by ven_id, v.ven_total, ven_data, p.par_status order by par_status desc,ven_data,ven_id";
                    fb.executeQuery(sql, out dt, "@data", Convert.ToDateTime(datastring));
                }
                else
                {
                    sql += "group by ven_id, v.ven_total, ven_data, p.par_status order by par_status desc,ven_data,ven_id";
                    fb.executeQuery(sql, out dt);
                }
                fb.desconecta();


            }
            return dt;
        }

        public void inserirPreVenda(int idvenda, int idcliente)
        {
            FBBanco fb = new FBBanco();
            DataTable dt = new DataTable();
            if(fb.conecta())
            {
                string sql = @"update venda set ven_status = 2, cli_id=@idcliente where ven_id=@ven_id";
                fb.executeNonQuery(sql, "@ven_id", idvenda, "@idcliente", idcliente);
                fb.desconecta();
            }
        }

        public DataTable pesquisarPreVenda()
        {
            FBBanco fb = new FBBanco();
            DataTable dt = new DataTable();
            if (fb.conecta())
            {
                string sql = @"select * from venda v
                               left join cliente c on c.cli_id = v.cli_id where ven_status = 2";
                fb.executeQuery(sql, out dt);
                fb.desconecta();
            }


            if (dt.Rows.Count > 0)
            {
                ven_id = int.Parse(dt.Rows[0]["ven_id"].ToString());
            }

            return dt;
        }

        public DataTable pesquisarPreVendaIDCliente(int idcliente)
        {
            FBBanco fb = new FBBanco();
            DataTable dt = new DataTable();
            if (fb.conecta())
            {
                string sql = @"select * from venda v
                               left join cliente c on c.cli_id = v.cli_id
                                where ven_status = 2 and v.cli_id=@idcliente";
                fb.executeQuery(sql, out dt, "@idcliente", idcliente);
                fb.desconecta();
            }


            if (dt.Rows.Count > 0)
            {
                ven_id = int.Parse(dt.Rows[0]["ven_id"].ToString());
            }

            return dt;
        }
    }
}
