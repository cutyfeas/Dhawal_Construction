using System;
using System.Collections.Generic;

#nullable disable

namespace App.Entity
{
    public partial class tbl_role_page
    {
        public int id { get; set; }
        public int? pageid { get; set; }
        public int? roleid { get; set; }
        public int? createdby { get; set; }
        public int? updatedby { get; set; }
        public DateTime? createddate { get; set; }
        public DateTime? updateddate { get; set; }

        public virtual tbl_pages page { get; set; }
        public virtual tbl_role role { get; set; }
    }
}
