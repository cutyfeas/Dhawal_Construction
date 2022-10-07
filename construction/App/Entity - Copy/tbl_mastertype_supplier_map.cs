using System;
using System.Collections.Generic;

#nullable disable

namespace App.Entity
{
    public partial class tbl_mastertype_supplier_map
    {
        public int id { get; set; }
        public int? mastertypeid { get; set; }
        public int? supplierid { get; set; }
        public int? quotedvalue { get; set; }
        public int? createdby { get; set; }
        public int? updatedby { get; set; }
        public DateTime? createddate { get; set; }
        public DateTime? updateddate { get; set; }

        public virtual tbl_mastertype mastertype { get; set; }
        public virtual tbl_suppliers supplier { get; set; }
    }
}
