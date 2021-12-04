using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyTask.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CreateController : ControllerBase
    {
        UnitOfWork unitOfWork;
        public CreateController()
        {
            unitOfWork = new UnitOfWork();
        }

        /// <summary>
        /// CreateTransactions
        /// </summary>
        /// <returns>Created transaction</returns>
        [HttpPut]
        public void CreateTransactions(int id, int accountId, string userName, DateTime transDateTime, DateTime lastUpdateDateTime, string brand, string stack, string customerName)
        {
            Transactions trn = new Transactions(id, accountId, userName, transDateTime, lastUpdateDateTime, brand, stack, customerName);

            unitOfWork.Transactions.Create(trn);
            unitOfWork.Save();
        }
    }
}
