using DAL.Models;
using System.Data.Entity;

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

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<File> Files { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Group> Groups { get; set; }

    }
}
