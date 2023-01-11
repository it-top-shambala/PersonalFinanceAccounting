
using Microsoft.EntityFrameworkCore;
using PersonalFinanceAccounting.Library.Models;

namespace PersonalFinanceAccounting.Library.ObjectsDbSet
{
    internal class ObjDbSet : DbContext
    {
        public DbSet<CategoryExpense> categoriesExpense { get; set; }
        public DbSet<CategoryRefill> categoriesRefill { get; set; }
        public DbSet<Expensing> expenses { get; set; }
        public DbSet<Refilling> refills { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<Valuta> valutas { get; set; }
        public DbSet<Wallet> wallets { get; set; }



        public ObjDbSet()
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=GR-OFFC\SQLEXPRESS;Database=PerFinAccDb;Trusted_Connection=True;");
            }
        }
    }
}
