using Microsoft.EntityFrameworkCore;

public class CurrencyDBContext: DbContext
{
    public DbSet<CurrencyDbModel> CurrencyDb {get; set;}
     protected override void  OnConfiguring(DbContextOptionsBuilder options) 
     => options.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=Currency;Trusted_Connection=True;");
} 