﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Bank_Db_Class_Library
{
    public partial class Card
    {
        public int CardId { get; set; }
        public string AccountHolderIban { get; set; }
        public string CardNum { get; set; }
        public string SecurityNum { get; set; }
        public string HolderName { get; set; }
        public string Pin { get; set; }
        public DateTime ExpirationDate { get; set; }
        public DateTime CreationDate { get; set; }

        public virtual Account AccountHolderIbanNavigation { get; set; }
    }
}
