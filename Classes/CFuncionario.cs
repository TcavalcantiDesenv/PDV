using Classes.FBBanco;
using System;
using System.Data;

namespace MGMPDV
{
    class CFuncionario
    {

        public int      fun_id              { get; set; }
        public int      cid_id              { get; set; }
        public string   fun_nome            { get; set; }
        public string   fun_rg              { get; set; }
        public string   fun_cpf             { get; set; }
        public string   fun_sexo            { get; set; }
        public DateTime fun_dtnascimento    { get; set; }
        public string   fun_endereco        { get; set; }
        public string   fun_numero          { get; set; }
        public string   fun_bairro          { get; set; }
        public string   fun_cep             { get; set; }
        public string   fun_ddd1            { get; set; }
        public string   fun_ddd2            { get; set; }
        public string   fun_ddd3            { get; set; }
        public string   fun_telefone1       { get; set; }
        public string   fun_telefone2       { get; set; }
        public string   fun_telefone3       { get; set; }
        public string   fun_informacao      { get; set; }
        public string   fun_email           { get; set; }
        public string   fun_usuario         { get; set; }
        public string   fun_senha           { get; set; }
        public string   fun_nivel           { get; set; }
        public int      fun_status          { get; set; }    
       
        public CFuncionario()
        {

        }

        public void inserir()
        {
            FBBanco fb = new FBBanco();

            if (fb.conecta())
            {
                fb.executeNonQuery(@"insert into funcionario(
                                    cid_id,          
                                    fun_nome,        
                                    fun_rg,       
                                    fun_cpf,         
                                    fun_sexo,       
                                    fun_dtnascimento,
                                    fun_endereco,    
                                    fun_numero,      
                                    fun_bairro,             
                                    fun_cep,  
                                    fun_ddd1,   
                                    fun_ddd2,   
                                    fun_ddd3,          
                                    fun_telefone1,   
                                    fun_telefone2,   
                                    fun_telefone3,   
                                    fun_informacao,
                                    fun_email,  
                                    fun_usuario,     
                                    fun_senha,       
                                    fun_nivel,       
                                    fun_status

                    ) values (
                                    @cid_id,          
                                    @fun_nome,        
                                    @fun_rg,       
                                    @fun_cpf,         
                                    @fun_sexo,       
                                    @fun_dtnascimento,
                                    @fun_endereco,    
                                    @fun_numero,      
                                    @fun_bairro,             
                                    @fun_cep,        
                                    @fun_ddd1,   
                                    @fun_ddd2,   
                                    @fun_ddd3,    
                                    @fun_telefone1,   
                                    @fun_telefone2,   
                                    @fun_telefone3,   
                                    @fun_informacao, 
                                    @fun_email, 
                                    @fun_usuario,     
                                    @fun_senha,       
                                    @fun_nivel,    
                                    @fun_status
                    )",
                                    "@cid_id",          cid_id,          
                                    "@fun_nome",        fun_nome,        
                                    "@fun_rg",          fun_rg,       
                                    "@fun_cpf",         fun_cpf,         
                                    "@fun_sexo",        fun_sexo,       
                                    "@fun_dtnascimento",fun_dtnascimento,
                                    "@fun_endereco",    fun_endereco,    
                                    "@fun_numero",      fun_numero,      
                                    "@fun_bairro",      fun_bairro,      
                                    "@fun_cep",         fun_cep,
                                    "@fun_ddd1",   fun_ddd1,
                                    "@fun_ddd2",   fun_ddd2,
                                    "@fun_ddd3",   fun_ddd3,   
                                    "@fun_telefone1",   fun_telefone1,   
                                    "@fun_telefone2",   fun_telefone2,   
                                    "@fun_telefone3",   fun_telefone3,   
                                    "@fun_informacao",  fun_informacao,
                                    "@fun_email",       fun_email,
                                    "@fun_usuario",     fun_usuario,     
                                    "@fun_senha",       fun_senha,       
                                    "@fun_nivel",       fun_nivel,  
                                    "@fun_status",      fun_status
                    );
                fb.desconecta();
        
            }
        }

        public void atualizar(int id)
        {
            FBBanco fb = new FBBanco();
            if (fb.conecta())
            {

                fb.executeNonQuery(@"update funcionario set
                                       
                                    cid_id=              @cid_id,          
                                    fun_nome=            @fun_nome,        
                                    fun_rg=              @fun_rg,       
                                    fun_cpf=             @fun_cpf,         
                                    fun_sexo=            @fun_sexo,       
                                    fun_dtnascimento=    @fun_dtnascimento,
                                    fun_endereco=        @fun_endereco,    
                                    fun_numero=          @fun_numero,      
                                    fun_bairro=          @fun_bairro,      
                                    fun_cep=             @fun_cep, 
                                    fun_ddd1=       @fun_ddd1,   
                                    fun_ddd2=       @fun_ddd2,   
                                    fun_ddd3=       @fun_ddd3,          
                                    fun_telefone1=       @fun_telefone1,   
                                    fun_telefone2=       @fun_telefone2,   
                                    fun_telefone3=       @fun_telefone3,   
                                    fun_informacao=      @fun_informacao, 
                                    fun_email=           @fun_email, 
                                    fun_usuario=         @fun_usuario,     
                                    fun_senha=           @fun_senha,       
                                    fun_nivel=           @fun_nivel,
                                    fun_status=          @fun_status
                                    where fun_id=@fun_id
                                ",

                                   "@cid_id", cid_id,
                                   "@fun_nome", fun_nome,
                                   "@fun_rg", fun_rg,
                                   "@fun_cpf", fun_cpf,
                                   "@fun_sexo", fun_sexo,
                                   "@fun_dtnascimento", fun_dtnascimento,
                                   "@fun_endereco", fun_endereco,
                                   "@fun_numero", fun_numero,
                                   "@fun_bairro", fun_bairro,
                                   "@fun_cep", fun_cep,
                                   "@fun_ddd1", fun_ddd1,
                                   "@fun_ddd2", fun_ddd2,
                                   "@fun_ddd3", fun_ddd3,
                                   "@fun_telefone1", fun_telefone1,
                                   "@fun_telefone2", fun_telefone2,
                                   "@fun_telefone3", fun_telefone3,
                                   "@fun_informacao", fun_informacao,
                                   "@fun_email", fun_email,
                                   "@fun_usuario", fun_usuario,
                                   "@fun_senha", fun_senha,
                                   "@fun_nivel", fun_nivel,
                                   "@fun_status", fun_status,
                                   "@fun_id", id
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
                ok=fb.executeNonQuery("delete from funcionario where fun_id = @fun_id", "@fun_id", id);
                fb.desconecta();

            }
            return ok;
        }

        public DataTable pesquisar(string parametro, string campo)
        {
            DataTable dt = new DataTable();
            FBBanco fb = new FBBanco();
            if (fb.conecta())
            {
                fb.executeQuery("select * from funcionario f left join cidade c on c.cid_id=f.cid_id where UPPER(fun_" + campo + ") like UPPER(@parametro) order by fun_nome",
                                 out dt, "@parametro", '%'+parametro+'%');
                fb.desconecta();
            }

            return dt;
        }

        public DataTable pesquisarID(int id)
        {
            DataTable dt = new DataTable();
            FBBanco fb = new FBBanco();
            if (fb.conecta())
            {
                fb.executeQuery(@"select * from funcionario f left join cidade c on c.cid_id=f.cid_id 
                            where fun_id=@idfuncionario",
                                 out dt, "@idfuncionario", id);
                fb.desconecta();
            }

            if (dt.Rows.Count>0)
            {
                fun_id = int.Parse(dt.Rows[0]["fun_id"].ToString());
                fun_nome = dt.Rows[0]["fun_nome"].ToString();
            }
            return dt;
        }

        public DataTable pesquisarExiste(string parametro, string campo)
        {
            DataTable dt = new DataTable();
            FBBanco fb = new FBBanco();
            if (fb.conecta())
            {
                fb.executeQuery("select * from funcionario f left join cidade c on c.cid_id=f.cid_id where UPPER(fun_" + campo + ") = UPPER(@parametro) order by fun_nome",
                                 out dt, "@parametro", parametro);
                fb.desconecta();
            }

            return dt;
        }

        public DataTable entrar(string usuario, string senha)
        {
            DataTable dt = new DataTable();
            FBBanco fb = new FBBanco();
            if (fb.conecta())
            {
                fb.executeQuery("select * from funcionario f left join cidade c on c.cid_id=f.cid_id where fun_usuario=@usuario and fun_senha = @senha",
                                 out dt, "@usuario", usuario, "@senha", senha);
                fb.desconecta();
            }

            return dt;
        }
    }
}
