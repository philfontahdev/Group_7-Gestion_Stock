using System;
using System.Windows.Forms;
using StockerBO;

namespace StockerWinforms
{
    static class Program
    {
        public static Utilisateur CurrentUser { get; set; }
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmLogin());
        }
    }
}
