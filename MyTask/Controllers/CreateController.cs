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
        public void CreateTransactions()
        {
            
        }
    }
}
