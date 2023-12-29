using System.Drawing;
using System.Windows.Forms;
using tic_tac_toe.Enums;
using tic_tac_toe.PackageForPlayers;

namespace tic_tac_toe.Forms
{
    public partial class HistoryForm : Form
    {
        private Account Player { get; }

        public HistoryForm(Account player)
        {
            InitializeComponent();

            Player = player;

            // Отображение имени игрока на форме
            label9.Text += @" " + player.UserName;

            // Заполнение таблицы истории игр данными из списка результатов игр игрока
            int number = 1;
            foreach (var temp in player.Results)
            {
                dataGridView1.Rows.Add(number, temp.TypeGame.ToString(), temp.Id, temp.Oponent.UserName, temp.Rating,
                    temp.Outcome,
                    $"{temp.BeforeRating,2} {(temp.Outcome == GameOutcome.LOSE ? $"-{temp.BeforeRating - temp.AfterRating,2}" : $"+{temp.AfterRating - temp.BeforeRating,2}")}",
                    temp.AfterRating);
                number++;
            }

            // Окрашивание ячеек таблицы в зависимости от результата игры
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[5].Value.ToString() == GameOutcome.WIN.ToString())
                {
                    row.Cells[5].Style.BackColor = Color.Green;
                }
                else if (row.Cells[5].Value.ToString() == GameOutcome.LOSE.ToString())
                {
                    row.Cells[5].Style.BackColor = Color.Red;
                }
                else
                {
                    row.Cells[5].Style.BackColor = Color.Orange;
                }
            }
        }
        //кнопка назад
        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            // Создание и отображение новой формы меню
            var menuForm = new MenuForm(Player);
            menuForm.Show();

            // Скрытие текущей формы
            Hide();
        }

        // Закрытия формы
        private void HistoryForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Закрытие формы
            Close();
        }
    }
}
