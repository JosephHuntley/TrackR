using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace TrackR.DataContext.SQL;

public static class SqContextExtensions
{
    public static IServiceCollection AddSqlContext(this IServiceCollection services,
        string connectionString = "Data Source=.;User=sa;password=D3veloper;" +
                                  "MultipleActiveResultsets=true;Encrypt=false")
    {
        services.AddDbContext<SqlContext>(options =>
        {
            options.UseSqlServer(connectionString);
            options.LogTo(Console.WriteLine,
                new[] { Microsoft.EntityFrameworkCore
                    .Diagnostics.RelationalEventId.CommandExecuting });
        });
        return services;
    }
}