using Migrations.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Migrations.Mappings
{
    public class MovieMap : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.Property(c => c.Title)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(c => c.Description)
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(c => c.ReleaseYear)
                .HasMaxLength(4)
                .IsRequired();

            builder.Property(c => c.DurationHours)
                .HasMaxLength(10)
                .IsRequired();

            builder.Property(c => c.DurationMinutes)
                .HasMaxLength(2)
                .IsRequired();

            builder.Property(c => c.LastUpdate)
                .HasDefaultValueSql("GETDATE()")
                .IsRequired();
        }
    }
}
