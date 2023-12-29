using System.Windows.Forms;

namespace tic_tac_toe.Forms;

public partial class LogOrRegForm : Form
{
    public LogOrRegForm()
    {
        InitializeComponent();
    }

    private void button2_MouseClick_1(object sender, MouseEventArgs e)
    {
        var fr3 = new RegForm();
        fr3.Show();
        Hide();
    }

    private void button1_MouseClick(object sender, MouseEventArgs e)
    
    {
        var fr4 = new LoginForm();
        fr4.Show();
        Hide();
    }


    private void LogOrRegForm_FormClosed(object sender, FormClosedEventArgs e)
    {
        Close();
    }
}