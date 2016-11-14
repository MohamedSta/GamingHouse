using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace gaming.data.Models.Mapping
{
    public class eventMap : EntityTypeConfiguration<Event>
    {
        public eventMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.dateEvent);
               

            this.Property(t => t.title)
                .HasMaxLength(255);

            this.Property(t => t.type)
                .HasMaxLength(255);

            this.Property(t => t.Pic)
                .HasMaxLength(255);

          
              
            this.Property(t => t.lieu)
               .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("event");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.dateEvent).HasColumnName("dateEvent");
            this.Property(t => t.title).HasColumnName("title");
            this.Property(t => t.type).HasColumnName("type");
            this.Property(t => t.Pic).HasColumnName("Pic");
            this.Property(t => t.lieu).HasColumnName("lieu");
            
        }
    }
}
