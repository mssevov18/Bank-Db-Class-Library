using System;
using System.Collections.Generic;

#nullable disable

namespace Bank_Db_Class_Library
{
    public partial class Person
    {
        public Person()
        {
            Accounts = new HashSet<Account>();
            BankWorkers = new HashSet<BankWorker>();
        }

        public string Egn { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Residence { get; set; }
        public DateTime BirthDay { get; set; }

        public virtual ICollection<Account> Accounts { get; set; }
        public virtual ICollection<BankWorker> BankWorkers { get; set; }
    }
}
