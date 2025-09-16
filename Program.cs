using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using RadhaCapitalFinance.Core.Entities;
using RadhaCapitalFinance.Core.Interfaces;
using RadhaCapitalFinance.Services;
using Npgsql.EntityFrameworkCore;

namespace RadhaCapitalFinance
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<FinanceDBContext>(options =>
        options.UseNpgsql(builder.Configuration.GetConnectionString("connection")));


            builder.Services.AddScoped(typeof(IGenericService<>), typeof(GenericService<>));
            var app = builder.Build();
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Insurence}/{action=Finence}/{id?}");

            app.Run();
        }
    }
}
