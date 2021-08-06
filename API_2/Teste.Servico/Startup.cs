using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Teste.Aplicacao.Interfaces;
using Teste.Aplicacao;
using Teste.Infra.Repositorios;
using Teste.Dominio.Interfaces;
using System;
using Microsoft.OpenApi.Models;

namespace Teste.Servico
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddSwaggerGen();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "OPEN WebServices",
                    Description = "API ecosistema para microserviço",
                    TermsOfService = new Uri("https://example.com/terms")
                });
            });

         
            services.AddTransient<ICalculaJuros, CalculaJurosRepositorio>();
            services.AddTransient<ICalculaJurosAplicacao, CalculaJurosAplicacao>();
            services.AddTransient<IShowTheCode, ShowTheCodeRepositorio>();

            services.AddTransient<IShowTheCodeAplicacao, ShowTheCodeAplicacao>();

        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
   


            app.UseSwagger(c =>
            {
                c.SerializeAsV2 = true;
            });

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
           
            });

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
