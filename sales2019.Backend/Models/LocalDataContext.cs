
namespace sales2019.Backend.Models
{
    using sales2019.Domain.Models;

    public class LocalDataContext : DataContext
    {
        public System.Data.Entity.DbSet<sales2019.Common.Models.Product> Products { get; set; }
    }
}