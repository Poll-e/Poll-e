using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PollE.Controllers.DTOs;

namespace PollE.Controllers
{
    [ApiController]
    [Route("polls")]
    public class PollController : ControllerBase
    {


        private readonly ILogger<PollController> _logger;

        public PollController(ILogger<PollController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public PollCreated Post([FromBody] PollCreate create)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        [Route("{code?}")]
        public Poll Get([FromRoute] string Code)
        {
            throw new NotImplementedException();
        }
    }
}