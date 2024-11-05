using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductAPI.Model.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext()
        { }
        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options)
        { }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            for (int i = 1; i <= 10; i++)
            {
                modelBuilder.Entity<Product>().HasData(
                    new Product
                    {
                        Id = i,
                        Name = $"Registro {i}",
                        Price = new decimal(80.1 + i),
                        Description = $"Descrição registro {i}",
                        CategoryName = $"Categoria registro {i}",
                        ImageUrl = $"TesteURL registro {i}"
                    }
                );
            }            
        }
    }
}
//add-migration AddProductDataTableOnDB
//Update-Database -Migration AddProductDataTableOnDB