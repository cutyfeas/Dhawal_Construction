using System;
using System.Collections.Generic;

#nullable disable

namespace App.Entity
{
    public partial class tbl_apartment
    {
        public tbl_apartment()
        {
            tbl_beneficiary = new HashSet<tbl_beneficiary>();
        }

        public int id { get; set; }
        public int? condominiumid { get; set; }
        public string code { get; set; }
        public string building { get; set; }
        public string staircase { get; set; }
        public string floorplan { get; set; }
        public string area { get; set; }
        public string fixtures { get; set; }
        public int? createdby { get; set; }
        public int? updatedby { get; set; }
        public DateTime? createddate { get; set; }
        public DateTime? updateddate { get; set; }

        public virtual tbl_condominium condominium { get; set; }
        public virtual ICollection<tbl_beneficiary> tbl_beneficiary { get; set; }
    }
}
