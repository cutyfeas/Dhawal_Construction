using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Entity
{
    public partial class TblCondominium
    {
        public TblCondominium()
        {
            TblApartments = new HashSet<TblApartment>();
        }

        public int Id { get; set; }
        public string CondominiumName { get; set; }
        public string Address { get; set; }
        public string Location { get; set; }
        public string ZipCode { get; set; }
        public string Taxcode { get; set; }
        public string Vatnumber { get; set; }
        public string Administrator { get; set; }
        public string Lat { get; set; }
        public string Lng { get; set; }
        public string Buildings { get; set; }
        public string Users { get; set; }
        public int? Createdby { get; set; }
        public int? Updatedby { get; set; }
        public DateTime? Createddate { get; set; }
        public DateTime? Updateddate { get; set; }

        public virtual ICollection<TblApartment> TblApartments { get; set; }
    }
}
