using System;
using System.Collections.Generic;

#nullable disable

namespace App.Entity
{
    public partial class tbl_beneficiary
    {
        public tbl_beneficiary()
        {
            tbl_beneficiary_choice_map = new HashSet<tbl_beneficiary_choice_map>();
        }

        public int id { get; set; }
        public int? apartmentid { get; set; }
        public string clientid { get; set; }
        public int? condominiumid { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string taxcode { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string Sheet { get; set; }
        public string Parcel { get; set; }
        public string Subdivision { get; set; }
        public string building { get; set; }
        public string staircase { get; set; }
        public string interior { get; set; }
        public string cadastralcategory { get; set; }
        public string sqm { get; set; }
        public int? createdby { get; set; }
        public int? updatedby { get; set; }
        public DateTime? createddate { get; set; }
        public DateTime? updateddate { get; set; }

        public virtual tbl_apartment apartment { get; set; }
        public virtual ICollection<tbl_beneficiary_choice_map> tbl_beneficiary_choice_map { get; set; }
    }
}
