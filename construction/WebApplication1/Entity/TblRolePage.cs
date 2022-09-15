using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Entity
{
    public partial class TblRolePage
    {
        public int Id { get; set; }
        public int? Pageid { get; set; }
        public int? Roleid { get; set; }
        public int? Createdby { get; set; }
        public int? Updatedby { get; set; }
        public DateTime? Createddate { get; set; }
        public DateTime? Updateddate { get; set; }

        public virtual TblPage Page { get; set; }
        public virtual TblRole Role { get; set; }
    }
}
