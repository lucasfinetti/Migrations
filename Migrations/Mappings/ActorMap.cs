using Migrations.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Migrations.Mappings
{
    public class ActorMap : IEntityTypeConfiguration<Actor>
    {
        public void Configure(EntityTypeBuilder<Actor> builder)
        {
            builder.Property(c => c.Name)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(c => c.Gender)
                .HasMaxLength(1)
                .IsRequired();
        }
    }
}
