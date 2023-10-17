using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Module35_SocialNetwork.Models.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace Module35_SocialNetwork.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public static implicit operator System.Data.Entity.DbContext(ApplicationDbContext v)
        {
            throw new NotImplementedException();
        }
    }
}
