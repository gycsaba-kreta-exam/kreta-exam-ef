using _06_linq.Model;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace KretaEF.Context
{
    public class KretaContext : DbContext
    {
        public DbSet<Subject> Subjects { get; set; }

        public KretaContext(DbContextOptions<KretaContext> options, IConfiguration config)
            : base(options)
        {
        }
   }
}
