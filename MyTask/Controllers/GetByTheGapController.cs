using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyTask.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class GetByTheGapController : ControllerBase
    {
        /// <summary>
        /// GetTransactionsByTheGap
        /// </summary>
        /// <returns>Transactions in the gap</returns>
        [HttpGet]
        public string GetTransactionsByTheGap()
        {
            return "Method is NotFound!";
        }
    }
}