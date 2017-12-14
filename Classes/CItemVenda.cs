using Classes.FBBanco;
using System;
using System.Data;

namespace MGMPDV
{
    class CItemVenda
    {
        public int ite_id { get; set; }
        public int ven_id { get; set; }
        public int pro_id { get; set; }
        public decimal ite_quantidade { get; set; }
        public decimal ite_valor { get; set; }

        public CItemVenda()
        {

        }

        public void inserir(int idvenda, int idproduto, decimal quantidade, decimal valor)
        {
            FBBanco fb = new FBBanco();

            if (fb.conecta())
            {
                fb.executeNonQuery(@"insert into ITEMVENDA(
                    ven_id,pro_id,ite_quantidade,ite_valor
                    ) values (
                    @ven_id,@pro_id,@ite_quantidade,@ite_valor
                    )",
                    "@ven_id", idvenda, "@pro_id", idproduto, "@ite_quantidade", quantidade, "@ite_valor", valor
                    );
                fb.desconecta();

            }

        }

        public void remover(int iditemvenda)
        {
            FBBanco fb = new FBBanco();

            if (fb.conecta())
            {
                fb.executeNonQuery(@"delete from ITEMVENDA where ite_id=@id
                    ",
                    "@id", iditemvenda
                    );
                fb.desconecta();

            }
        }

        public void removerTodos()
        {
            FBBanco fb = new FBBanco();

            if (fb.conecta())
            {
                fb.executeNonQuery(@"delete from ITEMVENDA
                    ",
                    "@id", "0"
                    );
                fb.desconecta();

            }
        }

        /*public void excluirCompra(int id)
        {
            FBBanco fb = new FBBanco();
            if (fb.conecta())
            {
                fb.executeNonQuery("delete from Compra where com_id = @com_id", "@com_id", id);
                fb.desconecta();

            }
        }*/
        public DataTable pesquisarIditemvenda(int iditemvenda)
        {
            DataTable dt = new DataTable();
            FBBanco fb = new FBBanco();
            if (fb.conecta())
            {
                fb.executeQuery(@"select * from ItemVenda i 
                                left join produto p on p.pro_id = i.pro_id where ite_id = @iditemvenda",
                                 out dt, "@iditemvenda", iditemvenda);
                fb.desconecta();
            }

            if (dt.Rows.Count > 0)
            {
                ite_id = int.Parse(dt.Rows[0]["ite_id"].ToString());
                pro_id = int.Parse(dt.Rows[0]["pro_id"].ToString());
                ite_quantidade = int.Parse(dt.Rows[0]["ite_quantidade"].ToString());
                ite_valor = decimal.Parse(dt.Rows[0]["ite_valor"].ToString());
                ven_id = int.Parse(dt.Rows[0]["ven_id"].ToString());
            }
            return dt;
        }

        public DataTable pesquisarItemVendaIDProdutoData(int idproduto, DateTime datai, DateTime dataf)
        {
            DataTable dt = new DataTable();
            FBBanco fb = new FBBanco();
            if (fb.conecta())
            {
                fb.executeQuery(@"select i.*,p.*, (i.ite_valor*i.ite_quantidade) as ite_total from ItemVenda i 
                                left join produto p on p.pro_id = i.pro_id where i.ite_data between @datai and @dataf and i.pro_id = @idproduto order by ite_id",
                                 out dt, "@datai",datai.Date, "@dataf", dataf.Date,"@idproduto", idproduto);
                fb.desconecta();
            }

            return dt;
        }

        public DataTable pesquisarItemVendaIDCategoriaData(int idcategoria, DateTime datai, DateTime dataf)
        {
            DataTable dt = new DataTable();
            FBBanco fb = new FBBanco();
            if (fb.conecta())
            {
                fb.executeQuery(@"select i.*,p.*, (i.ite_valor*i.ite_quantidade) as ite_total from ItemVenda i 
                                left join produto p on p.pro_id = i.pro_id
                                left join categoria c on c.cat_id = p.cat_id 
                                where i.ite_data between @datai and @dataf and c.cat_id = @idcategoria order by ite_id",
                                 out dt, "@datai", datai.Date, "@dataf", dataf.Date, "@idcategoria", idcategoria);
                fb.desconecta();
            }

            return dt;
        }

        public DataTable pesquisarItemVendaData(DateTime datai, DateTime dataf)
        {
            DataTable dt = new DataTable();
            FBBanco fb = new FBBanco();
            if (fb.conecta())
            {
                fb.executeQuery(@"select i.*,p.*, (i.ite_valor*i.ite_quantidade) as ite_total from ItemVenda i 
                                left join produto p on p.pro_id = i.pro_id where i.ite_data between @datai and @dataf order by pro_nome, ite_id",
                                 out dt, "@datai", datai.Date, "@dataf", dataf.Date);
                fb.desconecta();
            }

            return dt;
        }

        public DataTable pesquisar(int idvenda)
        {
            DataTable dt = new DataTable();
            FBBanco fb = new FBBanco();
            if (fb.conecta())
            {
                fb.executeQuery("select i.*,p.*, (ite_quantidade*ite_valor) as ite_total from ItemVenda i left join produto p on p.pro_id = i.pro_id where ven_id = @ven_id",
                                 out dt, "@ven_id", idvenda);
                fb.desconecta();
            }

            return dt;
        }


        public decimal pesquisartotal(int idvenda)
        {
            DataTable dt = new DataTable();
            FBBanco fb = new FBBanco();
            if (fb.conecta())
            {
                fb.executeQuery("select sum(ite_valor*ite_quantidade) as total from ItemVenda where ven_id = @ven_id",
                                 out dt, "@ven_id", idvenda);
                fb.desconecta();
            }

            decimal total = 0;
                 
            if (dt.Rows.Count>0)
            {
                try
                {
                    total = decimal.Parse(dt.Rows[0]["total"].ToString());
                }
                catch { }
            }
            
            return total;
        }

        public DataTable pesquisarquantidadeItensVendidosData(DateTime datai, DateTime dataf)
        {
            DataTable dt = new DataTable();
            FBBanco fb = new FBBanco();
            if (fb.conecta())
            {
                fb.executeQuery(@"select i.pro_id, p.pro_codigo,p.pro_nome, ite_valor as pro_valor, sum(ite_quantidade) as pro_quantidade from itemvenda i
inner join produto p on p.pro_id = i.pro_id
where i.ite_data between @datai and @dataf
group by i.pro_id,p.pro_codigo, p.pro_nome, ite_valor",
                                 out dt, "@datai", datai.Date, "@dataf", dataf.Date);
                fb.desconecta();
            }

            return dt;
        }
    }
}
