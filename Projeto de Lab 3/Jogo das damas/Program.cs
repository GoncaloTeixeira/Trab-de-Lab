using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_das_damas
{
    static class Program
    {
        
        public static ViewLogin V_Login { get; private set; }
        public static ViewMenu V_Menu { get; private set; }
        public static ViewRegisto V_Registo { get; private set; }
        public static ViewRegras V_Regras { get; private set; }

        public static ModelJogo M_Jogo { get; private set; }
        public static ViewJogo V_Jogo { get; private set; }
        public static ControllerJogo C_Jogo { get; private set; }
       

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

           


            V_Login = new ViewLogin();
            V_Menu = new ViewMenu();
            V_Registo = new ViewRegisto();
            V_Regras = new ViewRegras();

            M_Jogo = new ModelJogo();
            V_Jogo = new ViewJogo();
            C_Jogo = new ControllerJogo();


            Application.Run(V_Login);
        }
    }
}
