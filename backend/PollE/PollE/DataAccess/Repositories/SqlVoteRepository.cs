using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.Connections;
using Microsoft.EntityFrameworkCore;
using PollE.DataAccess.Entities;
using PollE.DataAccess.Utils;
using PollE.Model;

namespace PollE.DataAccess.Repositories
{
    class SqlVoteRepository : IVoteRepository
    {
        private DbSet<PollOptionEntity> Options { get => _pollEDbContext.Options;}
        private DbSet<VoteEntity> Votes { get => _pollEDbContext.Votes;}

        private readonly PollEDbContext _pollEDbContext;

        public SqlVoteRepository(PollEDbContext pollEDbContext)
        {
            _pollEDbContext = pollEDbContext;
        }


        public async Task<IEnumerable<VoteOptionResult>> GetVoteResultsAsync(Poll poll)
        {
            return await Options
                .Where(x => x.Poll.Id == poll.Id)
                .Select(option => new VoteOptionResult()
                {
                    Option = option.ToModel(),
                    Likes = option.Votes.Count(vote => vote.Likes),
                    Dislikes = option.Votes.Count(vote => !vote.Likes)
                })
                .ToListAsync();
        }

        public async Task VoteForPollAsync(PollOption option, string nickname, bool likes)
        {
            var vote = new VoteEntity()
            {
                Likes = likes,
                Option = Options.Single(x => x.Id == option.Id),
                Nickname = nickname
            };
            await Votes.AddAsync(vote);
            await _pollEDbContext.SaveChangesAsync();
        }
    }
}