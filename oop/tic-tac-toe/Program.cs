using System;
using System.Windows.Forms;
using tic_tac_toe.DataBase;
using tic_tac_toe.Forms;

namespace tic_tac_toe
{
  static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Включаю визуальные стили для приложения Windows Forms
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            Application.Run(new InitializeForm());
        }
    }
}