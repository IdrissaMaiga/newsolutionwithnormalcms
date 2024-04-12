using OrchardCore.ContentFields.Fields;
using OrchardCore.ContentManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyTreeProject.Core.Models
{
    public class PersonPart : ContentPart
    {
        public string? Name { get; set; }
        public string? Gender { get; set; }
        public string? DateOfBirth { get; set; }
        public string? Autobiography { get; set; }
        public string? Father { get; set; }
        public string? Mother { get; set; }
        public string? ImagePath { get; set; }
        public string? Husband { get; set; }
        public string? Wife { get; set; }
        public DateTime? MariedSince { get; set; }
        public TextField? Address { get; set; }
        public string? Generation { get; set; }
    }
}
