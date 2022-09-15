using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Entity
{
    public partial class TblPage
    {
        public TblPage()
        {
            TblRolePages = new HashSet<TblRolePage>();
        }

        public int Id { get; set; }
        public string Pagename { get; set; }
        public int? Createdby { get; set; }
        public int? Updatedby { get; set; }
        public DateTime? Createddate { get; set; }
        public DateTime? Updateddate { get; set; }

        public virtual ICollection<TblRolePage> TblRolePages { get; set; }
    }
}
