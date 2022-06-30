using WindowsForms.Model;
namespace WindowsForms.UI;

public partial class UserEdit : Form
{
    public UserEdit(User? model)
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


    private void btnSubmit_Click(object sender, EventArgs e)
    {

    }
}