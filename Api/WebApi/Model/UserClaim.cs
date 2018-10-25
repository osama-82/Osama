using System;
using System.Collections.Generic;

namespace WebApi.Model
{
    public partial class UserClaim
    {
        public Guid ClaimId { get; set; }
        public Guid UserId { get; set; }
        public string ClaimType { get; set; }
        public string ClaimValue { get; set; }

        public User User { get; set; }
    }
}
