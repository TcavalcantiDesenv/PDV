using System;
using Classes.FBBanco;
using System.Data;

namespace MGMPDV
{
    class CCliente
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string sexo { get; set; }
        public string rg { get; set; }
        public string cpf { get; set; }
        public DateTime dtnascimento { get; set; }
        public string endereco { get; set; }
        public string numero { get; set; }
        public string bairro { get; set; }
        public int cid_id { get; set; }
        public string cep { get; set; }
        public string telefone1 { get; set; }
        public string telefone2 { get; set; }
        public string telefone3 { get; set; }
        public string ddd1 { get; set; }
        public string ddd2 { get; set; }
        public string ddd3 { get; set; }
        public string informacao { get; set; }
        public string email { get; set; }

        public string cid_nome { get; set; }
        public string cid_uf { get; set; }
       
        public CCliente()
        {

        }



        public void inserircliente()
        {
            FBBanco fb = new FBBanco();

            if (fb.conecta())
            {
                fb.executeNonQuery(@"insert into cliente(
                    cli_nome,cli_sexo,cli_rg,cli_cpf,cli_dtnascimento,
                    cli_endereco,cli_numero,cli_bairro,
                    cid_id,cli_cep,cli_ddd1,cli_ddd2,cli_ddd3,cli_telefone1,
                    cli_telefone2,cli_telefone3,cli_informacao,cli_email
                    ) values (
                    @cli_nome,@cli_sexo,@cli_rg,@cli_cpf,@cli_dtnascimento,
                    @cli_endereco,@cli_numero,@cli_bairro,
                    @cid_id,@cli_cep,@cli_ddd1,@cli_ddd2,@cli_ddd3,@cli_telefone1,
                    @cli_telefone2,@cli_telefone3,@cli_informacao,@cli_email
                    )",
                    "@cli_nome", nome, "@cli_sexo", sexo, "@cli_rg", rg, "@cli_cpf", cpf, "@cli_dtnascimento", dtnascimento,
                    "@cli_endereco", endereco, "@cli_numero", numero, "@cli_bairro", bairro,
                    "@cid_id", cid_id, "@cli_cep", cep, "@cli_ddd1", ddd1, "@cli_ddd2", ddd2, "@cli_ddd3", ddd3, "@cli_telefone1", telefone1,
                    "@cli_telefone2", telefone2, "@cli_telefone3", telefone3, "@cli_informacao", informacao, "@cli_email", email
                    );
                fb.desconecta();
        
            }
        }

        public void atualizarcliente(int id)
        {
            FBBanco fb = new FBBanco();
            if (fb.conecta())
            {

                fb.executeNonQuery(@"update cliente set
                                cli_nome=@cli_nome, cli_sexo=@cli_sexo, cli_rg=@cli_rg,cli_cpf=@cli_cpf,cli_dtnascimento=@cli_dtnascimento,
                                cli_endereco=@cli_endereco,cli_numero=@cli_numero,cli_bairro=@cli_bairro,
                                cid_id=@cid_id,cli_cep=@cli_cep, cli_ddd1=@cli_ddd1, cli_ddd2=@cli_ddd2, cli_ddd3=@cli_ddd3, cli_telefone1=@cli_telefone1,
                                cli_telefone2=@cli_telefone2,cli_telefone3=@cli_telefone3,cli_informacao=@cli_informacao,
                                cli_email = @cli_email where cli_id=@cli_id"
                                ,
                                "@cli_nome", nome, "@cli_sexo", sexo, "@cli_rg", rg, "@cli_cpf", cpf, "@cli_dtnascimento", dtnascimento,
                                "@cli_endereco", endereco, "@cli_numero", numero, "@cli_bairro", bairro,
                                "@cid_id", cid_id, "@cli_cep", cep, "@cli_ddd1", ddd1, "@cli_ddd2", ddd2, "@cli_ddd3", ddd3,"@cli_telefone1", telefone1,
                                "@cli_telefone2", telefone2, "@cli_telefone3", telefone3, "@cli_informacao", informacao,
                                "@cli_email", email, "@cli_id", id
                                );
                fb.desconecta();
            }        
        }

        public bool excluircliente(int id)
        {
            bool ok = false;
            FBBanco fb = new FBBanco();
            if (fb.conecta())
            {
                ok=fb.executeNonQuery("delete from cliente where cli_id = @cli_id", "@cli_id", id);
                fb.desconecta();

            }
            return ok;
        }
        public DataTable pesquisarAniversarioDia(string dia, string mes)
        {
            DataTable dt = new DataTable();
            FBBanco fb = new FBBanco();
            if (fb.conecta())
            { //extract(DAY from current_date)
                fb.executeQuery(@"select c.*,cid.*
                from cliente c left join cidade cid on cid.cid_id=c.cid_id 
                where 
                        (extract(DAY from cli_dtnascimento) = @diai) and (extract(MONTH from cli_dtnascimento) = @mesi)
                        order by cli_dtnascimento,cli_nome",
                                 out dt, "@diai", dia, "@mesi", mes);
                fb.desconecta();
            }

            if (dt.Rows.Count > 0)
            {
                id = int.Parse(dt.Rows[0]["cli_id"].ToString());
                nome = dt.Rows[0]["cli_nome"].ToString();
                endereco = dt.Rows[0]["cli_endereco"].ToString();
                numero = dt.Rows[0]["cli_numero"].ToString();
                bairro = dt.Rows[0]["cli_bairro"].ToString();
                telefone1 = dt.Rows[0]["cli_telefone1"].ToString();
                telefone2 = dt.Rows[0]["cli_telefone2"].ToString();
                telefone3 = dt.Rows[0]["cli_telefone3"].ToString();
                ddd1 = dt.Rows[0]["cli_ddd1"].ToString();
                ddd2 = dt.Rows[0]["cli_ddd2"].ToString();
                ddd3 = dt.Rows[0]["cli_ddd3"].ToString();
                cpf = dt.Rows[0]["cli_cpf"].ToString();
                cid_nome = dt.Rows[0]["cid_nome"].ToString();
                cid_uf = dt.Rows[0]["cid_uf"].ToString();
                dtnascimento = DateTime.Parse(dt.Rows[0]["cli_dtnascimento"].ToString());
            }
            return dt;
        }

        public DataTable pesquisarAniversarioMes(string mes)
        {
            DataTable dt = new DataTable();
            FBBanco fb = new FBBanco();
            if (fb.conecta())
            { //extract(DAY from current_date)
                fb.executeQuery(@"select c.*,cid.*
                from cliente c left join cidade cid on cid.cid_id=c.cid_id 
                where 
                        (extract(MONTH from cli_dtnascimento) = @mesi)
                        order by cli_dtnascimento,cli_nome",
                                 out dt, "@mesi", mes);
                fb.desconecta();
            }

            if (dt.Rows.Count > 0)
            {
                id = int.Parse(dt.Rows[0]["cli_id"].ToString());
                nome = dt.Rows[0]["cli_nome"].ToString();
                endereco = dt.Rows[0]["cli_endereco"].ToString();
                numero = dt.Rows[0]["cli_numero"].ToString();
                bairro = dt.Rows[0]["cli_bairro"].ToString();
                telefone1 = dt.Rows[0]["cli_telefone1"].ToString();
                telefone2 = dt.Rows[0]["cli_telefone2"].ToString();
                telefone3 = dt.Rows[0]["cli_telefone3"].ToString();
                ddd1 = dt.Rows[0]["cli_ddd1"].ToString();
                ddd2 = dt.Rows[0]["cli_ddd2"].ToString();
                ddd3 = dt.Rows[0]["cli_ddd3"].ToString();
                cpf = dt.Rows[0]["cli_cpf"].ToString();
                cid_nome = dt.Rows[0]["cid_nome"].ToString();
                cid_uf = dt.Rows[0]["cid_uf"].ToString();
                dtnascimento = DateTime.Parse(dt.Rows[0]["cli_dtnascimento"].ToString());
            }
            return dt;
        }
        public DataTable pesquisarID(int idcliente)
        {
            DataTable dt = new DataTable();
            FBBanco fb = new FBBanco();
            if (fb.conecta())
            {
                fb.executeQuery("select * from cliente c left join cidade cid on cid.cid_id=c.cid_id where cli_id=@idcliente order by cli_nome",
                                 out dt, "@idcliente", idcliente);
                fb.desconecta();
            }

            id = 0;
            if (dt.Rows.Count > 0)
            {
                id = int.Parse(dt.Rows[0]["cli_id"].ToString());
                nome = dt.Rows[0]["cli_nome"].ToString();
                endereco = dt.Rows[0]["cli_endereco"].ToString();
                numero =dt.Rows[0]["cli_numero"].ToString();
                bairro = dt.Rows[0]["cli_bairro"].ToString();
                telefone1 = dt.Rows[0]["cli_telefone1"].ToString();
                telefone2 = dt.Rows[0]["cli_telefone2"].ToString();
                telefone3 = dt.Rows[0]["cli_telefone3"].ToString();
                ddd1 = dt.Rows[0]["cli_ddd1"].ToString();
                ddd2 = dt.Rows[0]["cli_ddd2"].ToString();
                ddd3= dt.Rows[0]["cli_ddd3"].ToString();
                cpf = dt.Rows[0]["cli_cpf"].ToString();
                cid_nome = dt.Rows[0]["cid_nome"].ToString();
                cid_uf = dt.Rows[0]["cid_uf"].ToString();
                dtnascimento = DateTime.Parse(dt.Rows[0]["cli_dtnascimento"].ToString());
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

        public DataTable buscarTelefone(string numero)
        {
            DataTable dt = new DataTable();
            FBBanco fb = new FBBanco();
            if (fb.conecta())
            {
        
                fb.executeQuery(@"select * from cliente c 
                                left join cidade cid on cid.cid_id=c.cid_id 
                                where 
                                cli_ddd1||cli_telefone1=@numero or
                                cli_ddd2||cli_telefone2=@numero or
                                cli_ddd3||cli_telefone3=@numero 
                                order by cli_nome",
                                 out dt, "@numero", numero);
                fb.desconecta();
            }

            mostrar(dt);
            return dt;
        }

        private DataTable mostrar(DataTable dt)
        {
            id = 0;
            if (dt.Rows.Count > 0)
            {

                id = int.Parse(dt.Rows[0]["cli_id"].ToString());
                nome = dt.Rows[0]["cli_nome"].ToString();
                endereco = dt.Rows[0]["cli_endereco"].ToString();
                this.numero = dt.Rows[0]["cli_numero"].ToString();
                bairro = dt.Rows[0]["cli_bairro"].ToString();
                telefone1 = dt.Rows[0]["cli_telefone1"].ToString();
                telefone2 = dt.Rows[0]["cli_telefone2"].ToString();
                telefone3 = dt.Rows[0]["cli_telefone3"].ToString();
                ddd1 = dt.Rows[0]["cli_ddd1"].ToString();
                ddd2 = dt.Rows[0]["cli_ddd2"].ToString();
                ddd3 = dt.Rows[0]["cli_ddd3"].ToString();
            }
            return dt;
        }

        public DataTable pesquisar(string parametro, string campo)
        {
            DataTable dt = new DataTable();
            FBBanco fb = new FBBanco();
            if (fb.conecta())
            {
                fb.executeQuery(@"select * from cliente c left join cidade cid on cid.cid_id=c.cid_id where 
                                    UPPER(cli_nome) like UPPER(@parametro) or
                                    UPPER(cli_endereco) like UPPER(@parametro)
                                    order by cli_nome",
                                 out dt, "@parametro", '%'+parametro+'%');
                fb.desconecta();
            }

             dt = mostrar(dt);
            return dt;
        }
        public DataTable pesquisarcpf(string parametro)
        {
            DataTable dt = new DataTable();
            FBBanco fb = new FBBanco();
            if (fb.conecta())
            {
                fb.executeQuery(@"select * from cliente c left join cidade cid on cid.cid_id=c.cid_id where 
                                    cli_cpf=@parametro
                                    order by cli_nome",
                                 out dt, "@parametro", parametro);
                fb.desconecta();
            }

            dt = mostrar(dt);
            return dt;
        }

        public DataTable pesquisarTelefone(string ddd,string telefone)
        {
            DataTable dt = new DataTable();
            FBBanco fb = new FBBanco();
            if (fb.conecta())
            {
                fb.executeQuery(@"select * from cliente c left join cidade cid on cid.cid_id=c.cid_id where 
                                    (cli_ddd1 = @ddd and cli_telefone1=@telefone) or
                                    (cli_ddd2 = @ddd and cli_telefone2=@telefone) or
                                    (cli_ddd3 = @ddd and cli_telefone3=@telefone)
                                    order by cli_nome",
                                 out dt, "@ddd", ddd, "@telefone", telefone);
                fb.desconecta();
            }

            dt = mostrar(dt);
            return dt;
        }
    }
}
