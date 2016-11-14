using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace gaming.data.Models.Mapping
{
    public class scheduleMap : EntityTypeConfiguration<schedule>
    {
        public scheduleMap()
        {
            // Primary Key
            this.HasKey(t => t.idSchedule);

            // Properties
            this.Property(t => t.idSchedule)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.dateSchedule)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("schedule");
            this.Property(t => t.idSchedule).HasColumnName("idSchedule");
            this.Property(t => t.dateSchedule).HasColumnName("dateSchedule");
        }
    }
}
