using WindowsForms.Model;
using WindowsForms.Services;

namespace WindowsForms.InternalDB
{
    internal class Db
    {
        private Db()
        {

        }
        private static readonly Lazy<Db> LazyDb = new Lazy<Db>(() => new Db());
        public static Db Instance => LazyDb.Value;
        private Repo repo = Repo.Instance;


        private List<User> users;
        private List<Product> products;

        public virtual List<User> Users { get => users = repo.GetDbSet<User>().ToList(); set => users = value; }
        public virtual List<Product> Products { get => products = repo.GetDbSet<Product>().ToList(); set => products = value; }
    }
}
