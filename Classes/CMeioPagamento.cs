using Classes.FBBanco;
using System.Data;

namespace MGMPDV.Classes
{
    class CMeioPagamento
    {

        public CMeioPagamento()
        {

        }

        public DataTable carregar()
        {
            DataTable dt = new DataTable();
            FBBanco fb = new FBBanco();
            if (fb.conecta())
            {
                fb.executeQuery(@"
                                  select * from meiopagamento order by mei_id;
                                "
                    , out dt);
                fb.desconecta();
            }

            return dt;
        }

    }
}
