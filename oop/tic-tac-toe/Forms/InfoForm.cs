using System.Linq;
using System.Windows.Forms;
using tic_tac_toe.Enums;
using tic_tac_toe.PackageForGame;
using tic_tac_toe.PackageForPlayers;

namespace tic_tac_toe.Forms
{
    
    public partial class InfoForm : Form
    {
        // Храненю информацию о текущем пользователе
        private Account Player { get; }

        // Конструктор формы
        public InfoForm(Account player)
        {
            // Инициализация свойства Player переданным в конструкторе пользователем
            Player = player;
            
            // Инициализация компонентов формы (генерируется мной)
            InitializeComponent();

            // Заполнение информации на форме при ее создании
            ChangeInfo(firstNameText, player.FirstName);
            ChangeInfo(lastNameText, player.LastName);
            ChangeInfo(typeAccountText, player.TypeAccount.ToString());
            ChangeInfo(usernameText, player.UserName);
            ChangeInfo(ratingText, player.CurrentRating.ToString());
            ChangeInfo(gamesLemgthText, player.Results.Count.ToString());
            ChangeInfo(gamesLemgthWinText, player.Results.Count(x => x.Outcome == GameOutcome.WIN).ToString());
            ChangeInfo(gamesLemgthLoseText, player.Results.Count(x => x.Outcome == GameOutcome.LOSE).ToString());
            ChangeInfo(gamesLemgthTieText, player.Results.Count(x => x.Outcome == GameOutcome.TIE).ToString());
        }

        private static void ChangeInfo(Control label, string text)
        {
            // Разбиваем текущий текст элемента управления по двоеточию
            var arr = label.Text.Split(':');
            
            // Заменяем вторую часть текста на переданный текст и устанавливаем новый текст
            label.Text = arr[0] + @": " + text;
        }
        
        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            // Создаем новую форму MenuForm, передавая текущего пользователя (Player)
            var fr5 = new MenuForm(Player);
            
            // Отображаем новую форму и скрываем текущую форму InfoForm
            fr5.Show();
            Hide();
        }

        private void InfoForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }
    }
}
