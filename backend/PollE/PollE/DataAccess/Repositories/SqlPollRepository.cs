using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PollE.Controllers.DTOs;
using PollE.DataAccess.Entities;
using static PollE.DataAccess.Utils.Converter;
using Poll = PollE.Model.Poll;

namespace PollE.DataAccess.Repositories
{
    public class SqlPollRepository : IPollRepository
    {
        private DbSet<PollEntity> Polls { get => _pollEDbContext.Polls;}
        private readonly PollEDbContext _pollEDbContext;
        
        public SqlPollRepository(PollEDbContext pollEDbContext)
        {
            _pollEDbContext = pollEDbContext;
        }
        
        
        public async Task<Poll> GetPollByCodeAsync(string code)
        {            
            var poll = await Polls.SingleOrDefaultAsync(x => x.Code == code);
            return poll.ToModel();
        }

        public async Task InsertPollAsync(Poll poll)
        {
            await Polls.AddAsync(new PollEntity()
            {
                Title = poll.Title,
                Category = poll.Category,
                Code = poll.Code
            });
            await _pollEDbContext.SaveChangesAsync();
        }
    }
}