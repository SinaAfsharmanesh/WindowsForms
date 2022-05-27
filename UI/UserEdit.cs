using static WindowsForms.DB.InternalDb;

namespace WindowsForms.UI;

public partial class UserEdit : Form
{
    private int Id;

    public UserEdit(int id)
    {
        InitializeComponent();
        Id = id;
    }


    private void btnEdit_Click(object sender, EventArgs e)
    {
        EditUser(Id, txtBoxFirstName.Text, txtBoxLastName.Text, txtBoxEmail.Text, Convert.ToInt32(txtBoxTel.Text));
        Dispose();
    }
}