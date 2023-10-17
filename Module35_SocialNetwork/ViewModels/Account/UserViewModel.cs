using System.Collections.Generic;
using Module35_SocialNetwork.Models.Users;

namespace Module35_SocialNetwork.ViewModels.Account
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
