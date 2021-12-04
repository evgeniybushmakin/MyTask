using MyTask.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyTask
{
    public class UnitOfWork : IDisposable
    {
        private TransactionsContext db = new TransactionsContext();
        private TransactionsRepository transactionsRepository;
        private TransactionsDetailsRepository transactionsDetailsRepository;
        private bool disposed = false;

        public TransactionsRepository Transactions
        {
            get
            {
                if (transactionsRepository == null)
                    transactionsRepository = new TransactionsRepository(db);
                return transactionsRepository;
            }
        }

        public TransactionsDetailsRepository TransactionsDetails
        {
            get
            {
                if (transactionsDetailsRepository == null)
                    transactionsDetailsRepository = new TransactionsDetailsRepository(db);
                return transactionsDetailsRepository;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
