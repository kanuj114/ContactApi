using ContactsAPI.Models;

namespace ContactsAPI.Functionality
{
    public interface IContactsOperation
    {
        int Add (Contacts Item);
        List<Contacts>GetAll();
        Contacts Find(string key);
        int Remove(string Id);
        int Update(Contacts Item);
        bool CheckValidUserKey(string reqkey); // Through this we apply middleware
    }
}