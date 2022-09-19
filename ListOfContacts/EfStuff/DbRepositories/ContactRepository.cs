using ListOfContacts.EfStuff;
using ListOfContacts.EfStuff.DbModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListOfContacts.EfStuff.DbRepositories
{
    public class ContactRepository : BaseRepository<Contact>
    {
        public ContactRepository(WebDbContext context) : base(context)
        {

        }

    }
}
