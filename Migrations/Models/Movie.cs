using System;
using System.Collections.Generic;
using Migrations.Models.ModelsManyToMany;

namespace Migrations.Models
{
    public class Movie
    {
        public Guid MovieId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ReleaseYear { get; set; }
        public int DurationHours { get; set; }
        public int DurationMinutes { get; set; }
        public DateTime LastUpdate { get; set; }

        public int LanguageId { get; set; }
        public Language Language { get; set; }

        public List<Rating> Ratings { get; set; }

        public List<MovieActor> MovieActor { get; set; }

        public List<MovieCategory> MovieCategory { get; set; }

        public List<MovieDirector> MovieDirector { get; set; }
    }
}
