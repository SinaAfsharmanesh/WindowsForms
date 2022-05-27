namespace WindowsForms.Model;

public partial class Users
{
    public Users(string firstname, string lastname, string email, int tel)
    {
        FirstName = firstname;
        LastName = lastname;
        Email = email;
        Tel = tel;
        Count += 1;
    }

    public static int Count { get; private set; }

    public int Id { get; set; } = Count;

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Email { get; set; }

    public int Tel { get; set; }

    ~Users()
    {
        Count -= 1;
    }
}