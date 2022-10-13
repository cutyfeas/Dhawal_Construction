using App.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace App.Models
{
    public class beneficiarymodel
    {

        public beneficiarymodel()
        {
            this.beneficiary = new tbl_beneficiary();
            this.beneficiarylist = new List<tbl_beneficiary>();

            this.beneficiary_map = new tbl_beneficiary_choice_map();
            this.beneficiary_maplist = new List<tbl_beneficiary_choice_map>();

            this.condominiumlist = new List<tbl_condominium>();
            this.appartmentlist = new List<tbl_apartment>();
            this.mastertypelist = new List<tbl_mastertype>();
        }
        public int tabid { get; set; }

        public tbl_beneficiary beneficiary { get; set; }
        public List<tbl_beneficiary> beneficiarylist { get; set; }

        public tbl_beneficiary_choice_map beneficiary_map { get; set; }
        public List<tbl_beneficiary_choice_map> beneficiary_maplist { get; set; }
        public int[] mastertypeids { get; set; }


        public List<tbl_condominium> condominiumlist { get; set; }
        public List<tbl_apartment> appartmentlist { get; set; }
        public List<tbl_mastertype> mastertypelist { get; set; }


    }
}
