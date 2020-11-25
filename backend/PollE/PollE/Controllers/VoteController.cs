using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PollE.Services;

namespace PollE.Controllers.DTOs
{
    [ApiController]
    [Route("votes")]
    public class VoteController: ControllerBase
    {
        private readonly ILogger<VoteController> _logger;
        private readonly IVoteService _voteService;

        public VoteController(ILogger<VoteController> logger, IVoteService voteService)
        {
            _logger = logger;
            _voteService = voteService;
        }

        [HttpGet]
        public async Task<IActionResult> Results([FromQuery] string code)
        {
            var results = await _voteService.GetVoteResultsAsync(code);
            return Ok(results.Select(x =>
                new VoteResult()
                {
                    Text = x.Option.Text,
                    Id = x.Option.Id,
                    Likes = x.Likes,
                    Dislikes = x.Dislikes
                })
                .OrderByDescending(x => x.Likes/(x.Likes+x.Dislikes))
                .ThenByDescending(x => x.Likes)
            );
        }

        [HttpPost]
        public async Task<IActionResult> Vote([FromBody] Vote vote)
        {
            await _voteService.VoteForPollAsync(vote.Code, vote.OptionId, vote.Nickname, vote.Likes);
            return Ok();
        }
    }
}