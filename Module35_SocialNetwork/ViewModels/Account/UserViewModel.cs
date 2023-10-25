using System.Collections.Generic;
using Module35SocialNetwork.DB.Models.Users;

namespace Module35SocialNetwork.ViewModels.Account
{
    public class UserViewModel
    {
        public User User { get; set; }

        public UserViewModel(User user)
        {
            User = user;
        }

        public List<User> Friends { get; set; }

    }
}
