using WindowsForms.UI;

namespace WindowsForms;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    private void btnTeams_Click(object sender, EventArgs e)
    {
        new Teams().Show();
    }

    private void UserGrid_Click(object sender, EventArgs e)
    {
        new UserGrid().Show();
    }

    private void btnAddUser_Click(object sender, EventArgs e)
    {
        new UserNew().Show();
    }
}