using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PollE.Controllers.DTOs;
using PollE.DataAccess.Entities;

namespace PollE.DataAccess.Repositories
{
    public class SqlPollRepository : IPollRepository
    {
        private DbSet<PollEntity> Polls { get => _dbContext.Polls;}
        private readonly DBContext _dbContext;
        
        public SqlPollRepository(DBContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        
        public Task<PollEntity> GetPollByCodeAsync(string code)
        {            
            return Polls.SingleOrDefaultAsync(poll => poll.Code.Code == code);
        }

        public async Task InsertPollAsync(PollEntity poll)
        {
            await Polls.AddAsync(poll);
            await _dbContext.SaveChangesAsync();
        }
    }
}