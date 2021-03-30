using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ECommerceTaynan.Models
{
    public class ECommerceContext : DbContext
    {
        public ECommerceContext() : base("DefaultConnection")
        {

        }

        //DESABILITAR CASCATAS

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }


        public System.Data.Entity.DbSet<ECommerceTaynan.Models.Departaments> Departaments { get; set; }

        public System.Data.Entity.DbSet<ECommerceTaynan.Models.City> Cities { get; set; }

        public System.Data.Entity.DbSet<ECommerceTaynan.Models.Company> Companies { get; set; }

        public System.Data.Entity.DbSet<ECommerceTaynan.Models.User> Users { get; set; }
    }
}