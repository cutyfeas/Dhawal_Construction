using System;
using System.Collections.Generic;

#nullable disable

namespace App.Entity
{
    public partial class tbl_suppliers
    {
        public tbl_suppliers()
        {
            tbl_mastertype_supplier_map = new HashSet<tbl_mastertype_supplier_map>();
        }

        public int id { get; set; }
        public string name { get; set; }
        public int? createdby { get; set; }
        public int? updatedby { get; set; }
        public DateTime? createddate { get; set; }
        public DateTime? updateddate { get; set; }

        public virtual ICollection<tbl_mastertype_supplier_map> tbl_mastertype_supplier_map { get; set; }
    }
}
