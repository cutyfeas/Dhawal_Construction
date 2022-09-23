using System;
using System.Collections.Generic;

#nullable disable

namespace App.Entity
{
    public partial class tbl_role
    {
        public tbl_role()
        {
            tbl_role_page = new HashSet<tbl_role_page>();
            tbl_user = new HashSet<tbl_user>();
        }

        public int id { get; set; }
        public string rolename { get; set; }
        public int? createdby { get; set; }
        public int? updatedby { get; set; }
        public DateTime? createddate { get; set; }
        public DateTime? updateddate { get; set; }

        public virtual ICollection<tbl_role_page> tbl_role_page { get; set; }
        public virtual ICollection<tbl_user> tbl_user { get; set; }
    }
}
