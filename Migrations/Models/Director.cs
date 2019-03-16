using System;
using System.Collections.Generic;
using Migrations.Models.ModelsManyToMany;

namespace Migrations.Models
{
    public class Director
    {
        public Guid DirectorId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }

        public List<MovieDirector> MovieDirector { get; set; }
    }
}
