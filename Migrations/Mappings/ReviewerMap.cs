using Migrations.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Migrations.Mappings
{
    public class ReviewerMap : IEntityTypeConfiguration<Reviewer>
    {
        public void Configure(EntityTypeBuilder<Reviewer> builder)
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
