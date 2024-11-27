using AutoMapper;
using ContactsAPI.DTO;
using ContactsAPI.Functionality;
using ContactsAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace ContactsAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContactController : ControllerBase
    {
        // Need to apply loose coupling for ContactOperation Class
        IContactsOperation contactsOperation;
        private readonly IMapper mapper;
        public ContactController(IContactsOperation _contactsOperation, IMapper _mapper)// DI for ContactOperation
        {
            this.contactsOperation = _contactsOperation;
            this. mapper = _mapper;
        }

        [HttpGet("Get_Contacts")]
        public IActionResult GetContacts()
        {
            var Getcnt = contactsOperation.GetAll();
            var temp = mapper.Map<List<ContactDTO>>(Getcnt);
            return Ok(temp);


        }

        [HttpPost("Add_Contact")]

        public IActionResult AddContact(ContactDTO contactDTO)// we should not pass actual Model name as entities on controller
        {
            var Addcont = mapper.Map<Contacts>(contactDTO);
            var result = contactsOperation.Add(Addcont);
            return Ok(result);

        }
    }
}

