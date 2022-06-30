using System.ComponentModel.DataAnnotations;

namespace WindowsForms.Model;

public partial class User
{
    public User(int id, string firstname, string lastname, string nationalid, DateTime dob, string address, string email, bool isActive)
    {
        Id = id;
        FirstName = firstname;
        LastName = lastname;
        NatID = nationalid;
        DOB = dob;
        Address = address;
        Email = email;
        IsActive = isActive;
    }

    public User(string firstname, string lastname, string nationalid, DateTime dob, string address, string email, bool isActive)
    {
        Id = null;
        FirstName = firstname;
        LastName = lastname;
        NatID = nationalid;
        DOB = dob;
        Address = address;
        Email = email;
        IsActive = isActive;
    }

    public User() { }

    public int? Id { get; set; } = null;
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string? Email { get; set; }

    public string? Address { get; set; }

    [StringLength(10)]
    public string NatID { get; set; }

    public DateTime DOB { get; set; }

    public bool IsActive { get; set; }
}