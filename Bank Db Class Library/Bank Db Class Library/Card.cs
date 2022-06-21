using System;
using System.Collections.Generic;
using System.ComponentModel;

#nullable disable

namespace Bank_Db_Class_Library
{
    public partial class Card
    {
        public Card()
        {
            IsDeleted = false;
        }

        public int CardId { get; set; }
        public string AccountHolderIban { get; set; }
        public string CardNum { get; set; }
        public string SecurityNum { get; set; }
        public string HolderName { get; set; }
        public string Pin { get; set; }
        public DateTime ExpirationDate { get; set; }
        public DateTime CreationDate { get; set; }

        [DefaultValue(false)]
        public bool IsDeleted { get; set; }

        public virtual Account AccountHolderIbanNavigation { get; set; }
    }
}
