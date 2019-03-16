using System;

namespace Migrations.Models.ModelsManyToMany
{
    public class MovieDirector
    {
        public int MovieDirectorId { get; set; }

        public Guid MovieId { get; set; }
        public Movie Movie { get; set; }

        public Guid DirectorId { get; set; }
        public Director Director { get; set; }
    }
}
