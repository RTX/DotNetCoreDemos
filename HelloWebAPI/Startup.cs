using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace HelloWebApi
{
    public class Startup
    {
       public static  IConfigurationRoot Configuration { get; set; }

    public Startup(IHostingEnvironment env)
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(env.ContentRootPath)
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

        Configuration = builder.Build();

        var settings = Configuration.GetSection("AppSettings")["test"];
    }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddMvcCore().AddJsonFormatters();
        services.AddMvc();

        // Add functionality to inject IOptions<T>
        services.AddOptions();

        // Add our Config object so it can be injected
        services.Configure<Settings>(Configuration);
    }
    
     

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(LogLevel.Debug);

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
