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
        try
        {
            User u = new User(Convert.ToInt32(IdLabel.Text), txtBoxFirstName.Text, txtBoxLastName.Text, txtBoxNatID.Text, dateTimePicker.Value, txtBoxAddress.Text, txtBoxEmail.Text, true);
            u.Update(u, (int)u.Id);
            MessageBox.Show("User Updated");
            Dispose();
        }
        catch (Exception exception)
        {
            MessageBox.Show(exception.ToString());
            throw;
        }
    }
}