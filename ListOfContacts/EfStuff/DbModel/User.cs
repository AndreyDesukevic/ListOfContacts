using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ListOfContacts.EfStuff.DbModel
{
    public class User:BaseModel
    {
        public string FirstName { get; set; }
        public string LastNamme { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

    }
}
