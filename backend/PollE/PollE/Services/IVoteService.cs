using System.Collections.Generic;
using System.Threading.Tasks;
using PollE.Model;

namespace PollE.Services
{
    public interface IVoteService
    {
        Task<IEnumerable<VoteOptionResult>> GetVoteResultsAsync(string code);
        Task VoteForPollAsync(string code, int optionId, string nickname, bool likes);
    }
}