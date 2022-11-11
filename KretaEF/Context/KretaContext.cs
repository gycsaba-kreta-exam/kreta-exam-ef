using _06_linq.Model;
using System.Data.Common;

namespace KretaEF.Context
{
    public class KretaContext : DbContext
    {
        public DbSet<Subject> Subjects { get; set; }
        private IConfiguration configuration;

        public KretaContext(DbContextOptions<KretaContext> options, IConfiguration config)
            : base(options)
        {
            configuration=config;
        }
   }
}
