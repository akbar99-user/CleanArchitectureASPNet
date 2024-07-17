using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Database
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }
        public DbSet<ProgramStudi> programStudi {  get; set; }
        public DbSet<Matakuliah> matakuliah { get; set; }
        public DbSet<Mahasiswa> mahasiswa { get; set; }
    }
}
