using Microsoft.EntityFrameworkCore;

namespace MyCheckedList.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Item> Items { get; set; }

        public DbSet<Member> Members { get; set; }
    }
}
