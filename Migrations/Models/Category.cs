using System.Collections.Generic;
using Migrations.Models.ModelsManyToMany;

namespace Migrations.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public List<MovieCategory> MovieCategory { get; set; }
    }
}
