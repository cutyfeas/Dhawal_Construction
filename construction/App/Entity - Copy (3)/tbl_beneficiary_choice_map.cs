using System;
using System.Collections.Generic;

#nullable disable

namespace App.Entity
{
    public partial class tbl_beneficiary_choice_map
    {
        public int id { get; set; }
        public int? ben_id { get; set; }
        public int? mastertypeid { get; set; }
        public int? createdby { get; set; }
        public int? updatedby { get; set; }
        public DateTime? createddate { get; set; }
        public DateTime? updateddate { get; set; }

        public virtual tbl_beneficiary ben { get; set; }
        public virtual tbl_mastertype mastertype { get; set; }
    }
}
