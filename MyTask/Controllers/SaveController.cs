using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyTask.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SaveController : ControllerBase
    {
        UnitOfWork unitOfWork;
        public SaveController()
        {
            unitOfWork = new UnitOfWork();
        }

        /// <summary>
        /// SaveTransaction
        /// </summary>
        /// <returns>Saved transaction in database</returns>
        [HttpPut]
        public void SaveTransaction()
        {
            Transactions trn = new Transactions();
            if (trn != null)
            {
                unitOfWork.Save();
            }
        }
    }
}
