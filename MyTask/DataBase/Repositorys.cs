using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using static MyTask.Transactions;

namespace MyTask.DataBase
{
    interface IRepository<T> where T : class
    {
        T GetById(int id);
        void Create(T item);
        void Update(T item);
        void Delete(int id);
    }

    public class TransactionsRepository : IRepository<Transactions>
    {
        private TransactionsContext db;

        public TransactionsRepository(TransactionsContext context)
        {
            this.db = context;
        }
        
        #region Methods
        public Transactions GetById(int id)
        {
            return db.TransactionsTable.Find(id);
        }
        public void Create(Transactions transaction)
        {
            db.TransactionsTable.Add(transaction);
        }
        public void Update(Transactions transactions)
        {
            db.Entry(transactions).State = EntityState.Modified;
        }
        public void Delete(int id)
        {
            Transactions transaction = db.TransactionsTable.Find(id);

            if (transaction != null)
                db.TransactionsTable.Remove(transaction);
        }
        #endregion
    }

    public class TransactionsDetailsRepository : IRepository<TransactionsDetails>
    {
        private TransactionsContext db;

        public TransactionsDetailsRepository(TransactionsContext context)
        {
            this.db = context;
        }

        #region Methods
        public TransactionsDetails GetById(int id)
        {
            return db.TransactionsDetailsTable.Find(id);
        }
        public void Create(TransactionsDetails transaction)
        {
            db.TransactionsDetailsTable.Add(transaction);
        }
        public void Update(TransactionsDetails transactions)
        {
            db.Entry(transactions).State = EntityState.Modified;
        }
        public void Delete(int id)
        {
            TransactionsDetails transaction = db.TransactionsDetailsTable.Find(id);
            
            if (transaction != null)
            {
                db.TransactionsDetailsTable.Remove(transaction);
            }
        }
        #endregion
    }
}
