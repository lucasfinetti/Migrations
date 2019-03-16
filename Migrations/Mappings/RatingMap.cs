using Migrations.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Migrations.Mappings
{
    public class RatingMap : IEntityTypeConfiguration<Rating>
    {
        public void Configure(EntityTypeBuilder<Rating> builder)
        {
            builder.Property(c => c.Stars)
                   .HasMaxLength(1)
                   .IsRequired();

            builder.Property(c => c.Rate)
                .HasMaxLength(10)
                .IsRequired();
        }
    }
}
