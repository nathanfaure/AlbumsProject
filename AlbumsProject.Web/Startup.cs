using AlbumsProject.BLL.Entities.Identity;
using AlbumsProject.DAL.Configuration;
using AlbumsProject.DAL.EF;
using AlbumsProject.Services.Contracts;
using AipBlog.Services.Services;
using AlbumsProject.Web.Configuration;
using DataAccessLayer.Core.EntityFramework.UoW;
using DataAccessLayer.Core.Interfaces.UoW;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using AlbumsProject.Services.Services;
using Microsoft.AspNetCore.Builder;

namespace AlbumsProject.Web
{
    public class Startup
    {
        private readonly string _connectionString;

        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            _connectionString = Configuration["ConnectionStrings:MsSqlServerConnection"];
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var dbOptions = new DatabaseOptions
            {
                ConnectionString = _connectionString
            };

            services.AddDbContext<BlogDbContext>(ServiceLifetime.Scoped);
            services.AddScoped<DbContext, BlogDbContext>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddSingleton(dbOptions);
            var mappingConfig = new AutoMapper.MapperConfiguration(cfg =>
            {
                cfg.AddMapping();
            });
            services.AddSingleton(x => mappingConfig.CreateMapper());
            services.AddScoped<IPostService, PostService>();
            services.AddScoped<ICommentService, CommentService>();
            services.AddIdentity<User, Role>()
                .AddEntityFrameworkStores<BlogDbContext>()
                .AddDefaultTokenProviders();

            services.AddMvc();
            services.AddSignalR(options =>
            {
                options.Hubs.EnableDetailedErrors = true;
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Post}/{action=Index}/{id?}");
            });
            app.UseStaticFiles();
            app.UseSignalR();

        }
    }
}
