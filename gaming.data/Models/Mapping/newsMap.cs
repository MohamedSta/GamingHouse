using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace gaming.data.Models.Mapping
{
    public class newsMap : EntityTypeConfiguration<news>
    {
        public newsMap()
        {
            // Primary Key
            this.HasKey(t => t.idNews);

            // Properties
            this.Property(t => t.idNews)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.description)
                .HasMaxLength(2550);

            this.Property(t => t.title)
                .HasMaxLength(255);

            this.Property(t => t.Image)
                .HasMaxLength(255);

            this.Property(t => t.DatePub);
               

            // Table & Column Mappings
            this.ToTable("news");
            this.Property(t => t.idNews).HasColumnName("idNews");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.title).HasColumnName("title");
            this.Property(t => t.Image).HasColumnName("Image");
            this.Property(t => t.DatePub).HasColumnName("DatePub");
        }
    }
}
