using LM.BuisnessEntities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace LM.BuisnessEntities.Mapping
{
    public partial class BookMap : EntityTypeConfiguration<Book>
    {
        public BookMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Book");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.AuthorId).HasColumnName("AuthorId");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Copy).HasColumnName("Copy");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateModified).HasColumnName("DateModified");

            // Relationships
            this.HasRequired(t => t.Author)
                .WithMany(t => t.Books)
                .HasForeignKey(d => d.AuthorId);

			CustomConfiguration();
        }

		partial void CustomConfiguration();
    }
}
