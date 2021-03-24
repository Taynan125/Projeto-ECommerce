using System.Data.Entity;

namespace ECommerceTaynan.Models
{
    public class ECommerceContext : DbContext
    {
        public ECommerceContext() : base("DefaultConnection")
        {

        }
    }
}