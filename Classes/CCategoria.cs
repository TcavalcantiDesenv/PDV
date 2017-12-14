using Classes.FBBanco;
using System.Data;

namespace MGMPDV
{
    class CCategoria
    {
        public int id { get; set; }
        public string nome { get; set; }

        public CCategoria()
        {

        }

        public void inserirCategoria()
        {
            FBBanco fb = new FBBanco();

            if (fb.conecta())
            {
                fb.executeNonQuery(@"insert into Categoria(
                    cat_nome
                    ) values (
                    @cat_nome
                    )",
                    "@cat_nome", nome
                    );
                fb.desconecta();

            }
        }

        public void atualizarCategoria(int id)
        {
            FBBanco fb = new FBBanco();
            if (fb.conecta())
            {

                fb.executeNonQuery(@"update Categoria set
                                cat_nome=@cat_nome where cat_id=@cat_id"
                                ,
                                "@cat_nome", nome, "@cat_id", id
                                );
                fb.desconecta();
            }
        }

        public bool excluirCategoria(int id)
        {
            bool ok = false;
            FBBanco fb = new FBBanco();
            if (fb.conecta())
            {
                ok=fb.executeNonQuery("delete from Categoria where cat_id = @cat_id", "@cat_id", id);
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
                fb.executeQuery("select * from Categoria where UPPER(cat_" + campo + ") like UPPER(@parametro) order by cat_nome",
                                 out dt, "@parametro", '%' + parametro + '%');
                fb.desconecta();
            }

            return dt;
        }
    }
}
