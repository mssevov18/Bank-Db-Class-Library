using System;
using System.Collections.Generic;
using System.ComponentModel;

#nullable disable

namespace Bank_Db_Class_Library
{
    public partial class Request
    {
        public Request()
        {
            IsDeleted = false;
        }

        public Request(
            string Requester,
            DateTime Timestamp,
            bool? IsSuccessful,
            string TableAffected,
            bool? WillDelete,
            string Arguments)
        {
            IsDeleted = false;
            this.Requester = Requester;
            this.Timestamp = Timestamp;
            this.IsSuccessful = IsSuccessful;
            this.TableAffected = TableAffected;
            this.WillDelete = WillDelete;
            this.Arguments = Arguments;
        }

        public int RequestId { get; set; }
        public string Requester { get; set; }
        public DateTime Timestamp { get; set; }
        public bool? IsSuccessful { get; set; }
        public string TableAffected { get; set; }
        public bool? WillDelete { get; set; }
        public string Arguments { get; set; }

        [DefaultValue(false)]
        public bool IsDeleted { get; set; }

        public override string ToString() => $"Request №{RequestId}[{IsSuccessfulToString()}]. {WillDeleteToString()} To table \'{TableAffected}\'. By {RequesterToString()}. At {Timestamp.ToString()}";

        private string RequesterToString()
        {
            switch (Requester)
            {
                case "T":
                    return "'Teller App'";
                case "S":
                    return "'Server App'";
                case "C":
                    return "'Cashier App'";
                case "W":
                    return "'Website'";
            }
            return "#not implemented#";
        }

        private string WillDeleteToString()
        {
            return WillDelete is null ? "Add" : WillDelete.GetValueOrDefault() ? "Delete" : "Update";
        }

        private string IsSuccessfulToString()
        {
            return IsSuccessful is null ? "Pending" : IsSuccessful.GetValueOrDefault() ? "Success" : "Failure";
        }
    }
}
