using Microsoft.AspNet.Builder;
using Microsoft.Framework.DependencyInjection;
using Microsoft.Framework.Logging;

namespace HelloMvc
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app)
        {
            //loggerFactory.AddConsole();
            
            app.UseErrorPage();

            app.UseMvcWithDefaultRoute();

            app.UseWelcomePage();
        }
    }
}