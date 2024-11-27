using ContactsAPI.Functionality;
using ContactsAPI.Models;
using ContactsAPI.Database;

namespace ContactsAPI.Implementation
{
    public class ContactOperation : IContactsOperation
    {
        // ContactsDbContext contactsDbContext = new ContactsDbContext(); // No need to write new() operator for this class
        private readonly ContactsDbContext dbContext;
        public ContactOperation(ContactsDbContext _contactsDbContext)
        {
            this.dbContext = _contactsDbContext;
        }
        int IContactsOperation.Add(Contacts Item)
        {
            this.dbContext.Add(Item);
            return dbContext.SaveChanges();
        }

        bool IContactsOperation.CheckValidUserKey(string reqkey)
        {
            throw new NotImplementedException();
        }

        Contacts IContactsOperation.Find(string key)
        {
            throw new NotImplementedException();
        }

        List<Contacts> IContactsOperation.GetAll()
        {
            List<Contacts> cont =this.dbContext.Contacts.ToList();
            return cont;
            
        }

        int IContactsOperation.Remove(string Id)
        {
            throw new NotImplementedException();
        }

        int IContactsOperation.Update(Contacts Item)
        {
            throw new NotImplementedException();
        }
    }
}