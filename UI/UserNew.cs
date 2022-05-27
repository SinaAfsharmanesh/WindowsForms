using static WindowsForms.DB.InternalDb;

namespace WindowsForms.UI;

public partial class UserNew : Form
{
    public UserNew()
    {
        InitializeComponent();
    }

    private void btnNew_Click(object sender, EventArgs e)
    {
        AddUser(txtBoxFirstName.Text, txtBoxLastName.Text, txtBoxEmail.Text, Convert.ToInt32(txtBoxTel.Text));
        Dispose();
    }
}