namespace WindowsForms.Model;

internal partial class Users
{
    public Users(string firstname, string lastname, string email, int tel)
    {
        FirstName = firstname;
        LastName = lastname;
        Email = email;
        Tel = tel;
        Count += 1;
    }

    private static int Count { get; set; }

    private int Id { get; } = Count;

    private string FirstName { get; set; }

    private string LastName { get; set; }

    private string Email { get; set; }

    private int Tel { get; set; }

    ~Users()
    {
        Count -= 1;
    }
}