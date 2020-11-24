using System.Threading.Tasks;
using PollE.Model;

namespace PollE.DataAccess.Repositories
{
    public interface IPollRepository
    {
        public Task<Poll> GetPollByCodeAsync(string code);

        public Task InsertPollAsync(Poll poll);
    }
}