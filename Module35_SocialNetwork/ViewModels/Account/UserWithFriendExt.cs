using Module35SocialNetwork.DB.Models.Users;

namespace Module35SocialNetwork.ViewModels.Account
{
    public class UserWithFriendExt : User
    {
        public bool IsFriendWithCurrent { get; set; }
    }
}
