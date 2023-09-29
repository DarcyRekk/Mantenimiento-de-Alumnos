using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
namespace PC1AbantoFreyre.Database.AlumnosContext
{
    public class AlumnosContext : DbContext
    {
        public DbSet<AlumnosEntity> Alumnos { get; set; }
        public AlumnosContext(DbContextOptions<AlumnosContext> option) : base(option)
        {

        }
    }
}
