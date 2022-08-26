using Projet_Fin_classe_HOPITAL.Admin_Forms;
using Projet_Fin_classe_HOPITAL.Agent_Form;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_Fin_classe_HOPITAL
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
            Application.Run(new Login() );
            
        }
    }
}
