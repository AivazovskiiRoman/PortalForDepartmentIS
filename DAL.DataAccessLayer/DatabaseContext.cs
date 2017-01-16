using System.Data.Entity;
using DAL.Models;

namespace DAL.DataAccessLayer
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("DefaultConnection")
        {
        }

        public DatabaseContext(string connectionString) : base(connectionString)
        {
        }

        public static DatabaseContext Create()
        {
            return new DatabaseContext();
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Group> Groups { get; set; }
        public virtual DbSet<Post> Posts { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<Document> Documents { get; set; }
        public virtual DbSet<File> Files { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}
