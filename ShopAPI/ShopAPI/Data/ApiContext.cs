using Microsoft.EntityFrameworkCore;
using ShopAPI.Models;

namespace ShopAPI.Data
{
    public class ApiContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public ApiContext(DbContextOptions<ApiContext> options) :base(options)
        {

        }
    }
}
