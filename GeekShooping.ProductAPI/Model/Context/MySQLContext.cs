using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace GeekShopping.ProductAPI.Model.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext()
        { }
        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options)
        { }

        public DbSet<Product> Products { get; set; }
    }
}
//add-migration AddProductDataTableOnDB
//Update-Database -Migration AddProductDataTableOnDB