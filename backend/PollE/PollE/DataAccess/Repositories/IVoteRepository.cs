using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using PollE.Model;

namespace PollE.DataAccess.Repositories
{
    public interface IVoteRepository
    {
        Task<IEnumerable<VoteOptionResult>> GetVoteResultsAsync(Poll poll);

        Task VoteForPollAsync(PollOption option, string nickname, bool likes);
    }
}