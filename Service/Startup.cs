using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace TeamDraw 
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddCors(options =>
                options.AddPolicy("AllowWebClient", p => p.WithOrigins("http://localhost:5001")
                                                            .AllowAnyMethod()
                                                            .AllowAnyHeader()
                                                            ));
        }
        public void Configure(IApplicationBuilder app)
        {
            app.UseMvc();
        }
    }
}