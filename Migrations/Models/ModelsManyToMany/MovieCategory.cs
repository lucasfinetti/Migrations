using System;

namespace Migrations.Models.ModelsManyToMany
{
    public class MovieCategory
    {
        public int MovieCategoryId { get; set; }

        public Guid MovieId { get; set; }
        public Movie Movie { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
