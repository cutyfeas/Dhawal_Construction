using System;
using System.Collections.Generic;

#nullable disable

namespace App.Entity
{
    public partial class tbl_mastertype
    {
        public tbl_mastertype()
        {
            tbl_beneficiary_choice_map = new HashSet<tbl_beneficiary_choice_map>();
            tbl_mastertype_supplier_map = new HashSet<tbl_mastertype_supplier_map>();
            tbl_mastertypefields = new HashSet<tbl_mastertypefields>();
        }

        public int id { get; set; }
        public string description { get; set; }
        public int? createdby { get; set; }
        public int? updatedby { get; set; }
        public DateTime? createddate { get; set; }
        public DateTime? updateddate { get; set; }

        public virtual ICollection<tbl_beneficiary_choice_map> tbl_beneficiary_choice_map { get; set; }
        public virtual ICollection<tbl_mastertype_supplier_map> tbl_mastertype_supplier_map { get; set; }
        public virtual ICollection<tbl_mastertypefields> tbl_mastertypefields { get; set; }
    }
}
