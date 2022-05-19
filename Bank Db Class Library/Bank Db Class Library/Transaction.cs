using System;
using System.Collections.Generic;

#nullable disable

namespace Bank_Db_Class_Library
{
    public partial class Transaction
    {
        public Transaction()
        {
            TransactionAccountConnections = new HashSet<TransactionAccountConnection>();
        }

        public int TransactionId { get; set; }
        public decimal Amount { get; set; }
        public DateTime Timestamp { get; set; }
        public string Reason { get; set; }

        public virtual ICollection<TransactionAccountConnection> TransactionAccountConnections { get; set; }
    }
}
