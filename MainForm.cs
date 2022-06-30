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

    private void ShowUC(BaseCTRL ctrl)
    {
        ctrl.Width = panelMain.Width;
        ctrl.Height = panelMain.Height;
        panelMain.Controls.Clear();
        panelMain.Controls.Add(ctrl);
    }

    private void BtnProducts_Click(object sender, EventArgs e)
    {
        ShowUC(new ProductsGrid());
    }

    private void BtnUsers_Click(object sender, EventArgs e)
    {
        ShowUC(new UsersGrid());
    }
}