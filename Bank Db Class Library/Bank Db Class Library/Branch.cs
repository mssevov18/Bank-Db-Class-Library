using System;
using System.Collections.Generic;
using System.ComponentModel;

#nullable disable

namespace Bank_Db_Class_Library
{
    public partial class Branch
    { 
        public Branch()
        {
            IsDeleted = false;
        }

        public int BranchId { get; set; }
        public string Address { get; set; }
        public int BankId { get; set; }

        [DefaultValue(false)]
        public bool IsDeleted { get; set; }

        public virtual Bank Bank { get; set; }
    }
}
