using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text.RegularExpressions;

#nullable disable

namespace Bank_Db_Class_Library
{
    public partial class Account
    {
        public Account()
        {
            IsDeleted = false;
            CardReaders = new HashSet<CardReader>();
            Cards = new HashSet<Card>();
            TransactionAccountConnectionAccountRecieverIbanNavigations = new HashSet<TransactionAccountConnection>();
            TransactionAccountConnectionAccountSenderIbanNavigations = new HashSet<TransactionAccountConnection>();
        }
        public Account(
                string AccountIban,
                decimal Balance,
                int BankId,
                string PersonEgn,
                DateTime CreationDate,
                string Email,
                string Password
            )
        {
            IsDeleted = false;
            CardReaders = new HashSet<CardReader>();
            Cards = new HashSet<Card>();
            TransactionAccountConnectionAccountRecieverIbanNavigations = new HashSet<TransactionAccountConnection>();
            TransactionAccountConnectionAccountSenderIbanNavigations = new HashSet<TransactionAccountConnection>();

            this.AccountIban = AccountIban;
            this.Balance = Balance;
            this.BankId = BankId;
            this.PersonEgn = PersonEgn;
            this.CreationDate = CreationDate;
            this.Email = Email;
            this.Password = Password;
        }

        public string AccountIban { get; set; }
        public decimal Balance { get; set; }
        public int BankId { get; set; }
        public string PersonEgn { get; set; }
        public DateTime CreationDate { get; set; }
        public int AccountId { get; set; }

        //Local-part@Domain
        //
        // Local-part
        // uppercase and lowercase Latin letters A to Z and a to z
        // digits 0 to 9
        // printable characters !#$%&'*+-/=?^_`{|}~
        // dot., provided that it is not the first or last character and provided also that it does not appear consecutively(e.g., John..Doe @example.com is not allowed).
        //
        // Domain
        // uppercase and lowercase Latin letters A to Z and a to z;
        // digits 0 to 9, provided that top-level domain names are not all-numeric;
        // hyphen -, provided that it is not the first or last character.
        private string email;
        public string Email
        {
            get => email;
            set
            {
                if (value == string.Empty)
                    email = value;
                else
                {
                    if (value.Split('@').Length == 2)
                    {
                        if (Regex.IsMatch(value, @"^\w+([-+.']\w+)*@[^\W_]+(([-.]|[^_])[^\W_]+)*\.?[^\W_]+(([-.]|[^_])[^\W_]+)*$"))
                            email = value;
                        else
                            throw new FormatException($"Invalid email format! {value}");
                    }
                    else
                        throw new FormatException($"Invalid email format! {value}");
                }
            }
        }
        public string Password { get; set; }

        [DefaultValue(false)]
        public bool IsDeleted { get; set; }

        public virtual Bank Bank { get; set; }
        public virtual Person PersonEgnNavigation { get; set; }
        public virtual ICollection<CardReader> CardReaders { get; set; }
        public virtual ICollection<Card> Cards { get; set; }
        public virtual ICollection<TransactionAccountConnection> TransactionAccountConnectionAccountRecieverIbanNavigations { get; set; }
        public virtual ICollection<TransactionAccountConnection> TransactionAccountConnectionAccountSenderIbanNavigations { get; set; }
    }
}
