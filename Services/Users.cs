namespace WindowsForms.Model;

public partial class Users
{
    public void EditUser(string firstname, string lastname, string email, int tel)
    {
        FirstName = firstname;
        LastName = lastname;
        Email = email;
        Tel = tel;
    }

    public void ResetId(int id)
    {
        Id = id;
    }
}