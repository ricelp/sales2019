
namespace sales2019.Domain.Models
{
    using System.Data.Entity;

    public class DataContext : DbContext
    {
        public DataContext() : base("DefaultConnection")
        {
        }
    }
}
