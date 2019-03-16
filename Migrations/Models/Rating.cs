using System;

namespace Migrations.Models
{
    public class Rating
    {
        public Guid RatingId { get; set; }
        public int Stars { get; set; }
        public double Rate { get; set; }

        public Guid ReviewerId { get; set; }
        public Reviewer Reviewer { get; set; }

        public Guid MovieId { get; set; }
        public Movie Movie { get; set; }
    }
}
