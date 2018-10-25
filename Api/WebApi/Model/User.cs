using System;
using System.Collections.Generic;

namespace WebApi.Model
{
    public partial class User
    {
        public User()
        {
            UserClaim = new HashSet<UserClaim>();
        }

        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public ICollection<UserClaim> UserClaim { get; set; }
    }
}
