using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Entity
{
    public partial class TblMastertype
    {
        public TblMastertype()
        {
            TblBeneficiaryChoiceMaps = new HashSet<TblBeneficiaryChoiceMap>();
            TblMastertypeSupplierMaps = new HashSet<TblMastertypeSupplierMap>();
            TblMastertypefields = new HashSet<TblMastertypefield>();
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public int? Createdby { get; set; }
        public int? Updatedby { get; set; }
        public DateTime? Createddate { get; set; }
        public DateTime? Updateddate { get; set; }

        public virtual ICollection<TblBeneficiaryChoiceMap> TblBeneficiaryChoiceMaps { get; set; }
        public virtual ICollection<TblMastertypeSupplierMap> TblMastertypeSupplierMaps { get; set; }
        public virtual ICollection<TblMastertypefield> TblMastertypefields { get; set; }
    }
}
