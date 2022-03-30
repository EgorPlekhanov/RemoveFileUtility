using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.IO;

namespace RemoveFileUtility
{
    internal class Startup
    {
        public IConfiguration Configuration { get; set; }        

        public Startup()
        {
            Configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
        }

        public ServiceProvider ConfigureServices(IServiceCollection services)
        {
            services.Configure<ApplicationInfo>(Configuration.GetSection(nameof(ApplicationInfo)));
            services.Configure<EmailSettings>(Configuration.GetSection(nameof(EmailSettings)));

            return services.BuildServiceProvider();
        }
    }
}