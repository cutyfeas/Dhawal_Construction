﻿using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Entity
{
    public partial class TblBeneficiaryChoiceMap
    {
        public int Id { get; set; }
        public int? BenId { get; set; }
        public int? Mastertypeid { get; set; }
        public int? Createdby { get; set; }
        public int? Updatedby { get; set; }
        public DateTime? Createddate { get; set; }
        public DateTime? Updateddate { get; set; }

        public virtual TblBeneficiary Ben { get; set; }
        public virtual TblMastertype Mastertype { get; set; }
    }
}