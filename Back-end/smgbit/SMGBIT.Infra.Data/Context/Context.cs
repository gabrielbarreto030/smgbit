using Microsoft.EntityFrameworkCore;
using SMGBIT.Core.Entity;


namespace SMGBIT.Infra.Data.Context
{
   public class ApplicationContext : DbContext
    {
       

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }
        public DbSet<Viagem> Viagens { get; set; }
        public DbSet<TabelaFrete> Fretes { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationContext).Assembly);
        }
    }
}
