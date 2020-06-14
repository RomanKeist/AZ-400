using Microsoft.EntityFrameworkCore;

namespace Vouchers
{
    //To manage Migrations & create the DB go to console:
    //[dotnet restore]
    //dotnet ef migrations add MIGRATION-NAME
    //dotnet ef database update

    public class VouchersDBContext : DbContext
    {
        private VouchersConfig config;

        public VouchersDBContext(DbContextOptions<VouchersDBContext> options) : base(options)
        {
        }

        public DbSet<Voucher> Vouchers { get; set; }
        public DbSet<VoucherDetail> VoucherDetails { get; set; }
        public DbSet<BalanceAccount> BalanceAccounts { get; set; }
    }
}