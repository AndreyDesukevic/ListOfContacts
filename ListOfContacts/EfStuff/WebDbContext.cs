using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ListOfContacts.EfStuff.DbModel;
using Microsoft.EntityFrameworkCore;


namespace ListOfContacts.EfStuff
{
    public class WebDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public WebDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
