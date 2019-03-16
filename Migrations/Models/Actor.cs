using System;
using System.Collections.Generic;
using Migrations.Models.ModelsManyToMany;

namespace Migrations.Models
{
    public class Actor
    {
        public Guid ActorId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }

        public List<MovieActor> MovieActor { get; set; }
    }
}
