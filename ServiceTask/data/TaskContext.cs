using Microsoft.EntityFrameworkCore;

namespace ServiceTask.data
{
    public class TaskContext:DbContext
    {
        IConfiguration configuration;
        public TaskContext(IConfiguration _configuration)
        {
            configuration = _configuration;
        }
        public DbSet<Intrested> Intrested { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Customer> Customers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("Service"));
            
            base.OnConfiguring(optionsBuilder);
        }

    }
}
