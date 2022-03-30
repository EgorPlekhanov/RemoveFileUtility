using Microsoft.Extensions.DependencyInjection;

namespace RemoveFileUtility
{
    class Program
    {
        public static void Main(string[] args)
        {
            IServiceCollection services = new ServiceCollection();
            Startup startup = new Startup();
            ServiceProvider serviceProvider = startup.ConfigureServices(services);
            ;
            ;
        }
    }
}
