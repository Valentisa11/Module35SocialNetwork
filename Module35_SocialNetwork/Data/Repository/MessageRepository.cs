using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Module35_SocialNetwork.Models.Users;

namespace Module35_SocialNetwork.Data.Repository
{
    public class MessageRepository : Repository<Message>
    {
        public MessageRepository(ApplicationDbContext db)
        : base(db)
        {

        }
    }
}
