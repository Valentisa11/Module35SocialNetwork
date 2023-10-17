using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Threading.Tasks;


namespace Module35_SocialNetwork.Models.Users
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string MiddleName { get; set; }

        public DateTime BirthDate { get; set; }
    }
}
