using Microsoft.EntityFrameworkCore;
using WindowsForms.InternalDB;

namespace WindowsForms.Services
{
    public class Repo
    {

        private Repo()
        {

        }
        private static readonly Lazy<Repo> LazyRepo = new Lazy<Repo>(() => new Repo());
        public static Repo Instance => LazyRepo.Value;

        DBContext db = new DBContext();

        public DbSet<T> GetDbSet<T>() where T : class
        {
            return db.Set<T>();
        }

        public void Add<T>(T model) where T : class
        {
            db.Set<T>().Add(model);
            db.SaveChanges();
        }

        public bool Edit<T>(T? model, int Id) where T : class
        {
            T? m = db.Find<T>(Id);

            if (m != null)
            {
                m = model;
                db.Update(m);
                db.Entry(m).State = EntityState.Modified;
                db.SaveChanges();
                return true;
            }

            return false;
        }

        public bool Delete<T>(int ID) where T : class
        {
            T? model = db.Find<T>(ID);

            if (model != null)
            {
                db.Entry(model).State = EntityState.Deleted;
                db.Remove(model);
                db.SaveChanges();
                return true;
            }

            return false;
        }

        public IQueryable<T> AsQueryable<T>() where T : class
        {
            return db.Set<T>().AsQueryable();
        }

    }
}