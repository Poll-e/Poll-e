using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PollE.Controllers.DTOs;
using PollE.DataAccess.DataService;
using PollE.Services;

namespace PollE.Controllers
{
    [ApiController]
    [Route("polls")]
    public class PollController : ControllerBase
    {
        
        private readonly ILogger<PollController> _logger;
        private readonly IPollService _pollService;

        public PollController(ILogger<PollController> logger, IPollService pollService)
        {
            _logger = logger;
            this._pollService = pollService ?? throw new ArgumentNullException(nameof(pollService));
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] PollCreate create)
        {
            var code = await _pollService.CreatePoll(create.Title, create.Category);
            return Ok(new PollCreated(){Code = code});
        }

        [HttpGet]
        [Route("{code?}")]
        public async Task<IActionResult> Get([FromRoute] string code)
        {
            return Ok( await _pollService.GetPollByCode(code));
        }
    }
}