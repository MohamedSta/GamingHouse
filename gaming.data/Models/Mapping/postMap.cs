using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace gaming.data.Models.Mapping
{
    public class postMap : EntityTypeConfiguration<post>
    {
        public postMap()
        {
            // Primary Key
            this.HasKey(t => t.idPost);

            // Properties
            this.Property(t => t.idPost)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.contents)
                .HasMaxLength(255);

            this.Property(t => t.gamer_idGamer)
                .HasMaxLength(128);

            // Table & Column Mappings
            this.ToTable("post");
            this.Property(t => t.idPost).HasColumnName("idPost");
            this.Property(t => t.contents).HasColumnName("contents");
            this.Property(t => t.gamer_idGamer).HasColumnName("gamer_idGamer");

            // Relationships
            //this.HasOptional(t => t.user)
            //    .WithMany(t => t.posts)
            //    .HasForeignKey(d => d.gamer_idGamer);

        }
    }
}
