using System.Data.SqlClient;

namespace WindowsForms.Model;

public interface IDatabaseObject
{
    private static SqlConnection _connection = new("Server=LAPTOP-FVP4IU0R;Database=DB;Trusted_Connection=true;");
    public static SqlConnection Connection { get => _connection; set => _connection = value; }
    public void Insert(IDatabaseObject databaseObject);
    public void Update(IDatabaseObject databaseObject, int Id);
    public void Delete(int Id);
    public static void Read() { }
}