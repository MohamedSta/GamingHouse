using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace gaming.data.Models.Mapping
{
    public class gameMap : EntityTypeConfiguration<game>
    {
        public gameMap()
        {
            // Primary Key
            this.HasKey(t => t.idGames);

            // Properties
            this.Property(t => t.idGames)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.name)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("games");
            this.Property(t => t.idGames).HasColumnName("idGames");
            this.Property(t => t.name).HasColumnName("name");
        }
    }
}
