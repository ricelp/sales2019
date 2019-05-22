
namespace sales2019.Domain.Models
{
    using System.Data.Entity;

    public class DataContext : DbContext
    {
        public DataContext() : base("DefaultConnection")
        {
        }

        public System.Data.Entity.DbSet<sales2019.Common.Models.Product> Products { get; set; }
    }
}
