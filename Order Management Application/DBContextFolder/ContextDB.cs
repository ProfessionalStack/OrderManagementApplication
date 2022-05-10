using Microsoft.EntityFrameworkCore;
using Order_Management_Application.Data;

namespace Order_Management_Application.DBContextFolder
{
    public class ContextDB : DbContext
    {
        public ContextDB(DbContextOptions<ContextDB> options) : base(options)
        {

        }
        public DbSet<Supplier> Suppliers { get; set; }
    }
}
