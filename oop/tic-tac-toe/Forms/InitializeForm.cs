using System.Windows.Forms;
using tic_tac_toe.Initialize;
using tic_tac_toe.PackageForGame;
using tic_tac_toe.PackageForPlayers;
using tic_tac_toe.Services;

namespace tic_tac_toe.Forms
{
    public partial class InitializeForm : Form
    {
        
        public static InitializeObjects InitializeObjects { get; private set; }

        // Конструктор формы
        public InitializeForm()
        {
            InitializeComponent();
            
            InitializeObjects = new InitializeObjects();
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            var logOrRegForm = new LogOrRegForm();
            logOrRegForm.Show();
            
            // Скрытие текущей формы
            Hide();
        }

        private void InitializeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Закрытие формы
            Close();
        }
    }
}