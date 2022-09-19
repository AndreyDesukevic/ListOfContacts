using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ListOfContacts.EfStuff.DbModel
{
    public abstract class BaseModel
    {
        public int Id { get; set; }
    }
}
