using System.Collections.Generic;

namespace Migrations.Models
{
    public class Language
    {
        public int LanguageId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public List<Movie> Movies { get; set; }
    }
}
