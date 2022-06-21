using System;
using System.Collections.Generic;
using System.ComponentModel;

#nullable disable

namespace Bank_Db_Class_Library
{
    public partial class TransactionAccountConnection
    {
        public TransactionAccountConnection()
        {
            IsDeleted = false;
        }

        public int ConnectionId { get; set; }
        public int TransactionId { get; set; }
        public string AccountSenderIban { get; set; }
        public string AccountRecieverIban { get; set; }

        [DefaultValue(false)]
        public bool IsDeleted { get; set; }

        public virtual Account AccountRecieverIbanNavigation { get; set; }
        public virtual Account AccountSenderIbanNavigation { get; set; }
        public virtual Transaction Transaction { get; set; }
    }
}
