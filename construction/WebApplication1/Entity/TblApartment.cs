using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Entity
{
    public partial class TblApartment
    {
        public TblApartment()
        {
            TblBeneficiaries = new HashSet<TblBeneficiary>();
        }

        public int Id { get; set; }
        public int? Condominiumid { get; set; }
        public string Code { get; set; }
        public string Building { get; set; }
        public string Staircase { get; set; }
        public string Floorplan { get; set; }
        public string Area { get; set; }
        public string Fixtures { get; set; }
        public int? Createdby { get; set; }
        public int? Updatedby { get; set; }
        public DateTime? Createddate { get; set; }
        public DateTime? Updateddate { get; set; }

        public virtual TblCondominium Condominium { get; set; }
        public virtual ICollection<TblBeneficiary> TblBeneficiaries { get; set; }
    }
}
