using MGMPDV.Formularios;
using System;
using System.Windows.Forms;

namespace MGMPDV
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //FMGMPDV principal = new FMGMPDV();
            FEntrar entrar = new FEntrar();
            Application.Run(entrar);
            
            if (entrar.ok)
            {
                FAbrirCaixa caixa = new FAbrirCaixa(entrar.idusuario);
                Application.Run(caixa);
                if (caixa.ok)
                {
                    FPDV principal = new FPDV(entrar.idusuario, caixa.idcaixa, caixa.numerocaixa);
                    Application.Run(principal);
                    while (principal.login == true)
                    {

                        principal = new FPDV(entrar.idusuario, caixa.idcaixa, caixa.numerocaixa);
                        Application.Run(principal);

                
                    }
                }
            }

        }
    }
}
