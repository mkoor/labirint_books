using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labirint_Project
{
    public struct User
    {
        public string login;
        public string password;
    }

    static class Program
    {
        public static LabirintEntities1 lab = new LabirintEntities1();
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Labirint());
        }
    }
}
