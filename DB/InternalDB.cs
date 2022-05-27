using WindowsForms.Model;

namespace WindowsForms.DB;

public static class InternalDb
{
    public static List<Users> UsersList { get; set; } = new() { new Users("Empty", "Empty", "Empty", 0) };

    public static Users? GetUser(int id)
    {
        return UsersList[id];
    }

    public static void AddUser(string firstname, string lastname, string email, int tel)
    {
        UsersList?.Add(new Users(firstname, lastname, email, tel));
    }

    public static void DelUser(int id)
    {
        var i = 1;
        UsersList.RemoveAt(id);
        UsersList.ForEach(x =>
        {
            x.ResetId(i);
            i++;
        });
    }

    public static void EditUser(int id, string firstName, string lastName, string email, int tel)
    {
        UsersList[id].EditUser(firstName, lastName, email, tel);
    }
}