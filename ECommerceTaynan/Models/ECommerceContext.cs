using System.Data.Entity;

namespace ECommerceTaynan.Models
{
    public class ECommerceContext : DbContext
    {
        public ECommerceContext() : base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<ECommerceTaynan.Models.Departaments> Departaments { get; set; }
    }
}