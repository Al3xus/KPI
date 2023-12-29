using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using tic_tac_toe.Enums;
using tic_tac_toe.PackageForGame;
using tic_tac_toe.PackageForPlayers;


namespace tic_tac_toe.Forms;

public partial class PlayGameForm : Form
{
    private Account Player { get; }
    // Конструктор формы
    public PlayGameForm(Account player)
    {
        Player = player;
        InitializeComponent();
        // Заполняем список оппонентов данными из базы данных
        oponentListBox.DataSource = InitializeForm.InitializeObjects.AccountService.DbContext.Accounts;
        oponentListBox.DisplayMember = "UserName";
        // Устанавливаем начальные значения для текстового поля оппонента и полосы рейтинга
        oponentText.Text = InitializeForm.InitializeObjects.AccountService.DbContext.Accounts[oponentListBox.SelectedIndex].UserName;
        ratingText.Text = ratingTrackBar.Minimum.ToString();
    }


    private void playBut_MouseClick(object sender, MouseEventArgs e)
    {
        // Проверяем, выбран ли оппонент и его имя не совпадает с именем текущего игрока
        if (oponentText.ForeColor == Color.Red) return;

        // Проверяем, выбран ли реальный режим игры
        if (!realCheckBox.Checked)
        {
            // В зависимости от выбранного типа игры вызываем соответствующий метод PlayingGame

            if (classicRadio.Checked)
            {
                InitializeForm.InitializeObjects.ClassicGame.PlayingGame(Player,InitializeForm.InitializeObjects.AccountService.DbContext.Accounts[oponentListBox.SelectedIndex],ratingTrackBar.Value);

            }
            else if (personalRadio.Checked)
            {
                InitializeForm.InitializeObjects.GameForOne.PlayingGame(Player,InitializeForm.InitializeObjects.AccountService.DbContext.Accounts[oponentListBox.SelectedIndex],ratingTrackBar.Value);
            }
            else
            {
                InitializeForm.InitializeObjects.TrainingGame.PlayingGame(Player,InitializeForm.InitializeObjects.TrainingBot);
            }
                
                
            // Выводим сообщение о результате игры
            switch (Player.Results.Last().Outcome)
            {
                case GameOutcome.WIN:
                    MessageBox.Show("You win\n+" + Player.Results.Last().Rating  + " rating");
                    break;
                case GameOutcome.LOSE:
                    MessageBox.Show("You lose\n-" + ratingTrackBar.Value + " rating");
                    break;
                case GameOutcome.TIE:
                    MessageBox.Show("Game tie");
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            

            // Открываем форму MenuForm и скрываем текущую форму PlayGameForm
            var fr5 = new MenuForm(Player);
            fr5.Show();
            Hide();
        }
        else
        {
            // В реальном режиме открываем RealPlayGameForm, передавая соответствующий тип игры и другие параметры

            RealPlayGameForm fr9;
            if (classicRadio.Checked)
            {
                fr9 = new RealPlayGameForm(InitializeForm.InitializeObjects.ClassicGame, Player, InitializeForm.InitializeObjects.AccountService.DbContext.Accounts[oponentListBox.SelectedIndex],
                    ratingTrackBar.Value);
            }
            else if (personalRadio.Checked)
            {
                fr9 = new RealPlayGameForm(InitializeForm.InitializeObjects.GameForOne, Player, InitializeForm.InitializeObjects.AccountService.DbContext.Accounts[oponentListBox.SelectedIndex],
                    ratingTrackBar.Value);
            }
            else
            {
                fr9 = new RealPlayGameForm(InitializeForm.InitializeObjects.TrainingGame, Player, InitializeForm.InitializeObjects.TrainingBot, ratingTrackBar.Value);
            }
            // Открываем форму RealPlayGameForm и скрываем текущую форму PlayGameForm
            fr9.Show();
            Hide();
        }



    }
    // Обработчик события выбора элемента в списке оппонентов
    private void oponentListBox_MouseClick(object sender, MouseEventArgs e)
    {
        // Вызываем метод для проверки выбора оппонента
        ClosePlayForMe();
    }
    // Метод для проверки выбора оппонента
    private void ClosePlayForMe()
    
    {
        // Если выбран оппонент с именем текущего игрока, устанавливаем соответствующий стиль и текст

        if (InitializeForm.InitializeObjects.AccountService.DbContext.Accounts[oponentListBox.SelectedIndex].UserName.Equals(Player.UserName))
        {
                
            oponentText.ForeColor = Color.Red;
            oponentText.Text = @"Ви не можете грати самі проти себе";
        }
        // В противном случае устанавливаем стиль и текст для отображения выбранного оппонента
        else
        {
            oponentText.ForeColor = Color.Black;
            oponentText.Text = InitializeForm.InitializeObjects.AccountService.DbContext.Accounts[oponentListBox.SelectedIndex].UserName;
        }
    }

    private void closeBut_MouseClick(object sender, MouseEventArgs e)
    {
        // Открываем форму MenuForm и скрываем текущую форму PlayGameForm

        var fr5 = new MenuForm(Player);
        fr5.Show();
        Hide();
    }

    private void ratingTrackBar_ValueChanged(object sender, EventArgs e)
    {
        // Обновляем текстовое поле с текущим значением рейтинга
        ratingText.Text = ratingTrackBar.Value.ToString();
    }

    private void trainingRadio_CheckedChanged(object sender, EventArgs e)
    {
        // Скрываем список оппонентов, устанавливаем соответствующий текст для оппонента
        // и скрываем ползунок рейтинга

        oponentListBox.Visible = false;
        oponentText.ForeColor = Color.Black;
        oponentText.Text = @"Training bot";
        ratingTrackBar.Visible = false;
        ratingText.Text = @"0";
    }


    private void personalRadio_CheckedChanged(object sender, EventArgs e)
    {
        // Показываем список оппонентов и ползунок рейтинга, а также проверяем выбор оппонента

        oponentListBox.Visible = true;
        ratingTrackBar.Visible = true;
        ClosePlayForMe();
        ratingText.Text = ratingTrackBar.Value.ToString();
    }

    private void classicRadio_CheckedChanged(object sender, EventArgs e)
    {
        // Показываем список оппонентов и ползунок рейтинга, а также проверяем выбор оппонента
        oponentListBox.Visible = true;
        ratingTrackBar.Visible = true;
        ClosePlayForMe();
        ratingText.Text = ratingTrackBar.Value.ToString();
    }

    private void PlayGameForm_FormClosed(object sender, FormClosedEventArgs e)
    {
        Close();
            
    }
}