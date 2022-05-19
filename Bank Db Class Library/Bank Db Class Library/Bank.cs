﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Bank_Db_Class_Library
{
    public partial class Bank
    {
        public Bank()
        {
            Accounts = new HashSet<Account>();
            BankWorkers = new HashSet<BankWorker>();
            Branches = new HashSet<Branch>();
            CardReaders = new HashSet<CardReader>();
        }

        public int BankId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Account> Accounts { get; set; }
        public virtual ICollection<BankWorker> BankWorkers { get; set; }
        public virtual ICollection<Branch> Branches { get; set; }
        public virtual ICollection<CardReader> CardReaders { get; set; }
    }
}
