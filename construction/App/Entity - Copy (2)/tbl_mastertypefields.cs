using System;
using System.Collections.Generic;

#nullable disable

namespace App.Entity
{
    public partial class tbl_mastertypefields
    {
        public int id { get; set; }
        public int? mastertypeid { get; set; }
        public int? masterfieldid { get; set; }
        public int? createdby { get; set; }
        public int? updatedby { get; set; }
        public DateTime? createddate { get; set; }
        public DateTime? updateddate { get; set; }

        public virtual tbl_masterfields masterfield { get; set; }
        public virtual tbl_mastertype mastertype { get; set; }
    }
}
