using BlazorApp2.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp2
{
    public class Program
    {
		public static void Main(string[] args)
		{
			var host = CreateHostBuilder(args).Build();

			var scopeFactory = host.Services.GetService<IServiceScopeFactory>();
			using (var scope = scopeFactory.CreateScope())
			{
				var context = scope.ServiceProvider.GetRequiredService<PizzaContext>();
				if (context.Database.EnsureCreated())
				{
					///confirma que foi criado
				}
			}
			host.Run();
		}


		public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
