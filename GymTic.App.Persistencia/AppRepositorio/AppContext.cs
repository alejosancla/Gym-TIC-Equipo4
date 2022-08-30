using Microsoft EntityFrameworkCore;


namespace Gymtic.App.Persistencia{
    public class AppContext : DbContext{
        public DbSet<PlanSaludable> PlanSaludable{get; set;}
        protected  overrride void  OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                .UseSqlServer("Data Source = (LocalDB)\\MSSQLLocalDB; Initial Catalog = GymTic-Gr49-E4")
            }
        }
    }
}