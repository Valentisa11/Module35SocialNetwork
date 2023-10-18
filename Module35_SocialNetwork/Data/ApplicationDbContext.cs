using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Module35_SocialNetwork.Configs;
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

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration<Friend>(new FriendConfiguration());
        }
    }
}
