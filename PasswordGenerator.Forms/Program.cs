using PasswordGenerator.Forms.Views;
using System;
using System.Windows.Forms;

namespace PasswordGenerator.Forms
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PasswordGeneratorView());
        }
    }
}
