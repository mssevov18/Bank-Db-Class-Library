using System;
using System.Collections.Generic;
using System.ComponentModel;

#nullable disable

namespace Bank_Db_Class_Library
{
    public partial class Transaction
    {
        public Transaction()
        {
            IsDeleted = false;
            TransactionAccountConnections = new HashSet<TransactionAccountConnection>();
        }

        public int TransactionId { get; set; }
        public decimal Amount { get; set; }
        public DateTime Timestamp { get; set; }
        public string Reason { get; set; }

        [DefaultValue(false)]
        public bool IsDeleted { get; set; }

        public virtual ICollection<TransactionAccountConnection> TransactionAccountConnections { get; set; }
    }
}
