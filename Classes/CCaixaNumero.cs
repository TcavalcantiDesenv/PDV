using System.Data;
using Classes.FBBanco;

namespace MGMPDV
{
    class CCaixaNumero
    {
        public CCaixaNumero()
        {  }

        public void inserir(int numero)
        { 
            DataTable dt = new DataTable();
            FBBanco fb = new FBBanco();
            if (fb.conecta())
            {
                fb.executeNonQuery(@"insert into caixanumero(
                    cai_numero
                    ) values (
                    @cai_numero
                    )",
                    "@cai_numero", numero
                );
                fb.desconecta();
        
            }
        }

        public void remover(int numero)
        {
            DataTable dt = new DataTable();
            FBBanco fb = new FBBanco();
            if (fb.conecta())
            {
                fb.executeNonQuery(@"delete from caixanumero
                    where cai_numero = @cai_numero",
                    "@cai_numero", numero
                );
                fb.desconecta();

            }
        }

        public bool pesquisarNumero(int numero)
        {
            DataTable dt = new DataTable();
            FBBanco fb = new FBBanco();
            if (fb.conecta())
            {
                fb.executeQuery(@"select * from caixanumero
                    where cai_numero = @cai_numero", out dt,
                    "@cai_numero", numero
                );
                fb.desconecta();

            }

            bool ok = false;
            if(dt.Rows.Count>0)
            { ok = true; }

            return ok;
        }

        public DataTable carregar()
        {
            DataTable dt = new DataTable();
            FBBanco fb = new FBBanco();
            if (fb.conecta())
            {
                fb.executeQuery(@"select * from caixanumero order by cai_numero
                                ", out dt
                );
                fb.desconecta();

            }
            return dt;

        }

    }
}
