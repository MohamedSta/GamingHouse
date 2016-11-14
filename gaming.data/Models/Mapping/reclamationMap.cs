using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace gaming.data.Models.Mapping
{
    public class reclamationMap : EntityTypeConfiguration<reclamation>
    {
        public reclamationMap()
        {
            // Primary Key
            this.HasKey(t => t.idReclam);

            // Properties
            this.Property(t => t.idReclam)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.content)
                .HasMaxLength(255);

            this.Property(t => t.subject)
                .HasMaxLength(255);

            this.Property(t => t.title)
                .HasMaxLength(255);

            this.Property(t => t.admin_idAdmin)
                .HasMaxLength(128);

            // Table & Column Mappings
            this.ToTable("reclamation");
            this.Property(t => t.idReclam).HasColumnName("idReclam");
            this.Property(t => t.content).HasColumnName("content");
            this.Property(t => t.subject).HasColumnName("subject");
            this.Property(t => t.title).HasColumnName("title");
            this.Property(t => t.admin_idAdmin).HasColumnName("admin_idAdmin");

            // Relationships
            //this.HasOptional(t => t.user)
            //    .WithMany(t => t.reclamations)
            //    .HasForeignKey(d => d.admin_idAdmin);

        }
    }
}
