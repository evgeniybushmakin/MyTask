using MyTask.DataBase;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace MyTask
{
    public class TransactionsContext : DbContext
    {
        public TransactionsContext() : base("DefaultConnection") { }
        public DbSet<Transactions> TransactionsTable { get; set; }
        public DbSet<TransactionsDetails> TransactionsDetailsTable { get; set; }
    }
}
