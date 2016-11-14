using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace gaming.data.Models.Mapping
{
    public class sponsorMap : EntityTypeConfiguration<sponsor>
    {
        public sponsorMap()
        {
            // Primary Key
            this.HasKey(t => t.idSponsor);

            // Properties
            this.Property(t => t.addressSponsor)
                .HasMaxLength(255);

            this.Property(t => t.entreprise)
                .HasMaxLength(255);

            this.Property(t => t.location)
                .HasMaxLength(255);

            this.Property(t => t.nameSponsor)
                .HasMaxLength(255);

            this.Property(t => t.phonenumberSponsor)
                .HasMaxLength(255);

            this.Property(t => t.date)
                .HasMaxLength(1073741823);

            // Table & Column Mappings
            this.ToTable("sponsor");
            this.Property(t => t.idSponsor).HasColumnName("idSponsor");
            this.Property(t => t.addressSponsor).HasColumnName("addressSponsor");
            this.Property(t => t.entreprise).HasColumnName("entreprise");
            this.Property(t => t.location).HasColumnName("location");
            this.Property(t => t.nameSponsor).HasColumnName("nameSponsor");
            this.Property(t => t.phonenumberSponsor).HasColumnName("phonenumberSponsor");
            this.Property(t => t.picture).HasColumnName("picture");
            this.Property(t => t.date).HasColumnName("date");
        }
    }
}
