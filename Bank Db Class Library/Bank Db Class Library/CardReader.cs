using System;
using System.Collections.Generic;
using System.ComponentModel;

#nullable disable

namespace Bank_Db_Class_Library
{
    public partial class CardReader
    {
        public CardReader()
        {
            IsDeleted = false;
        }

        public int ReaderId { get; set; }
        public int BankId { get; set; }
        public string AccountRecieverIban { get; set; }

        [DefaultValue(false)]
        public bool IsDeleted { get; set; }

        public virtual Account AccountRecieverIbanNavigation { get; set; }
        public virtual Bank Bank { get; set; }
    }
}
