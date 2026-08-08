using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMD
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


            Acesso Acesso = new Acesso();
            Acesso.ShowDialog();
            if (Acesso.logado)
            {
                if (Acesso.permissao)
                {
                    Application.Run(new Desktop_AMD.FRMdesktop_AMD_user_admin());                 
                }
                else
                {
                    Termo.FRMTermo frm = new Termo.FRMTermo();
                    frm.ShowDialog();
                }
            }
        }
    }
}
