using Classes.FBBanco;
using System.Data;

namespace MGMPDV
{
    class CCidade
    {

        public int id { get; set; }
        public string nome { get; set; }
        public string uf { get; set; }
       
        public CCidade()
        {

        }

        public void inserir()
        {
            FBBanco fb = new FBBanco();

            if (fb.conecta())
            {
                fb.executeNonQuery(@"insert into Cidade(
                    cid_nome,cid_uf
                    ) values (
                    @cid_nome,@cid_uf
                    )",
                    "@cid_nome", nome, "@cid_uf", uf
                    );
                fb.desconecta();
        
            }
        }

        public void atualizar(int id)
        {
            FBBanco fb = new FBBanco();
            if (fb.conecta())
            {

                fb.executeNonQuery(@"update Cidade set
                                cid_nome=@cid_nome,cid_uf=@cid_uf where cid_id=@cid_id"
                                ,
                                "@cid_nome", nome, "@cid_uf", uf, "@cid_id", id
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
                ok=fb.executeNonQuery("delete from Cidade where cid_id = @cid_id", "@cid_id", id);
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
                fb.executeQuery("select * from Cidade where UPPER(cid_" + campo + ") like UPPER(@parametro) order by cid_nome",
                                 out dt, "@parametro", '%'+parametro+'%');
                fb.desconecta();
            }

            return dt;
        }
    }
}
