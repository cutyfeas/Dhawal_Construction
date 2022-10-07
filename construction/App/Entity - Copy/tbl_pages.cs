using System;
using System.Collections.Generic;

#nullable disable

namespace App.Entity
{
    public partial class tbl_pages
    {
        public tbl_pages()
        {
            tbl_role_page = new HashSet<tbl_role_page>();
        }

        public int id { get; set; }
        public string pagename { get; set; }
        public int? createdby { get; set; }
        public int? updatedby { get; set; }
        public DateTime? createddate { get; set; }
        public DateTime? updateddate { get; set; }

        public virtual ICollection<tbl_role_page> tbl_role_page { get; set; }
    }
}
