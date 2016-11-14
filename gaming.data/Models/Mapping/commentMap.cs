using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace gaming.data.Models.Mapping
{
    public class commentMap : EntityTypeConfiguration<comment>
    {
        public commentMap()
        {
            // Primary Key
            this.HasKey(t => t.idComment);

            // Properties
            this.Property(t => t.idComment)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.contents)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("comments");
            this.Property(t => t.idComment).HasColumnName("idComment");
            this.Property(t => t.contents).HasColumnName("contents");
            this.Property(t => t.post_idPost).HasColumnName("post_idPost");

            // Relationships
            this.HasOptional(t => t.post)
                .WithMany(t => t.comments)
                .HasForeignKey(d => d.post_idPost);

        }
    }
}
