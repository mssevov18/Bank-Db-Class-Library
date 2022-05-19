using System;
using System.Collections.Generic;

#nullable disable

namespace Bank_Db_Class_Library
{
    public partial class GetAccountDatum
    {
        public string AccountFullName { get; set; }
        public decimal Balance { get; set; }
        public string BankName { get; set; }
        public int? CardAmount { get; set; }
    }
}
