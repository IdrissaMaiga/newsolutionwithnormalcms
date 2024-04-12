using FamilyTreeProject.Core.Migrations;
using FamilyTreeProject.Core.Models;
using Microsoft.AspNetCore.Builder;

using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using OrchardCore.ContentManagement;
using OrchardCore.Data.Migration;
using OrchardCore.Modules;



namespace FamilyTreeProject.Core
{
    public class Startup : StartupBase
    {
        public override void ConfigureServices(IServiceCollection services)
        {

            services.AddContentPart<PersonPart>();
            services.AddScoped<IDataMigration, PersonMigration>();


            // Other service configurations...

        }



        public override void Configure(IApplicationBuilder builder, IEndpointRouteBuilder routes, IServiceProvider serviceProvider)
        {

            routes.MapAreaControllerRoute(
                name: "Home",
                areaName: "FamilyTreeProject.Core",
                pattern: "Home/Index",
                defaults: new { controller = "Home", action = "Index" }
            );



        }



    }
}
