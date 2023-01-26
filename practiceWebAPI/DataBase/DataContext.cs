using Microsoft.EntityFrameworkCore;
using practiceWebAPI.Model_file;

namespace practiceWebAPI.DataBase
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<TypeOfProfessions> TypeOfProfessions { get; set; }
        public DbSet<Artists> Artists { get; set; } 
        public DbSet<Status> Status { get; set; }

    }
}
