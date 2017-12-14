using Classes.FBBanco;
using System.Data;

namespace MGMPDV
{
    class CProduto
    {
        public int pro_id { get; set; }
        public int cat_id { get; set; }
        public int mar_id { get; set; }
        public string cat_nome { get; set; }
        public string mar_nome { get; set; }
        public string pro_nome { get; set; }
        public string pro_descricao { get; set; }
        public decimal pro_valor { get; set; }
        public string pro_codigo { get; set; }
        public decimal pro_quantidade { get; set; }
        public int pro_estoque { get; set; }
        public string pro_ncm { get; set; }
        public decimal pro_aliquota { get; set; }
        public string pro_cfop { get; set; }
        public string pro_csosn { get; set; }
        public string pro_cst { get; set; }
        public string pro_cest { get; set; }
        public int pro_status { get; set; }
        public int pro_origem { get; set; }
        public decimal pro_porcentagemtributo { get; set; }


        public string pro_unidade { get; set; }
        //public string pro_imagem { get; set; }
        public byte[] pro_imagem { get; set; }
        public CProduto()
        { }

        public void inserir(int cat_id, int mar_id, string pro_nome, string pro_descricao, decimal pro_valor, string pro_codigo, string pro_unidade, decimal pro_quantidade, int pro_estoque, string pro_ncm, decimal pro_aliquota, string pro_cfop, int pro_origem, decimal pro_porcentagemtributo, string pro_csosn, string pro_cst, string pro_cest, int pro_status, byte[] arrayimagem)
        {
            FBBanco fb = new FBBanco();

            if (fb.conecta())
            {
                fb.executeNonQuery(@"insert into Produto(
                    cat_id,mar_id,pro_nome,pro_descricao,pro_valor,pro_codigo,pro_unidade,pro_quantidade,pro_estoque,pro_ncm,pro_aliquota,pro_cfop,pro_origem, pro_porcentagemtributo, pro_csosn, pro_cst, pro_cest,pro_status,pro_imagem
                    ) values (
                    @cat_id,@mar_id,@pro_nome,@pro_descricao,@pro_valor,@pro_codigo,@pro_unidade,@pro_quantidade,@pro_estoque,@pro_ncm,@pro_aliquota,@pro_cfop,@pro_origem, @pro_porcentagemtributo, @pro_csosn, @pro_cst, @pro_cest,@pro_status,@arrayimagem
                    )",
                    "@cat_id", cat_id, "@mar_id", mar_id, "@pro_nome", pro_nome, "@pro_descricao", pro_descricao, "@pro_valor", pro_valor,
                    "@pro_codigo", pro_codigo, "@pro_unidade", pro_unidade, "@pro_quantidade", pro_quantidade, "@pro_estoque", pro_estoque,
                    "@pro_ncm", pro_ncm, "@pro_aliquota", pro_aliquota, "@pro_cfop", pro_cfop, "@pro_origem", pro_origem,
                    "@pro_porcentagemtributo", pro_porcentagemtributo, "@pro_csosn", pro_csosn, "@pro_cst", pro_cst, "@pro_cest", pro_cest, "@pro_status", pro_status, "@arrayimagem", arrayimagem
                    );
                fb.desconecta();

            }
        }

        public void atualizar(int id, int cat_id, int mar_id, string pro_nome, string pro_descricao, decimal pro_valor, string pro_codigo, string pro_unidade, decimal pro_quantidade, int pro_estoque, string pro_ncm, decimal pro_aliquota, string pro_cfop, int pro_origem, decimal pro_porcentagemtributo, string pro_csosn, string pro_cst, string pro_cest, int pro_status, byte[] arrayimagem)
        {
            FBBanco fb = new FBBanco();
            if (fb.conecta())
            {

                fb.executeNonQuery(@"update Produto set
                                cat_id=@cat_id,mar_id=@mar_id,pro_nome=@pro_nome,pro_descricao=@pro_descricao,pro_estoque = @pro_estoque, 
                                pro_valor=@pro_valor,pro_codigo=@pro_codigo,pro_unidade=@pro_unidade,pro_quantidade=@pro_quantidade,pro_ncm=@pro_ncm, pro_aliquota=@pro_aliquota, pro_cfop=@pro_cfop, pro_origem = @pro_origem, pro_porcentagemtributo=@pro_porcentagemtributo, pro_csosn=@pro_csosn, pro_cst=@pro_cst, pro_cest=@pro_cest ,pro_status=@pro_status, pro_imagem = @arrayimagem
                                where pro_id = @pro_id
                                ",
                                "@cat_id", cat_id, "@mar_id", mar_id, "@pro_id", id, "@pro_nome", pro_nome, "@pro_descricao", pro_descricao, "@pro_valor", pro_valor,
                                "@pro_codigo", pro_codigo, "@pro_unidade", pro_unidade, "@pro_quantidade", pro_quantidade, "@pro_estoque", pro_estoque,
                                "@pro_ncm", pro_ncm, "@pro_aliquota", pro_aliquota, "@pro_cfop", pro_cfop, "@pro_origem", pro_origem,
                                "@pro_porcentagemtributo", pro_porcentagemtributo, "@pro_csosn", pro_csosn, "@pro_cst", pro_cst, "@pro_cest", pro_cest, "@pro_status", pro_status, "@arrayimagem", arrayimagem
                                );
                fb.desconecta();
            }
        }

        public void atualizar(int id, int cat_id, int mar_id, string pro_nome, string pro_descricao, decimal pro_valor, string pro_codigo)
        {
            FBBanco fb = new FBBanco();
            if (fb.conecta())
            {

                fb.executeNonQuery(@"update Produto set
                                cat_id=@cat_id, mar_id=@mar_id,pro_nome=@pro_nome,pro_descricao=@pro_descricao, 
                                pro_valor=@pro_valor,pro_codigo=@pro_codigo
                                where pro_id = @pro_id
                                ",
                                "@cat_id", cat_id, "@mar_id", mar_id, "@pro_id", id, "@pro_nome", pro_nome, "@pro_descricao", pro_descricao, "@pro_valor", pro_valor, "@pro_codigo", pro_codigo
                                );
                fb.desconecta();
            }
        }

        public void baixarestoque(int idproduto, decimal quantidade)
        {
            FBBanco fb = new FBBanco();
            if (fb.conecta())
            {

                fb.executeNonQuery(@"update Produto set
                                pro_quantidade=pro_quantidade-@pro_quantidade
                                
                                where pro_id = @pro_id and pro_estoque = 1
                                ",
                                "@pro_id", idproduto, "@pro_quantidade", quantidade
                                );
                fb.desconecta();
            }
        }

        public void RetornarEstoque(int idproduto, decimal quantidade)
        {
            FBBanco fb = new FBBanco();
            if (fb.conecta())
            {

                fb.executeNonQuery(@"update Produto set
                                pro_quantidade=pro_quantidade+@pro_quantidade
                                
                                where pro_id = @pro_id and pro_estoque = 1
                                ",
                                "@pro_id", idproduto, "@pro_quantidade", quantidade
                                );
                fb.desconecta();
            }
        }

        public bool excluir(int id)
        {
            bool ok = false;
            FBBanco fb = new FBBanco();
            if (fb.conecta())
            {
                ok = fb.executeNonQuery("delete from Produto where pro_id = @pro_id", "@pro_id", id);
                fb.desconecta();

            }
            return ok;
        }

        public DataTable pesquisarIdCategoria(int idcategoria)
        {
            DataTable dt = new DataTable();
            FBBanco fb = new FBBanco();
            if (fb.conecta())
            {
                fb.executeQuery(@"select * from produto p 
                                  left join categoria c on c.cat_id = p.cat_id
                                  left join marca m on m.mar_id = p.mar_id
                                    where c.cat_id = @parametro and p.pro_status=1 order by pro_nome",
                                 out dt, "@parametro", idcategoria);
                fb.desconecta();
            }

            if (dt.Rows.Count > 0)
            {
                pro_id = int.Parse(dt.Rows[0]["pro_id"].ToString());
                pro_nome = dt.Rows[0]["pro_nome"].ToString();
                pro_descricao = dt.Rows[0]["pro_descricao"].ToString();
                pro_valor = decimal.Parse(dt.Rows[0]["pro_valor"].ToString());
                pro_codigo = dt.Rows[0]["pro_codigo"].ToString();
                cat_id = int.Parse(dt.Rows[0]["cat_id"].ToString());
                cat_nome = dt.Rows[0]["cat_nome"].ToString();
                pro_quantidade = 0;
                try { pro_quantidade = decimal.Parse(dt.Rows[0]["pro_quantidade"].ToString()); }
                catch { }
                pro_estoque = int.Parse(dt.Rows[0]["pro_estoque"].ToString());
                mar_id = int.Parse(dt.Rows[0]["mar_id"].ToString());
                mar_nome = dt.Rows[0]["mar_nome"].ToString();
                pro_ncm = dt.Rows[0]["pro_ncm"].ToString();
                pro_aliquota = decimal.Parse(dt.Rows[0]["pro_aliquota"].ToString());
                pro_cfop = dt.Rows[0]["pro_cfop"].ToString();
                pro_csosn = dt.Rows[0]["pro_csosn"].ToString();
                pro_cst = dt.Rows[0]["pro_cst"].ToString();
                pro_cest = dt.Rows[0]["pro_cest"].ToString();
                pro_porcentagemtributo = decimal.Parse(dt.Rows[0]["pro_porcentagemtributo"].ToString());
                pro_origem = int.Parse(dt.Rows[0]["pro_origem"].ToString());
                pro_status = int.Parse(dt.Rows[0]["pro_status"].ToString());
                pro_unidade = dt.Rows[0]["pro_unidade"].ToString();
                pro_imagem = dt.Rows[0]["pro_imagem"] as byte[];
            }


            return dt;
        }

        public DataTable pesquisarid(int id)
        {
            DataTable dt = new DataTable();
            FBBanco fb = new FBBanco();
            if (fb.conecta())
            {
                fb.executeQuery(@"select * from produto p 
                                  left join categoria c on c.cat_id = p.cat_id
                                  left join marca m on m.mar_id = p.mar_id
                                    where pro_id = @parametro and p.pro_status=1 order by pro_nome",
                                 out dt, "@parametro", id);
                fb.desconecta();
            }

            if (dt.Rows.Count > 0)
            {
                pro_id = int.Parse(dt.Rows[0]["pro_id"].ToString());
                pro_nome = dt.Rows[0]["pro_nome"].ToString();
                pro_descricao = dt.Rows[0]["pro_descricao"].ToString();
                pro_valor = decimal.Parse(dt.Rows[0]["pro_valor"].ToString());
                pro_codigo = dt.Rows[0]["pro_codigo"].ToString();
                cat_id = int.Parse(dt.Rows[0]["cat_id"].ToString());
                cat_nome = dt.Rows[0]["cat_nome"].ToString();
                pro_quantidade = 0;
                try { pro_quantidade = decimal.Parse(dt.Rows[0]["pro_quantidade"].ToString()); }
                catch { }
                pro_estoque = int.Parse(dt.Rows[0]["pro_estoque"].ToString());
                mar_id = int.Parse(dt.Rows[0]["mar_id"].ToString());
                mar_nome = dt.Rows[0]["mar_nome"].ToString();
                pro_ncm = dt.Rows[0]["pro_ncm"].ToString();
                pro_aliquota = decimal.Parse(dt.Rows[0]["pro_aliquota"].ToString());
                pro_cfop = dt.Rows[0]["pro_cfop"].ToString();
                pro_origem = int.Parse(dt.Rows[0]["pro_origem"].ToString());
                pro_csosn = dt.Rows[0]["pro_csosn"].ToString();
                pro_cst = dt.Rows[0]["pro_cst"].ToString();
                pro_cest = dt.Rows[0]["pro_cest"].ToString();
                pro_porcentagemtributo = decimal.Parse(dt.Rows[0]["pro_porcentagemtributo"].ToString());
                pro_status = int.Parse(dt.Rows[0]["pro_status"].ToString());
                pro_unidade = dt.Rows[0]["pro_unidade"].ToString();
                pro_imagem = dt.Rows[0]["pro_imagem"] as byte[];
            }


            return dt;
        }

        public DataTable pesquisarCodigoBarra(string codigo)
        {
            DataTable dt = new DataTable();
            FBBanco fb = new FBBanco();
            if (fb.conecta())
            {
                fb.executeQuery(@"select * from produto p 
                                  left join categoria c on c.cat_id = p.cat_id
                                  left join marca m on m.mar_id = p.mar_id
                                    where pro_codigo = @parametro and p.pro_status=1 order by pro_nome",
                                 out dt, "@parametro", codigo);
                fb.desconecta();
            }

            if (dt.Rows.Count > 0)
            {
                pro_id = int.Parse(dt.Rows[0]["pro_id"].ToString());
                pro_nome = dt.Rows[0]["pro_nome"].ToString();
                pro_descricao = dt.Rows[0]["pro_descricao"].ToString();
                pro_valor = decimal.Parse(dt.Rows[0]["pro_valor"].ToString());
                pro_codigo = dt.Rows[0]["pro_codigo"].ToString();
                cat_id = int.Parse(dt.Rows[0]["cat_id"].ToString());
                cat_nome = dt.Rows[0]["cat_nome"].ToString();
                pro_quantidade = 0;
                try { pro_quantidade = decimal.Parse(dt.Rows[0]["pro_quantidade"].ToString()); }
                catch { }
                pro_estoque = int.Parse(dt.Rows[0]["pro_estoque"].ToString());
                mar_id = int.Parse(dt.Rows[0]["mar_id"].ToString());
                mar_nome = dt.Rows[0]["mar_nome"].ToString();
                pro_ncm = dt.Rows[0]["pro_ncm"].ToString();
                pro_aliquota = decimal.Parse(dt.Rows[0]["pro_aliquota"].ToString());
                pro_cfop = dt.Rows[0]["pro_cfop"].ToString();
                pro_origem = int.Parse(dt.Rows[0]["pro_origem"].ToString());
                pro_csosn = dt.Rows[0]["pro_csosn"].ToString();
                pro_cst = dt.Rows[0]["pro_cst"].ToString();
                pro_cest = dt.Rows[0]["pro_cest"].ToString();
                pro_porcentagemtributo = decimal.Parse(dt.Rows[0]["pro_porcentagemtributo"].ToString());
                pro_status = int.Parse(dt.Rows[0]["pro_status"].ToString());
                pro_unidade = dt.Rows[0]["pro_unidade"].ToString();
                pro_imagem = dt.Rows[0]["pro_imagem"] as byte[];
            }
            else
            {
                
            }

            return dt;
        }

        public int retornaIdCategoria(int idProduto)
        {
            DataTable dt = new DataTable();
            FBBanco fb = new FBBanco();
            if (fb.conecta())
            {
                fb.executeQuery(@"select * from produto where pro_id = @id", out dt, "@id", idProduto);
                fb.desconecta();
            }

            int cat_id = 0;
            if (dt.Rows.Count > 0)
            {
                int.TryParse(dt.Rows[0]["cat_id"].ToString(), out cat_id);
            }


            return cat_id;
        }

        public int retornaIdMarca(int idProduto)
        {
            DataTable dt = new DataTable();
            FBBanco fb = new FBBanco();
            if (fb.conecta())
            {
                fb.executeQuery(@"select * from produto where pro_id = @id", out dt, "@id", idProduto);
                fb.desconecta();
            }

            int idmarca = 0;
            if (dt.Rows.Count > 0)
            {
                int.TryParse(dt.Rows[0]["mar_id"].ToString(), out idmarca);
            }


            return idmarca;
        }


        public string retornaNCM(int idProduto)
        {
            DataTable dt = new DataTable();
            FBBanco fb = new FBBanco();
            if (fb.conecta())
            {
                fb.executeQuery(@"select * from produto where pro_id = @id", out dt, "@id", idProduto);
                fb.desconecta();
            }

            string ncm_ncm = "";
            if (dt.Rows.Count > 0)
            {
                ncm_ncm = dt.Rows[0]["pro_ncm"].ToString();
            }
            return ncm_ncm;
        }

        public string retornaAliquota(int idProduto)
        {
            DataTable dt = new DataTable();
            FBBanco fb = new FBBanco();
            if (fb.conecta())
            {
                fb.executeQuery(@"select * from produto where pro_id = @id", out dt, "@id", idProduto);
                fb.desconecta();
            }

            string aliquota = "";
            if (dt.Rows.Count > 0)
            {
                aliquota = dt.Rows[0]["pro_aliquota"].ToString();
            }
            return aliquota;
        }

        public DataTable pesquisarOrderQuantidade(string parametro, string campo)
        {
            DataTable dt = new DataTable();
            FBBanco fb = new FBBanco();
            if (fb.conecta())
            {


                    fb.executeQuery(@"select * from produto p 
                                  left join categoria c on c.cat_id = p.cat_id
                                  left join marca m on m.mar_id = p.mar_id
                                    where (UPPER(pro_" + campo + ") like UPPER(@parametro)) and p.pro_status=1 order by pro_quantidade",
                                 out dt, "@parametro", '%' + parametro + '%');


                fb.desconecta();
            }

            if (dt.Rows.Count > 0)
            {

                pro_id = int.Parse(dt.Rows[0]["pro_id"].ToString());
                pro_nome = dt.Rows[0]["pro_nome"].ToString();
                pro_descricao = dt.Rows[0]["pro_descricao"].ToString();
                pro_valor = decimal.Parse(dt.Rows[0]["pro_valor"].ToString());
                pro_codigo = dt.Rows[0]["pro_codigo"].ToString();
                cat_id = int.Parse(dt.Rows[0]["cat_id"].ToString());
                cat_nome = dt.Rows[0]["cat_nome"].ToString();
                pro_quantidade = 0;
                try { pro_quantidade = decimal.Parse(dt.Rows[0]["pro_quantidade"].ToString()); }
                catch { }
                pro_estoque = int.Parse(dt.Rows[0]["pro_estoque"].ToString());
                mar_id = int.Parse(dt.Rows[0]["mar_id"].ToString());
                mar_nome = dt.Rows[0]["mar_nome"].ToString();
                pro_ncm = dt.Rows[0]["pro_ncm"].ToString();
                pro_aliquota = decimal.Parse(dt.Rows[0]["pro_aliquota"].ToString());
                pro_cfop = dt.Rows[0]["pro_cfop"].ToString();
                pro_csosn = dt.Rows[0]["pro_csosn"].ToString();
                pro_cst = dt.Rows[0]["pro_cst"].ToString();
                pro_cest = dt.Rows[0]["pro_cest"].ToString();
                pro_porcentagemtributo = decimal.Parse(dt.Rows[0]["pro_porcentagemtributo"].ToString());
                pro_origem = int.Parse(dt.Rows[0]["pro_origem"].ToString());
                pro_status = int.Parse(dt.Rows[0]["pro_status"].ToString());
                pro_unidade = dt.Rows[0]["pro_unidade"].ToString();
                pro_imagem = dt.Rows[0]["pro_imagem"] as byte[];
            }


            return dt;
        }

        public DataTable pesquisar(string parametro, string campo)
        {
            DataTable dt = new DataTable();
            FBBanco fb = new FBBanco();
            if (fb.conecta())
            {

                if (campo.Trim() == "")
                {
                    fb.executeQuery(@"select * from produto p 
                                  left join categoria c on c.cat_id = p.cat_id
                                  left join marca m on m.mar_id = p.mar_id
                                    where (UPPER(pro_nome) like UPPER(@parametro) or UPPER(pro_codigo) like UPPER(@parametro) or UPPER(cat_nome) like UPPER(@parametro)) and p.pro_status=1 order by pro_nome",
                              out dt, "@parametro", '%' + parametro + '%');
                }
                else
                    fb.executeQuery(@"select * from produto p 
                                  left join categoria c on c.cat_id = p.cat_id
                                  left join marca m on m.mar_id = p.mar_id
                                    where (UPPER(pro_nome) like UPPER(@parametro) or UPPER(pro_codigo) like UPPER(@parametro) or UPPER(cat_nome) like UPPER(@parametro)) and p.pro_status=1 order by pro_nome",
                                 out dt, "@parametro", '%' + parametro + '%');


                fb.desconecta();
            }

            if (dt.Rows.Count > 0)
            {

                pro_id = int.Parse(dt.Rows[0]["pro_id"].ToString());
                pro_nome = dt.Rows[0]["pro_nome"].ToString();
                pro_descricao = dt.Rows[0]["pro_descricao"].ToString();
                pro_valor = decimal.Parse(dt.Rows[0]["pro_valor"].ToString());
                pro_codigo = dt.Rows[0]["pro_codigo"].ToString();
                cat_id = int.Parse(dt.Rows[0]["cat_id"].ToString());
                cat_nome = dt.Rows[0]["cat_nome"].ToString();
                pro_quantidade = 0;
                try { pro_quantidade = decimal.Parse(dt.Rows[0]["pro_quantidade"].ToString()); }
                catch { }
                pro_estoque = int.Parse(dt.Rows[0]["pro_estoque"].ToString());
                mar_id = int.Parse(dt.Rows[0]["mar_id"].ToString());
                mar_nome = dt.Rows[0]["mar_nome"].ToString();
                pro_ncm = dt.Rows[0]["pro_ncm"].ToString();
                pro_aliquota = decimal.Parse(dt.Rows[0]["pro_aliquota"].ToString());
                pro_cfop = dt.Rows[0]["pro_cfop"].ToString();
                pro_csosn = dt.Rows[0]["pro_csosn"].ToString();
                pro_cst = dt.Rows[0]["pro_cst"].ToString();
                pro_cest = dt.Rows[0]["pro_cest"].ToString();
                pro_porcentagemtributo = decimal.Parse(dt.Rows[0]["pro_porcentagemtributo"].ToString());
                pro_origem = int.Parse(dt.Rows[0]["pro_origem"].ToString());
                pro_status = int.Parse(dt.Rows[0]["pro_status"].ToString());
                pro_unidade = dt.Rows[0]["pro_unidade"].ToString();
                pro_imagem = dt.Rows[0]["pro_imagem"] as byte[];
            }


            return dt;
        }

        public DataTable pesquisarCodigo(string parametro, string campo)
        {
            DataTable dt = new DataTable();
            FBBanco fb = new FBBanco();
            if (fb.conecta())
            {

                if (campo.Trim() == "")
                {
                    fb.executeQuery(@" select * from produto p 
                                  left join categoria c on c.cat_id = p.cat_id
                                  left join marca m on m.mar_id = p.mar_id where UPPER(p.pro_codigo) = @parametro  and p.pro_status=1 order by p.pro_nome ",
                              out dt, "@parametro",  parametro );
                }
                else
                    fb.executeQuery(@"select * from produto p 
                                  left join categoria c on c.cat_id = p.cat_id
                                  left join marca m on m.mar_id = p.mar_id
                                    where  UPPER(pro_codigo) = UPPER(@parametro) and p.pro_status=1 order by pro_nome",
                                 out dt, "@parametro", '%' + parametro + '%');


                fb.desconecta();
            }

            if (dt.Rows.Count > 0)
            {

                pro_id = int.Parse(dt.Rows[0]["pro_id"].ToString());
                pro_nome = dt.Rows[0]["pro_nome"].ToString();
                pro_descricao = dt.Rows[0]["pro_descricao"].ToString();
                pro_valor = decimal.Parse(dt.Rows[0]["pro_valor"].ToString());
                pro_codigo = dt.Rows[0]["pro_codigo"].ToString();
                cat_id = int.Parse(dt.Rows[0]["cat_id"].ToString());
                cat_nome = dt.Rows[0]["cat_nome"].ToString();
                pro_quantidade = 0;
                try { pro_quantidade = decimal.Parse(dt.Rows[0]["pro_quantidade"].ToString()); }
                catch { }
                pro_estoque = int.Parse(dt.Rows[0]["pro_estoque"].ToString());
                mar_id = int.Parse(dt.Rows[0]["mar_id"].ToString());
                mar_nome = dt.Rows[0]["mar_nome"].ToString();
                pro_ncm = dt.Rows[0]["pro_ncm"].ToString();
                pro_aliquota = decimal.Parse(dt.Rows[0]["pro_aliquota"].ToString());
                pro_cfop = dt.Rows[0]["pro_cfop"].ToString();
                pro_csosn = dt.Rows[0]["pro_csosn"].ToString();
                pro_cst = dt.Rows[0]["pro_cst"].ToString();
                pro_cest = dt.Rows[0]["pro_cest"].ToString();
                pro_porcentagemtributo = decimal.Parse(dt.Rows[0]["pro_porcentagemtributo"].ToString());
                pro_origem = int.Parse(dt.Rows[0]["pro_origem"].ToString());
                pro_status = int.Parse(dt.Rows[0]["pro_status"].ToString());
                pro_unidade = dt.Rows[0]["pro_unidade"].ToString();
                pro_imagem = dt.Rows[0]["pro_imagem"] as byte[];
            }


            return dt;
        }

        public DataTable pesquisarCategoriaNome(string parametro, string campo)
        {
            DataTable dt = new DataTable();
            FBBanco fb = new FBBanco();
            if (fb.conecta())
            {


                    fb.executeQuery(@"select * from produto p 
                                  left join categoria c on c.cat_id = p.cat_id
                                  left join marca m on m.mar_id = p.mar_id
                                    where (UPPER(pro_nome) like UPPER(@parametro) or UPPER(pro_codigo) like UPPER(@parametro)) and p.pro_status=1 order by pro_nome",
                                 out dt, "@parametro", '%' + parametro + '%');


                fb.desconecta();
            }

            if (dt.Rows.Count > 0)
            {

                pro_id = int.Parse(dt.Rows[0]["pro_id"].ToString());
                pro_nome = dt.Rows[0]["pro_nome"].ToString();
                pro_descricao = dt.Rows[0]["pro_descricao"].ToString();
                pro_valor = decimal.Parse(dt.Rows[0]["pro_valor"].ToString());
                pro_codigo = dt.Rows[0]["pro_codigo"].ToString();
                cat_id = int.Parse(dt.Rows[0]["cat_id"].ToString());
                cat_nome = dt.Rows[0]["cat_nome"].ToString();
                pro_quantidade = 0;
                try { pro_quantidade = decimal.Parse(dt.Rows[0]["pro_quantidade"].ToString()); }
                catch { }
                pro_estoque = int.Parse(dt.Rows[0]["pro_estoque"].ToString());
                mar_id = int.Parse(dt.Rows[0]["mar_id"].ToString());
                mar_nome = dt.Rows[0]["mar_nome"].ToString();
                pro_ncm = dt.Rows[0]["pro_ncm"].ToString();
                pro_aliquota = decimal.Parse(dt.Rows[0]["pro_aliquota"].ToString());
                pro_cfop = dt.Rows[0]["pro_cfop"].ToString();
                pro_csosn = dt.Rows[0]["pro_csosn"].ToString();
                pro_cst = dt.Rows[0]["pro_cst"].ToString();
                pro_cest = dt.Rows[0]["pro_cest"].ToString();
                pro_porcentagemtributo = decimal.Parse(dt.Rows[0]["pro_porcentagemtributo"].ToString());
                pro_origem = int.Parse(dt.Rows[0]["pro_origem"].ToString());
                pro_status = int.Parse(dt.Rows[0]["pro_status"].ToString());
                pro_unidade = dt.Rows[0]["pro_unidade"].ToString();
                pro_imagem = dt.Rows[0]["pro_imagem"] as byte[];
            }


            return dt;
        }
    }
}
