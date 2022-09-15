using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Entity
{
    public partial class TblMasterfield
    {
        public TblMasterfield()
        {
            TblMastertypefields = new HashSet<TblMastertypefield>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Datatype { get; set; }
        public int? Createdby { get; set; }
        public int? Updatedby { get; set; }
        public DateTime? Createddate { get; set; }
        public DateTime? Updateddate { get; set; }
        public int? Createdby1 { get; set; }
        public int? Updatedby1 { get; set; }
        public DateTime? Createddate1 { get; set; }
        public DateTime? Updateddate1 { get; set; }

        public virtual ICollection<TblMastertypefield> TblMastertypefields { get; set; }
    }
}
