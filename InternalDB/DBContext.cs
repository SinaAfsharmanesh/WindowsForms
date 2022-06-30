using Microsoft.EntityFrameworkCore;
using WindowsForms.Model;

namespace WindowsForms.InternalDB
{
    public partial class DBContext : DbContext
    {
        public DBContext()
        {
        }

        public DBContext(DbContextOptions<DBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<User> UsersLists { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=LAPTOP-FVP4IU0R;Database=DB;Trusted_Connection=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.ModelId)
                    .HasName("PK_Products_Id");

                entity.Property(e => e.ModelId).HasMaxLength(50);

                entity.Property(e => e.ManDate).HasColumnType("date");

                entity.Property(e => e.Manufacturer).HasMaxLength(50);

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.ProductName).HasMaxLength(50);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("UsersList");

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DOB)
                    .HasColumnType("date")
                    .HasColumnName("DOB");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NatID)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NatID")
                    .IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
