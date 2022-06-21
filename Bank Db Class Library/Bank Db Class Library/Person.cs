using System;
using System.Collections.Generic;
using System.ComponentModel;

#nullable disable

namespace Bank_Db_Class_Library
{
    public partial class Person
    {
        public Person()
        {
            IsDeleted = false;
            Accounts = new HashSet<Account>();
            BankWorkers = new HashSet<BankWorker>();
        }

        public Person(
            string Egn,
            string FirstName,
            string MiddleName,
            string LastName,
            string Residence,
            DateTime BirthDay)
        {
            IsDeleted = false;
            this.Egn = Egn;
            this.FirstName = FirstName;
            this.MiddleName = MiddleName;
            this.LastName = LastName;
            this.Residence = Residence;
            this.BirthDay = BirthDay;

            Accounts = new HashSet<Account>();
            BankWorkers = new HashSet<BankWorker>();
        }

        public string Egn { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Residence { get; set; }
        public DateTime BirthDay { get; set; }

        [DefaultValue(false)]
        public bool IsDeleted { get; set; }

        public virtual ICollection<Account> Accounts { get; set; }
        public virtual ICollection<BankWorker> BankWorkers { get; set; }

        public override string ToString() => $"{FirstName} {MiddleName} {LastName} | {Egn} | {Residence} | {BirthDay}";
    }
}
