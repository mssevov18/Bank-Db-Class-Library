using System;
using System.Collections.Generic;

#nullable disable

namespace Bank_Db_Class_Library
{
    public partial class BankWorker
    {
        public int WorkerId { get; set; }
        public int BankId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string PersonEgn { get; set; }
        public bool IsAdmin { get; set; }
        public decimal Salary { get; set; }

        public virtual Bank Bank { get; set; }
        public virtual Person PersonEgnNavigation { get; set; }
    }
}
