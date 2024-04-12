using FamilyTreeProject.Core.Models;
using OrchardCore.ContentFields.Fields;
using OrchardCore.ContentFields.Settings;
using OrchardCore.ContentManagement.Metadata;
using OrchardCore.ContentManagement.Metadata.Settings;
using OrchardCore.Data.Migration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyTreeProject.Core.Migrations
{
    public class PersonMigration : DataMigration
    {
        private readonly IContentDefinitionManager _contentDefinitionManager;

        public PersonMigration(IContentDefinitionManager contentDefinitionManager)
        {
            _contentDefinitionManager = contentDefinitionManager;
        }

        public async Task<int> CreateAsync()
        {
            try
            {
                await _contentDefinitionManager.AlterPartDefinitionAsync(nameof(PersonPart),
                    part => part.Attachable()
                    .WithField(nameof(PersonPart.Address),
                    field => field.OfType(nameof(TextField)).WithDisplayName("Address")
                    .WithSettings(new TextFieldSettings { Hint = "Person's Address" })));

                await _contentDefinitionManager.AlterTypeDefinitionAsync("PersonPage", type => type
                    .Creatable()
                    .Listable()
                    .WithPart(nameof(PersonPart)));

                return 1;
            }
            catch (Exception ex)
            {
                // Handle or log the exception appropriately
                Console.WriteLine($"An error occurred during migration: {ex.Message}");
                return -1; // Return a negative value to indicate failure
            }
        }
    }


}
