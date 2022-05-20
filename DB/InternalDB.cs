using WindowsForms.Model;

namespace WindowsForms.DB;

internal static class InternalDB
{
    private static List<Users>? usersList;

    public static void AddUser(string firstname, string lastname, string email, int tel)
    {
        usersList?.Add(new Users(firstname, lastname, email, tel));
    }

    public static void DelUser(int id)
    {
        if (usersList == null)
            throw new NullReferenceException();
        var i = 1;
        usersList.RemoveAt(id);
        usersList.ForEach(x =>
        {
            x.ResetId(i);
            i++;
        });
        //for (var j = 1; j <= Users.Count; j++) usersList[j - 1].ResetId(j);
    }

    public static void EditUser(int id, string firstName, string lastName, string email, int tel)
    {
        if (usersList == null)
            throw new NullReferenceException();
        usersList[id].EditUser(firstName, lastName, email, tel);
    }
}