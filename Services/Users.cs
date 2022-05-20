namespace WindowsForms.Model;

internal partial class Users
{
    public void EditUser(string firstname, string lastname, string email, int tel)
    {
        FirstName = firstname;
        LastName = lastname;
        Email = email;
        Tel = tel;
    }
}