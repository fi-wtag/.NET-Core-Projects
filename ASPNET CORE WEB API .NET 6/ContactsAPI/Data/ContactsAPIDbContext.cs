using ContactsAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ContactsAPI.Data
{
    public class ContactsAPIDbContext : DbContext //DbContext from entity framework
    {
        public ContactsAPIDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Contact> Contacts { get; set; }
    }
}
