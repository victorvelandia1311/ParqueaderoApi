using Microsoft.EntityFrameworkCore;
using Parqueadero_Api.Data;

namespace Parqueadero_Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration) 
        {
            Configuration = configuration;
        }

        public Startup()
        {
        }

        public IConfiguration Configuration { get; }

        public void ConfiugreServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddDbContext<DataContext>(options =>
            {
                // options.UseLazyLoadingProxies();
                options.UseNpgsql(Configuration.GetConnectionString("DefaultConnection"));
            });

            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // Configure the HTTP request pipeline.
            if (env.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

        }
    }
}
