using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace gaming.data.Models.Mapping
{
    public class trophyMap : EntityTypeConfiguration<trophy>
    {
        public trophyMap()
        {
            // Primary Key
            this.HasKey(t => t.idTrophy);

            // Properties
            this.Property(t => t.idTrophy)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.date)
                .HasMaxLength(255);

            this.Property(t => t.name)
                .HasMaxLength(255);

            this.Property(t => t.type)
                .HasMaxLength(255);

            this.Property(t => t.gamer_idGamer)
                .HasMaxLength(128);

            // Table & Column Mappings
            this.ToTable("trophy");
            this.Property(t => t.idTrophy).HasColumnName("idTrophy");
            this.Property(t => t.date).HasColumnName("date");
            this.Property(t => t.name).HasColumnName("name");
            this.Property(t => t.type).HasColumnName("type");
            this.Property(t => t.gamer_idGamer).HasColumnName("gamer_idGamer");

            // Relationships
            //this.HasOptional(t => t.user)
            //    .WithMany(t => t.trophies)
            //    .HasForeignKey(d => d.gamer_idGamer);

        }
    }
}
