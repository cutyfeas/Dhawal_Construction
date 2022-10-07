using System;
using System.Collections.Generic;

#nullable disable

namespace App.Entity
{
    public partial class tbl_condominium
    {
        public tbl_condominium()
        {
            tbl_apartment = new HashSet<tbl_apartment>();
        }

        public int id { get; set; }
        public string condominium_name { get; set; }
        public string address { get; set; }
        public string location { get; set; }
        public string zip_code { get; set; }
        public string taxcode { get; set; }
        public string vatnumber { get; set; }
        public string administrator { get; set; }
        public string lat { get; set; }
        public string lng { get; set; }
        public string buildings { get; set; }
        public string users { get; set; }
        public int? createdby { get; set; }
        public int? updatedby { get; set; }
        public DateTime? createddate { get; set; }
        public DateTime? updateddate { get; set; }

        public virtual ICollection<tbl_apartment> tbl_apartment { get; set; }
    }
}
