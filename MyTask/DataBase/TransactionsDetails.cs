using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyTask.DataBase
{
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
