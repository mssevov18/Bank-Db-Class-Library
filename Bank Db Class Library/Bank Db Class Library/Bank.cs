using System;
using System.Collections.Generic;
using System.ComponentModel;

#nullable disable

namespace Bank_Db_Class_Library
{
    public partial class Bank
    {
        public Bank()
        {
            IsDeleted = false;
            Accounts = new HashSet<Account>();
            BankWorkers = new HashSet<BankWorker>();
            Branches = new HashSet<Branch>();
            CardReaders = new HashSet<CardReader>();
        }

        public Bank(int BankId, string Name)
        {
            IsDeleted = false;
            this.BankId = BankId;
            this.Name = Name;

            Accounts = new HashSet<Account>();
            BankWorkers = new HashSet<BankWorker>();
            Branches = new HashSet<Branch>();
            CardReaders = new HashSet<CardReader>();
        }

        public int BankId { get; set; }
        public string Name { get; set; }

        [DefaultValue(false)]
        public bool IsDeleted { get; set; }

        public virtual ICollection<Account> Accounts { get; set; }
        public virtual ICollection<BankWorker> BankWorkers { get; set; }
        public virtual ICollection<Branch> Branches { get; set; }
        public virtual ICollection<CardReader> CardReaders { get; set; }
    }
}
