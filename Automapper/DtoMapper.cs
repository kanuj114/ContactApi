using AutoMapper;
using ContactsAPI.DTO;
using ContactsAPI.Models;


namespace ContactsAPI.Automapper
{
    public class DtoMapper: Profile // It will map Model(Contact) to ContactDTO
    {
        public DtoMapper()
        {
            CreateMap<Contacts,ContactDTO>().ReverseMap();
        }
    }
}