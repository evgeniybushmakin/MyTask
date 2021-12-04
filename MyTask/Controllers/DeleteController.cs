using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyTask.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DeleteController : ControllerBase
    {
        UnitOfWork unitOfWork;
        public DeleteController()
        {
            unitOfWork = new UnitOfWork();
        }

        /// <summary>
        /// DeleteTransactionsById
        /// </summary> 
        /// <returns>Deleted transaction by identify</returns>
        [HttpDelete ("id")]
        public void DeleteTransactionsById(int id)
        {
                unitOfWork.Transactions.Delete(id);
                unitOfWork.Save();
        }
    }
}
