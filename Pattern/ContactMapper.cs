using ContactsAPI.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
// Implementing Fluent API Pattern
namespace ContactsAPI.Pattern;

    public class ContactMapper
    {
        public ContactMapper(EntityTypeBuilder<Contacts> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(t=>t.Id);
            entityTypeBuilder.Property(t => t.FirstName).IsRequired(); 
            entityTypeBuilder.Property(t => t.LastName).IsRequired(); 
            entityTypeBuilder.Property(t => t.Company).IsRequired(); 
        }
    }
