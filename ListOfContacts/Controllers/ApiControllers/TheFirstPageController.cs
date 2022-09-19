using ListOfContacts.EfStuff.DbModel;
using ListOfContacts.EfStuff.DbRepositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace ListOfContacts.Controllers.ApiControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TheFirstPageController : ControllerBase
    {
        private readonly ContactRepository _contactRepository;

        public TheFirstPageController(ContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        public async Task RemoveContact(int id) => await _contactRepository.Remove(id);

        public void EditContact(int id,string name, string mobilePhone, string jobTitle, DateTime birthDate)
        {
            var currentContact = _contactRepository.Get(id);
            currentContact.Name = name;
            currentContact.MobilePhone = mobilePhone;
            currentContact.JobTitle = jobTitle;
            currentContact.BirthDate = birthDate;
           _contactRepository.Save(currentContact);
        }
        public void AddContact(string name, string mobilePhone, string jobTitle, DateTime birthDate)
        {
            var newContact = new Contact()
            {
                Name = name,
                MobilePhone = mobilePhone,
                JobTitle = jobTitle,
                BirthDate = birthDate
            };
            _contactRepository.Save(newContact);
        }
    }
}
