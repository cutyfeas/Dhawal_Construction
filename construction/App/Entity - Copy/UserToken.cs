using System;
using System.Collections.Generic;

#nullable disable

namespace App.Entity
{
    public partial class UserToken
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public string Token { get; set; }
        public DateTime? IssuedOn { get; set; }
        public DateTime? ExpiresOn { get; set; }
        public bool? IsActive { get; set; }

        public virtual tbl_user User { get; set; }
    }
}
