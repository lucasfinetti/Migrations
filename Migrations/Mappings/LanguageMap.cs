using Migrations.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Migrations.Mappings
{
    public class LanguageMap : IEntityTypeConfiguration<Language>
    {
        public void Configure(EntityTypeBuilder<Language> builder)
        {
            builder.HasKey(c => c.LanguageId);

            builder.Property(c => c.Name)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(c => c.Description)
                .HasMaxLength(200)
                .IsRequired();
        }
    }
}
