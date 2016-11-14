using gaming.data.Models.Mapping;
using gaming.domain.Models;
using System.Data.Entity;


namespace gaming.data.Models
{
    public partial class gaminghousedbContext : DbContext
    {
        static gaminghousedbContext()
        {
            Database.SetInitializer<gaminghousedbContext>(null);
        }

        public gaminghousedbContext()
            : base("Name=gaminghousedbContext")
        {
        }

       
        public DbSet<comment> comments { get; set; }
        public DbSet<equipment> equipments { get; set; }
        public DbSet<Event> events { get; set; }
      
        public DbSet<game> games { get; set; }
        public DbSet<news> news { get; set; }
       
        public DbSet<post> posts { get; set; }
        public DbSet<reclamation> reclamations { get; set; }
        public DbSet<schedule> schedules { get; set; }
        public DbSet<sponsor> sponsors { get; set; }
        public DbSet<trophy> trophies { get; set; }
        public DbSet<tournament> tournaments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           
            modelBuilder.Configurations.Add(new commentMap());
            modelBuilder.Configurations.Add(new equipmentMap());
            modelBuilder.Configurations.Add(new eventMap());
           
            modelBuilder.Configurations.Add(new gameMap());
            modelBuilder.Configurations.Add(new newsMap());
            modelBuilder.Configurations.Add(new tournamentMap());

            modelBuilder.Configurations.Add(new postMap());
            modelBuilder.Configurations.Add(new reclamationMap());
            modelBuilder.Configurations.Add(new scheduleMap());
            modelBuilder.Configurations.Add(new sponsorMap());
            modelBuilder.Configurations.Add(new trophyMap());
        }
    }
}
