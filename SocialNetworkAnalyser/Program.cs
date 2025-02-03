using Blazorise;
using Blazorise.Bootstrap5;
using Blazorise.Icons.FontAwesome;
using Microsoft.EntityFrameworkCore;
using SocialNetworkAnalyser.Components;
using SocialNetworkAnalyser.Data;
using SocialNetworkAnalyser.Shared;
using SocialNetworkAnalyser.Shared.Interfaces;
using SocialNetworkAnalyser.Shared.Repositories;
using SocialNetworkAnalyser.Shared.Services;

namespace SocialNetworkAnalyser
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorComponents()
                .AddInteractiveServerComponents();

            // Register the DbContext with the connection string
            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(connectionString));

            // Register AutoMapper
            builder.Services.AddAutoMapper(typeof(MappingProfile));

            // Register your custom services and repositories here
            builder.Services.AddScoped<IDatasetRepository, DatasetRepository>();
            builder.Services.AddScoped<IFriendshipRepository, FriendshipRepository>();
            builder.Services.AddScoped<IDatasetService, DatasetService>();
            builder.Services.AddScoped<IDatasetImportJob, DatasetImportJob>();

            builder.Services.AddSingleton<JobStateService>();

            builder.Services
                .AddBlazorise(options =>
                {
                    options.Immediate = true;
                })
                .AddBootstrap5Providers()
                .AddFontAwesomeIcons();

            var app = builder.Build();

            // Ensure database is created and migrations are applied
            using (var scope = app.Services.CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
                dbContext.Database.Migrate();
            }

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseWebAssemblyDebugging();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseAntiforgery();

            app.MapStaticAssets();
            app.MapRazorComponents<App>()
                .AddInteractiveServerRenderMode();

            app.Run();
        }
    }
}
