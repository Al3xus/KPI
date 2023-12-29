using System;
using System.Windows.Forms;
using tic_tac_toe.Hashing;
using tic_tac_toe.PackageForPlayers;

namespace tic_tac_toe.Forms;

public partial class RegForm : Form
{
    public RegForm()
    {
        InitializeComponent();
    }


    private void button5_MouseClick(object sender, MouseEventArgs e)
    {
        // Проверка наличия введенных данных
        if (firstNameTextBox.Text != "" && lastNameTextBox.Text != "" && userNameTextBox.Text != "" &&
            passwordTextBox.Text != "")
        {
            // Проверка уникальности псевдонима
            if (!InitializeForm.InitializeObjects.AccountService.FindAccount(userNameTextBox.Text))
            {
                // Проверка длины пароля
                if (passwordTextBox.Text.Length >= 8)
                {
                    Account player;
                    // В зависимости от выбранного типа аккаунта создается обычный или премиум-аккаунт
                    if (ClassicAcc.Checked)
                    {
                        player = InitializeForm.InitializeObjects.AccountService.AddAccountToDataBase(firstNameTextBox.Text,
                            lastNameTextBox.Text,
                            userNameTextBox.Text, Md5.HashPassword(passwordTextBox.Text));
                    }
                    else
                    {
                        player = InitializeForm.InitializeObjects.AccountService.AddPremiumAccountToDataBase(firstNameTextBox.Text,
                            lastNameTextBox.Text, userNameTextBox.Text, Md5.HashPassword(passwordTextBox.Text));
                    }
                    var fr5 = new MenuForm(player);
                    fr5.Show();
                    Hide();
                }
                else
                {
                    label5.Text = @"Короткий пароль";
                }
            }
            else
            {
                label5.Text = @"Псевдонім зайнятий";
            }
        }
        else
        {
            label5.Text = @"Заповніть усі поля";
        }
    }

    private void button1_MouseClick(object sender, MouseEventArgs e)
    {
        var fr2 = new LogOrRegForm();
        fr2.Show();
        Hide();
    }


    private void checkBox1_MouseCaptureChanged(object sender, EventArgs e)
    {
        // Смена отображения символов пароля в зависимости от состояния чекбокса
        passwordTextBox.PasswordChar = checkBox1.Checked ? new char() : '*';
    }


    private void RegForm_FormClosed(object sender, FormClosedEventArgs e)
    {
        Close();
    }
}