using System;
using System.Collections.Generic;

#nullable disable

namespace Bank_Db_Class_Library
{
    public partial class Request
    {
        public int RequestId { get; set; }
        public string Requester { get; set; }
        public DateTime Timestamp { get; set; }
        public bool? IsSuccessful { get; set; }
        public string TableAffected { get; set; }
        public bool? WillDelete { get; set; }
        public string Arguments { get; set; }
    }
}
