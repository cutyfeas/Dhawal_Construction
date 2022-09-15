using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Entity
{
    public partial class TblRole
    {
        public TblRole()
        {
            TblRolePages = new HashSet<TblRolePage>();
            TblUsers = new HashSet<TblUser>();
        }

        public int Id { get; set; }
        public string Rolename { get; set; }
        public int? Createdby { get; set; }
        public int? Updatedby { get; set; }
        public DateTime? Createddate { get; set; }
        public DateTime? Updateddate { get; set; }

        public virtual ICollection<TblRolePage> TblRolePages { get; set; }
        public virtual ICollection<TblUser> TblUsers { get; set; }
    }
}
