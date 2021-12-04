using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyTask.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class UpdateController : ControllerBase
    {
        UnitOfWork unitOfWork;
        public UpdateController()
        {
            unitOfWork = new UnitOfWork();
        }

        /// <summary>
        /// UpdateTransactions
        /// </summary>
        /// <returns>Updated transaction</returns>
        [HttpPut]
        public void UpdateTransactions()
        {
            Transactions trn = new Transactions();
            if (trn != null)
            {
                unitOfWork.Transactions.Update(trn);
                unitOfWork.Save();
            }
        }
    }
}