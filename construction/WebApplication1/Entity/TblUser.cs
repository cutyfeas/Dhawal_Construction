using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Entity
{
    public partial class TblUser
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public int? Roleid { get; set; }
        public int? Createdby { get; set; }
        public int? Updatedby { get; set; }
        public DateTime? Createddate { get; set; }
        public DateTime? Updateddate { get; set; }

        public virtual TblRole Role { get; set; }
    }
}
