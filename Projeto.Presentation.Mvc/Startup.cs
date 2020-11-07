using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Projeto.Infra.Data.Repositories;

namespace Projeto.Presentation.Mvc
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        //prop + 2x[tab]
        public IConfiguration Configuration { get; set; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie();

            var connectionString = Configuration.GetConnectionString("ProjetoMvcLoja");

            services.AddTransient(map => new ProdutoRepository(connectionString));
            services.AddTransient(map => new VendedorRepository(connectionString));

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();
            app.UseRouting();

            app.UseCookiePolicy(); //habilitar autenticação por meio de cookies
            app.UseAuthentication(); //habilitar autenticação por meio de cookies
            app.UseAuthorization(); //habilitar autenticação por meio de cookies

            app.UseEndpoints(
                           endpoints =>
                           {
                               endpoints.MapControllerRoute(
                                   name: "default", //define o padrão de navegação
                                   pattern: "{controller=Home}/{action=Index}"
                                   );
                           });
        }
    }
}
