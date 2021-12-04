using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace MyTask
{
    public class Transactions
    {
        [Key]
        [Required]
        public int id { get; set; }
        [Required]
        public int acoountId { get; set; }
        public string userName
        {
            set
            {
                if (value.Length > 20)
                    throw new Exception("Max length username is 20 characters, please enter another name!");
                else
                    userName = value;
            }
            get
            {
                return userName;
            }
        }
        public DateTime transDateTime { get; set; }
        public DateTime lastUpdateDateTime { get; set; }
        public string brand { get; set; }
        public string stack { get; set; }
        public string customerName { get; set; }



        public class TransactionsDetails
        {
            [Key]
            [Required]
            public int id { get; set; }
            public string value { get; set; }
            public string type { get; set; }
            public string name { get; set; }
        }
    }
}
