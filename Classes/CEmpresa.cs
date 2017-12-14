using Classes.FBBanco;
using System.Data;

namespace MGMPDV
{
    class CEmpresa
    {
        public int      emp_id          { get; set; }
        public string   emp_cnpj        { get; set; }
        public string   emp_razao       { get; set; } 
        public string   emp_fantasia    { get; set; }
        public string   emp_telefone1   { get; set; }
        public string   emp_telefone2   { get; set; }
        public string   emp_telefone3   { get; set; }
        public string   emp_endereco    { get; set; }
        public string   emp_numero      { get; set; }
        public string   emp_bairro      { get; set; }
        public string   emp_cidade      { get; set; }
        public string   emp_uf          { get; set; }
        public string   emp_email       { get; set; }
        public string   emp_site        { get; set; }
        public string   emp_logo        { get; set; }
        public string   emp_cep         { get; set; }
        public string emp_ie { get; set; }
        public string emp_im { get; set; }

        public CEmpresa()
        {

        }

        public DataTable carregar()
        {
            DataTable dt = new DataTable();
            FBBanco fb = new FBBanco();
            if (fb.conecta())
            {
                fb.executeQuery("select * from Empresa",
                                 out dt);
                fb.desconecta();
            }
            return dt;
        }

        public void atualizar()
        {
            FBBanco fb = new FBBanco();
            if (fb.conecta())
            {
                DataTable dt = carregar();
                if (dt.Rows.Count<=0)
                {
                    fb.executeNonQuery(@"insert into empresa(emp_id) values(1)");
                }
                fb.executeNonQuery(@"update Empresa set
                                emp_id          = @emp_id,
                                emp_cnpj        = @emp_cnpj,
                                emp_razao       = @emp_razao,
                                emp_fantasia    = @emp_fantasia,
                                emp_telefone1   = @emp_telefone1,
                                emp_telefone2   = @emp_telefone2,
                                emp_telefone3   = @emp_telefone3,
                                emp_endereco    = @emp_endereco,
                                emp_numero      = @emp_numero,
                                emp_bairro      = @emp_bairro,
                                emp_cidade      = @emp_cidade,
                                emp_uf          = @emp_uf,
                                emp_email       = @emp_email,
                                emp_site        = @emp_site,
                                emp_logo        = @emp_logo,
                                emp_cep         = @emp_cep,
                                emp_ie          = @emp_ie,
                                emp_im          = @emp_im
                                "
                                ,
                                "@emp_id",1,
                                "@emp_cnpj",emp_cnpj,
                                "@emp_razao",emp_razao,
                                "@emp_fantasia",emp_fantasia,
                                "@emp_telefone1",emp_telefone1,
                                "@emp_telefone2",emp_telefone2,
                                "@emp_telefone3",emp_telefone3,
                                "@emp_endereco",emp_endereco,
                                "@emp_numero",emp_numero,
                                "@emp_bairro",emp_bairro,
                                "@emp_cidade",emp_cidade,
                                "@emp_uf",emp_uf,
                                "@emp_email",emp_email,
                                "@emp_site",emp_site,
                                "@emp_logo",emp_logo,
                                "@emp_cep",emp_cep,
                                "@emp_ie", emp_ie,
                                "@emp_im", emp_im
                                );
                fb.desconecta();
            }        
        }


        public DataTable pesquisar()
        {
            DataTable dt = new DataTable();
            FBBanco fb = new FBBanco();
            if (fb.conecta())
            {
                fb.executeQuery("select * from Empresa",
                                 out dt);
                fb.desconecta();
            }

            emp_id = 0;
            if (dt.Rows.Count>0)
            {
                
                emp_id          = int.Parse(dt.Rows[0]["emp_id"].ToString());
                emp_cnpj        = dt.Rows[0]["emp_cnpj"].ToString();
                emp_razao       = dt.Rows[0]["emp_razao"].ToString();
                emp_fantasia    = dt.Rows[0]["emp_fantasia"].ToString();
                
                emp_telefone1   = dt.Rows[0]["emp_telefone1"].ToString();
                emp_telefone2   = dt.Rows[0]["emp_telefone2"].ToString();
                emp_telefone3   = dt.Rows[0]["emp_telefone3"].ToString();
                emp_endereco    = dt.Rows[0]["emp_endereco"].ToString();
                emp_numero      = dt.Rows[0]["emp_numero"].ToString();
                emp_bairro      = dt.Rows[0]["emp_bairro"].ToString();
                emp_cidade      = dt.Rows[0]["emp_cidade"].ToString();
                emp_uf          = dt.Rows[0]["emp_uf"].ToString();
                emp_email       = dt.Rows[0]["emp_email"].ToString();
                emp_site        = dt.Rows[0]["emp_site"].ToString();
                emp_logo        = dt.Rows[0]["emp_logo"].ToString();
                emp_cep         = dt.Rows[0]["emp_cep"].ToString();
                emp_ie = dt.Rows[0]["emp_ie"].ToString();
                emp_im = dt.Rows[0]["emp_im"].ToString();
            }
            return dt;
        }
    }
}
