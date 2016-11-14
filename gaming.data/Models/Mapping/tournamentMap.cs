using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using gaming.domain.Models;

namespace gaming.data.Models.Mapping
{
    class tournamentMap : EntityTypeConfiguration<tournament>
    {
        public tournamentMap()
        {
            // Primary Key
            this.HasKey(t => t.idtournament);
            //Properties
            this.Property(t => t.idtournament)
               .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(t => t.title)
               .HasMaxLength(255);

            this.Property(t => t.description)
              .HasMaxLength(255);

            this.Property(t => t.date)
             .HasMaxLength(255);

            this.Property(t => t.ImageUrl)
             .HasMaxLength(255);

            this.Property(t => t.lieu)
                .HasMaxLength(255);


            // Table & Column Mappings
            this.ToTable("tournament");
            this.Property(t => t.idtournament).HasColumnName("idtournament");
            this.Property(t => t.title).HasColumnName("title");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.date).HasColumnName("date");
            this.Property(t => t.ImageUrl).HasColumnName("ImageUrl");
            this.Property(t => t.lieu).HasColumnName("lieu");



        }

    }
}
