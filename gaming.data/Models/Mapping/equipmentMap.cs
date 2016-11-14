using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace gaming.data.Models.Mapping
{
    public class equipmentMap : EntityTypeConfiguration<equipment>
    {
        public equipmentMap()
        {
            // Primary Key
            this.HasKey(t => t.idEquipments);

            // Properties
            this.Property(t => t.idEquipments)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.name)
                .HasMaxLength(255);

            this.Property(t => t.quantity)
                .HasMaxLength(255);

            this.Property(t => t.type)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("equipments");
            this.Property(t => t.idEquipments).HasColumnName("idEquipments");
            this.Property(t => t.name).HasColumnName("name");
            this.Property(t => t.quantity).HasColumnName("quantity");
            this.Property(t => t.type).HasColumnName("type");

            // Relationships
            //this.HasMany(t => t.users)
            //    .WithMany(t => t.equipments)
            //    .Map(m =>
            //        {
            //            m.ToTable("gaminghousedb.equipments_sponsor", "gaminghousedb");
            //            m.MapLeftKey("equipments_idEquipments");
            //            m.MapRightKey("sponsor_idSponsor");
            //        });


        }
    }
}
