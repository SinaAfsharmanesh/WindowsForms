using WindowsForms.Model;
using WindowsForms.Services;

namespace WindowsForms.UI;

public partial class UserEdit : Form
{
    public UserEdit(User model)
    {
        InitializeComponent();
        IdLabel.Text = Convert.ToString(model.Id);
        txtBoxFirstName.Text = model.FirstName;
        txtBoxLastName.Text = model.LastName;
        txtBoxNatID.Text = model.NatID;
        txtBoxEmail.Text = model.Email;
        txtBoxAddress.Text = model.Address;
        dateTimePicker.Value = model.DOB;

    }
    Repo repo = Repo.Instance;

    private void btnSubmit_Click(object sender, EventArgs e)
    {
        repo.Edit(new User(Convert.ToInt32(IdLabel.Text), txtBoxFirstName.Text, txtBoxLastName.Text, txtBoxNatID.Text, dateTimePicker.Value, txtBoxAddress.Text,
            txtBoxEmail.Text, true), Convert.ToInt32(IdLabel.Text));
    }
}