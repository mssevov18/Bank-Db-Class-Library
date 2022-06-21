using System;
using System.Collections.Generic;
using System.ComponentModel;

#nullable disable

namespace Bank_Db_Class_Library
{
    public partial class BankWorker
    {
        public BankWorker()
        {
            IsDeleted = false;
        }

        public BankWorker(
            string Username,
            string Password,
            bool IsAdmin,
            decimal Salary,

            int BankId,
            string PersonEgn)
        {
            IsDeleted = false;
            this.Username = Username;
            this.Password = Password;
            this.IsAdmin = IsAdmin;
            this.Salary = Salary;

            this.BankId = BankId;
            this.PersonEgn = PersonEgn;
        }

        public BankWorker(
            int WorkerId,
            string Username,
            string Password,
            bool IsAdmin,
            decimal Salary,

            int BankId,
            string PersonEgn)
        {
            this.WorkerId = WorkerId;
            this.Username = Username;
            this.Password = Password;
            this.IsAdmin = IsAdmin;
            this.Salary = Salary;

            this.BankId = BankId;
            this.PersonEgn = PersonEgn;
        }

        public int WorkerId { get; set; }
        public int BankId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string PersonEgn { get; set; }
        public bool IsAdmin { get; set; }
        public decimal Salary { get; set; }

        [DefaultValue(false)]
        public bool IsDeleted { get; set; }

        public virtual Bank Bank { get; set; }
        public virtual Person PersonEgnNavigation { get; set; }

        ///IDEA: Print bank and person data too.
        ///public override string ToString() => $"{Username}({PersonEgnNavigation.FirstName} " +
        ///        PersonEgnNavigation is null ? "null" : PersonEgnNavigation.MiddleName + " " +
        ///        PersonEgnNavigation is null ? "null" : PersonEgnNavigation.LastName + ")" +
        ///        $"[{PersonEgn}] - " +
        ///        $"Works in " + Bank is null ? "null" : Bank.Name +
        ///        $", for {Salary}$";
        public override string ToString() => $"{Username}({PersonEgnNavigation.FirstName} " +
                PersonEgnNavigation is null ? "null" : PersonEgnNavigation.MiddleName + " " +
                PersonEgnNavigation is null ? "null" : PersonEgnNavigation.LastName + ")" +
                $"[{PersonEgn}] - " +
                $"Works in " + Bank is null ? "null" : Bank.Name +
                $", for {Salary}$";
    }
}
