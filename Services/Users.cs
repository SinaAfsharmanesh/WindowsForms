using System.Data;
using System.Data.SqlClient;
using WindowsForms.InternalDB;

namespace WindowsForms.Model;


public partial class User : IDatabaseObject
{
    private void ExecuteSqlCommand(string crud, User? model = null, int? Id = null)
    {
        using var command = new SqlCommand();

        command.Connection = IDatabaseObject.Connection;
        command.CommandText = "UsersList_" + crud;
        command.CommandType = CommandType.StoredProcedure;

        if (crud is "Update")
        {
            command.Parameters.AddWithValue("Id", model.Id);
            command.Parameters.AddWithValue("FirstName", model.FirstName);
            command.Parameters.AddWithValue("LastName", model.LastName);
            command.Parameters.AddWithValue("NationalId", model.NatID);
            command.Parameters.AddWithValue("DateOfBirth", model.DOB);
            command.Parameters.AddWithValue("Address", model.Address);
            command.Parameters.AddWithValue("Email", model.Email);
            command.Parameters.AddWithValue("IsActive", model.IsActive);
        }

        else if (crud is "Insert")
        {
            command.Parameters.AddWithValue("FirstName", model.FirstName);
            command.Parameters.AddWithValue("LastName", model.LastName);
            command.Parameters.AddWithValue("NationalId", model.NatID);
            command.Parameters.AddWithValue("DateOfBirth", model.DOB);
            command.Parameters.AddWithValue("Address", model.Address);
            command.Parameters.AddWithValue("Email", model.Email);
            command.Parameters.AddWithValue("IsActive", model.IsActive);
        }

        else if (crud is "Delete")
        {
            command.Parameters.AddWithValue("Id", Id);
        }

        IDatabaseObject.Connection.Open();
        command.ExecuteNonQuery();
        IDatabaseObject.Connection.Close();
    }

    public void Insert(IDatabaseObject databaseObject) => ExecuteSqlCommand("Insert", (User)databaseObject);

    public void Update(IDatabaseObject databaseObject, int Id) => ExecuteSqlCommand("Update", (User)databaseObject, Id);

    public void Delete(int Id) => ExecuteSqlCommand("Delete", Id: Id);

    public static void Read()
    {
        int Id = 1;
        using var command = new SqlCommand();
        command.Connection = IDatabaseObject.Connection;
        command.CommandText = "UsersList_Select";
        command.CommandType = CommandType.StoredProcedure;
        IDatabaseObject.Connection.Open();

        if (Users.UsersList is not null)
            Users.UsersList.Clear();

        SqlDataReader reader = command.ExecuteReader();

        while (reader.Read())
        {
            Users.UsersList!.Add(new User
                (
                Convert.ToInt32(reader["Id"]),
                Convert.ToString(reader["FirstName"]),
                Convert.ToString(reader["LastName"]),
                Convert.ToString(reader["NationalId"]),
                Convert.ToDateTime(reader["DateOfBirth"]),
                Convert.ToString(reader["Address"]),
                Convert.ToString(reader["Email"]),
                Convert.ToBoolean(reader["IsActive"])
                ));
        }

        IDatabaseObject.Connection.Close();
    }
}