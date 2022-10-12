using System;
using System.Collections.Generic;

#nullable disable

namespace App.Entity
{
    public partial class tbl_user
    {
        public tbl_user()
        {
            UserToken = new HashSet<UserToken>();
        }

        public int id { get; set; }
        public string username { get; set; }
        public string pswd { get; set; }
        public int? roleid { get; set; }
        public int? createdby { get; set; }
        public int? updatedby { get; set; }
        public DateTime? createddate { get; set; }
        public DateTime? updateddate { get; set; }
        public bool? IsActive { get; set; }

        public virtual tbl_role role { get; set; }
        public virtual ICollection<UserToken> UserToken { get; set; }
    }
}
