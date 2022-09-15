using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Entity
{
    public partial class TblMastertypeSupplierMap
    {
        public int Id { get; set; }
        public int? Mastertypeid { get; set; }
        public int? Supplierid { get; set; }
        public int? Quotedvalue { get; set; }
        public int? Createdby { get; set; }
        public int? Updatedby { get; set; }
        public DateTime? Createddate { get; set; }
        public DateTime? Updateddate { get; set; }

        public virtual TblMastertype Mastertype { get; set; }
        public virtual TblSupplier Supplier { get; set; }
    }
}
