using App.Entity;
using System.Collections.Generic;

namespace App.Models
{
    public class appartmentmodel
    {

        public appartmentmodel()
        {
            this.condominium = new tbl_condominium();
            this.condominiumlist = new List<tbl_condominium>();

            this.apartment = new tbl_apartment();
            this.apartmentlist = new List<tbl_apartment>();

        }
        public int tabid { get; set; }

        public tbl_condominium condominium { get; set; }
        public List<tbl_condominium> condominiumlist { get; set; }

        public tbl_apartment apartment { get; set; }
        public List<tbl_apartment> apartmentlist { get; set; }


    }
}
