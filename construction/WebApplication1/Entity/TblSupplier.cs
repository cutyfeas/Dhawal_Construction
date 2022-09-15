using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Entity
{
    public partial class TblSupplier
    {
        public TblSupplier()
        {
            TblMastertypeSupplierMaps = new HashSet<TblMastertypeSupplierMap>();
        }

        public int Id { get; set; }
        public int? Name { get; set; }
        public int? Createdby { get; set; }
        public int? Updatedby { get; set; }
        public DateTime? Createddate { get; set; }
        public DateTime? Updateddate { get; set; }

        public virtual ICollection<TblMastertypeSupplierMap> TblMastertypeSupplierMaps { get; set; }
    }
}
