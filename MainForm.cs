using Microsoft.Extensions.Configuration;
using WindowsForms.Model;
using WindowsForms.Services;
using WindowsForms.UI;
using WindowsForms.UI.UserCTRL;
using WindowsForms.UI.UserCTRL.Products;
using WindowsForms.UI.UserCTRL.Users;

namespace WindowsForms;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        if (config.appSetttings.ConnectonString == "")
        {
            var message = MessageBox.Show("Login Info required", "Notice", MessageBoxButtons.OK);

            status = "LOGIN REQUIRED";
            if (message == DialogResult.OK)
            {
                Login login = new();
                login.TopMost = true;
                login.ShowDialog();
                if (login.IsDisposed)
                    this.Refresh();
            }
        }
        else
        {
            status = config.appSetttings.ConnectonString.Split(';')[0].Split('=')[1] + "/" +
                     config.appSetttings.ConnectonString.Split(';')[1].Split('=')[1];
        }
        toolStripDbName.Text = status;
    }

    readonly Config config = new ConfigurationBuilder()
        .SetBasePath(Environment.CurrentDirectory)
        .AddJsonFile("appsettings.json")
        .Build()
        .Get<Config>();

    private string status;
    private UsersGrid? usersGrid;
    private ProductsGrid? productsGrid;

    private void ShowUC(BaseCTRL ctrl)
    {
        panelMain.Controls.Clear();
        panelMain.Controls.Add(ctrl);
    }

    private void boxProducts_Click(object sender, EventArgs e)
    {
        productsGrid = new ProductsGrid();
        boxUsers.Checked = false;
        ShowUC(productsGrid);
    }

    private void boxUsers_Click(object sender, EventArgs e)
    {
        usersGrid = new UsersGrid();
        boxProducts.Checked = false;
        ShowUC(usersGrid);
    }

    private void productsListToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
    {
        productsListToolStripMenuItem.ForeColor = Color.Black;
    }

    private void productsListToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
    {
        productsListToolStripMenuItem.ForeColor = Color.White;
    }

    private void usersListToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
    {
        usersListToolStripMenuItem.ForeColor = Color.Black;
    }

    private void usersListToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
    {
        usersListToolStripMenuItem.ForeColor = Color.White;
    }

    private void addToolStripMenuItem_Click(object sender, EventArgs e)
    {
        using var form = new UserNew();
        form.TopMost = true;
        form.ShowDialog();

    }

    private void editToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (usersGrid?.Selected() == null)
        {
            MessageBox.Show("No Items Selected");
            return;
        }

        using var form = new UserEdit(usersGrid.Selected());
        form.TopMost = true;
        form.ShowDialog();
    }

    private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (usersGrid?.Selected() == null)
        {
            MessageBox.Show("No Items Selected");
            return;
        }
        DialogResult result = MessageBox.Show(text: "Are You Sure?", caption: "Delete", buttons: MessageBoxButtons.YesNo);
        if (result == DialogResult.Yes)
        {
            Repo.Instance.Delete<User>((int)usersGrid.Selected().Id);
        }
    }

    private void toolStripDbName_Click(object sender, EventArgs e)
    {
        Login login = new();
        login.TopMost = true;
        login.ShowDialog();
    }

}