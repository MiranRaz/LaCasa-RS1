using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaCasa.EntityModels
{
    public class Korisnik : IdentityUser
    {
        public string Ime { get; set; }
    }
}

