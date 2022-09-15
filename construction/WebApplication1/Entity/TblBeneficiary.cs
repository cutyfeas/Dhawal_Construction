using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Entity
{
    public partial class TblBeneficiary
    {
        public TblBeneficiary()
        {
            TblBeneficiaryChoiceMaps = new HashSet<TblBeneficiaryChoiceMap>();
        }

        public int Id { get; set; }
        public int? Apartmentid { get; set; }
        public string Clientid { get; set; }
        public int? Condominiumid { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Taxcode { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Sheet { get; set; }
        public string Parcel { get; set; }
        public string Subdivision { get; set; }
        public string Building { get; set; }
        public string Staircase { get; set; }
        public string Interior { get; set; }
        public string Cadastralcategory { get; set; }
        public string Sqm { get; set; }
        public int? Createdby { get; set; }
        public int? Updatedby { get; set; }
        public DateTime? Createddate { get; set; }
        public DateTime? Updateddate { get; set; }

        public virtual TblApartment Apartment { get; set; }
        public virtual ICollection<TblBeneficiaryChoiceMap> TblBeneficiaryChoiceMaps { get; set; }
    }
}
