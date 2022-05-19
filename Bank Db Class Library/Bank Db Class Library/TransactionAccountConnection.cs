using System;
using System.Collections.Generic;

#nullable disable

namespace Bank_Db_Class_Library
{
    public partial class TransactionAccountConnection
    {
        public int ConnectionId { get; set; }
        public int TransactionId { get; set; }
        public string AccountSenderIban { get; set; }
        public string AccountRecieverIban { get; set; }

        public virtual Account AccountRecieverIbanNavigation { get; set; }
        public virtual Account AccountSenderIbanNavigation { get; set; }
        public virtual Transaction Transaction { get; set; }
    }
}
