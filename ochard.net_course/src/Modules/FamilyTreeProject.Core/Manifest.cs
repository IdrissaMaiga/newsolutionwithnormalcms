using OrchardCore.Modules.Manifest;

[assembly: Module(
    Name = "FamilyTreeProject.Core",
    Author = "The Orchard Core Team",
    Website = "https://orchardcore.net",
    Version = "0.0.1",
    Description = "FamilyTreeProject.Core",
    Category = "Content Management",
    Dependencies = new[] { "OrchardCore.ContentFields", "OrchardCore.Media", "OrchardCore.Contents" }
)]