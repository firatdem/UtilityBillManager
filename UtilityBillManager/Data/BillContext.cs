using Microsoft.EntityFrameworkCore;
using UtilityBillManager.Models;

namespace UtilityBillManager.Data
{
    public class BillContext : DbContext
    {
        public BillContext(DbContextOptions<BillContext> options) : base(options) {}

        public DbSet<Bill> Bills { get; set; }
    }
}
