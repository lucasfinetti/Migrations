using System;
using System.Collections.Generic;

namespace Migrations.Models
{
    public class Reviewer
    {
        public Guid ReviewerId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }

        public List<Rating> Ratings { get; set; }
    }
}
