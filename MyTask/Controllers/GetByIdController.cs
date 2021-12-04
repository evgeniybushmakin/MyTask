using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyTask.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GetByIdController : ControllerBase
    {
        UnitOfWork unitOfWork;
        public GetByIdController()
        {
            unitOfWork = new UnitOfWork();
        }

        /// <summary>
        /// GetTransacionsById
        /// </summary>
        /// <returns>Transaction by identify</returns>
        [HttpGet]
        public IActionResult GetTransacionById(int id)
        {
            return (IActionResult)unitOfWork.Transactions.GetById(id);
        }
    }
}
