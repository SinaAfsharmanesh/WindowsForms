using WindowsForms.Model;

namespace WindowsForms.InternalDB
{
    public sealed class Users
    {
        private static Users _instance = null!;
        private static readonly object Padlock = new();
        public static List<User?> UsersList { get; set; } = new List<User?>();
        public string UserName { get; set; }


        private Users() { }

        public static Users GetUsersList
        {
            get
            {
                if (_instance == null)
                {
                    lock (Padlock)
                    {
                        if (_instance == null)
                        {
                            _instance = new Users();
                        }

                    }
                }
                return _instance;
            }
        }
    }
}
