using ListOfContacts.EfStuff.DbRepositories;
using ListOfContacts.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ListOfContacts.Controllers
{
    public class TheFirstPageController : Controller
    {
        private readonly ContactRepository _contactRepository;

        public TheFirstPageController(ContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        [Authorize]
        public IActionResult Index()
        {
            var dbContacts = _contactRepository.GetAll();
            var viewModel = dbContacts.Select(dbContact => new ContactViewModel
            {
                Id = dbContact.Id,
                Name = dbContact.Name,
                MobilePhone = dbContact.MobilePhone,
                JobTitle=dbContact.JobTitle,
                BirthDate = dbContact.BirthDate,
            }).ToList();
            return View(viewModel);
        }
    }
}
