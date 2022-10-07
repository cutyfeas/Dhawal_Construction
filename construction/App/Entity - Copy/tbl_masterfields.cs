using System;
using System.Collections.Generic;

#nullable disable

namespace App.Entity
{
    public partial class tbl_masterfields
    {
        public tbl_masterfields()
        {
            tbl_mastertypefields = new HashSet<tbl_mastertypefields>();
        }

        public int id { get; set; }
        public string name { get; set; }
        public string datatype { get; set; }
        public int? createdby { get; set; }
        public int? updatedby { get; set; }
        public DateTime? createddate { get; set; }
        public DateTime? updateddate { get; set; }
        public int? createdby1 { get; set; }
        public int? updatedby1 { get; set; }
        public DateTime? createddate1 { get; set; }
        public DateTime? updateddate1 { get; set; }

        public virtual ICollection<tbl_mastertypefields> tbl_mastertypefields { get; set; }
    }
}
