using Microsoft.EntityFrameworkCore;
using Project.Models;


namespace Project
{
    public class DBcontext : DbContext
    {
        public DBcontext(DbContextOptions<DBcontext> options) : base(options)
        {

        }
        public DbSet<Book> Books { get; set; }

    }
}