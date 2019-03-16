using System;

namespace Migrations.Models.ModelsManyToMany
{
    public class MovieActor
    {
        public int MovieActorId { get; set; }

        public Guid MovieId { get; set; }
        public Movie Movie { get; set; }

        public Guid ActorId { get; set; }
        public Actor Actor { get; set; }
    }
}
