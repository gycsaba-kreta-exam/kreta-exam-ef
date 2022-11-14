using KretaEF.Context;

namespace KretaEF.Extensions
{
    public static class ServiceExtenxions
    {
        // MySql
        /*public static void ConfigureMySqlContext(this IServiceCollection services, IConfiguration config)
        {
            var connectionString = config["mysqlconnection:connectionString"];

            //services.AddDbContext<KretaContext>(o => o.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

            //services.AddDbContext<KretaContext>(o => o.UseMySql(connectionString,MySqlServerVersion.LatestSupportedServerVersion));

           /* services.AddDbContext<KretaContext>(o => o.UseMySql(connectionString,
                ServerVersion.AutoDetect(connectionString),
                options => options.EnableRetryOnFailure(
                    maxRetryCount: 5,
                    maxRetryDelay: System.TimeSpan.FromSeconds(3000),
                    errorNumbersToAdd: null)
                ));
        }*/
    }
}
