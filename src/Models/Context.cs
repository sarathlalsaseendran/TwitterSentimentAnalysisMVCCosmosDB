namespace TwitterFeed.Models
{
    using System.Data.Entity;

    public class Context : DbContext
    {
        public Context() : base("name=Context")
        {
        }

        public DbSet<TwitterFeed> Items { get; set; }
    }
}
