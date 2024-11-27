using Microsoft.EntityFrameworkCore;
using ContactsAPI.Models;
using ContactsAPI.Pattern;
namespace ContactsAPI.Database
{
    public class ContactsDbContext:DbContext
    {
        // Implementing the Constructor Chaining
        public ContactsDbContext(DbContextOptions dbContextOptions):base(dbContextOptions)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Now need to apply linking between Contacts and ContactMapper
             new ContactMapper(modelBuilder.Entity<Contacts>()); 
        }
        
        public DbSet<Contacts> Contacts{get; set;} // Contactt will be table name
    }
}