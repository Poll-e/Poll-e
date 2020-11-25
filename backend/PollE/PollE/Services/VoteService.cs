using System.Collections.Generic;
using System.Threading.Tasks;
using PollE.DataAccess.Repositories;
using PollE.Model;
using PollE.Services;

namespace PollE.DataAccess.DataService
{
    public class VoteService : IVoteService
    {
        private readonly IPollRepository _pollRepository; 
        private readonly IPollOptionRepository _optionRepository;
        private readonly IVoteRepository _voteRepository;

        public VoteService(IVoteRepository voteRepository, IPollOptionRepository optionRepository, IPollRepository pollRepository)
        {
            this._voteRepository = voteRepository;
            this._optionRepository = optionRepository;
            this._pollRepository = pollRepository;
        }

        public async Task<IEnumerable<VoteOptionResult>> GetVoteResultsAsync(string code)
        {
            var poll = await _pollRepository.GetPollByCodeAsync(code);
            return await _voteRepository.GetVoteResultsAsync(poll);
        }

        public async Task VoteForPollAsync(string code, int optionId, string nickname, bool likes)
        {
            var poll = await _pollRepository.GetPollByCodeAsync(code);
            var option = await _optionRepository.GetOptionForPollWithId(poll, optionId);
            await _voteRepository.VoteForPollAsync(option, nickname, likes);

        }
    }
}